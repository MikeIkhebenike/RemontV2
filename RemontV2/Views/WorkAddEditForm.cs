using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemontV2.Models;
using RemontV2.Utils;

namespace RemontV2.Views
{
    public partial class WorkAddEditForm : Form
    {
        Ремонт currentWork = new Ремонт();
        public WorkAddEditForm()
        {
            InitializeComponent();
        }

        
        

        private void WorkAddEditForm_Load(object sender, EventArgs e)
        {
            комплектующееBindingSource.DataSource = DatabaseContext.db.Комплектующее.ToList();
            заявкаBindingSource.DataSource = DatabaseContext.db.Заявка.ToList();
            сотрудникBindingSource.DataSource = DatabaseContext.db.Сотрудник.ToList();
            статусРаботBindingSource.DataSource = DatabaseContext.db.СтатусРабот.ToList();
            услугаBindingSource.DataSource = DatabaseContext.db.Услуга.ToList();
            
            foreach (WorkCard Wcard in WorksForm.selectedWorkCard)
            {
                currentWork = DatabaseContext.db.Ремонт.First(x => x.ДатаНач == Wcard.wkOpenLbl.Text);
                ремонтBindingSource.DataSource = currentWork;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SaveWorkBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(Convert.ToString(currentWork.ID_сотрудника)))
            {
                errors.AppendLine("Укажите  сотрудника, отвтственного за работу");
            }
            if (string.IsNullOrWhiteSpace(currentWork.Характер_ремонта))
            {
                errors.AppendLine("Укажите характер ремонта");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (currentWork.ID_сотрудника == 0)
            {
                DatabaseContext.db.Ремонт.Add(currentWork);
            }
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }

        private void DeleteWorkBtn_Click(object sender, EventArgs e)
        {

        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bitmap bitmap;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PrintWork printWork = new PrintWork();
            printWork.DateStart = датаНачDateTimePicker.Text;
            printWork.DateEnd = датаЗавершDateTimePicker.Text;
            printWork.WorkID = iD_работыTextBox.Text;
            printWork.RequestID = iD_заявкиComboBox.SelectedValue.ToString();
            printWork.WorkType = характер_ремонтаTextBox.Text;
            printWork.Employee = iD_сотрудникаComboBox.SelectedValue.ToString();
            printWork.Accessorie = iD_комплектующегоComboBox.SelectedValue.ToString();
            printWork.Service = iD_услугиComboBox.SelectedValue.ToString();
            printWork.Status = iD_статусаComboBox.SelectedValue.ToString();
            printWork.Cost = "20000 руб.";
            printWork.ShowDialog();

            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
