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
using RemontV2.Views;

namespace RemontV2.Views
{
    public partial class EMPAddEditForm : Form
    {
        Сотрудник currentEmployee = new Сотрудник();
        public static Авторизация auth { get; set; }
        public EMPAddEditForm()
        {
            InitializeComponent();
        }
         private void groupBox1_Enter_1(object sender, EventArgs e)
         {

         }

        private void EMPAddEditForm_Load(object sender, EventArgs e)
        {
            //employeeBindingSource.DataSource = DatabaseContext.db.Сотрудник.ToList();
            авторизацияBindingSource.DataSource = DatabaseContext.db.Авторизация.ToList();
            roleBindingSource.DataSource = DatabaseContext.db.Роль.ToList();
            foreach (EmployeeCard ecard in EmployeeForm.selectedEmployeeCard)
            {
                currentEmployee = DatabaseContext.db.Сотрудник.First(x => x.Контактный_телефон == ecard.phoneLbl.Text);
                employeeBindingSource.DataSource = currentEmployee;
                photoPictureBox.ImageLocation = currentEmployee.Фото;

            }

        }

        private void ShutDownEMPBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory + @"\сотрудники\";
            openFileDialog.Filter = "png files (*.png)|*.png|All Files (*.*)|*.*";

            DialogResult dialogresult = openFileDialog.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                int num = file.IndexOf("сотрудники");
                file = file.Substring(num);
                photoPictureBox.Image = Image.FromFile(file);
                currentEmployee.Фото = file;
            }
        }

        private void saveChangeEMPBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentEmployee.ФИО))
            {
                errors.AppendLine("Укажите Фамилию Имя и Отчество агента через пробел");
            }
            if (string.IsNullOrWhiteSpace(currentEmployee.Контактный_телефон))
            {
                errors.AppendLine("Укажите телефон");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (currentEmployee.ID_сотрудника == 0)
            {
                DatabaseContext.db.Сотрудник.Add(currentEmployee);
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

        private void saveUserBtn_Click(object sender, EventArgs e)
        {
            //StringBuilder errors = new StringBuilder();
            //if (string.IsNullOrWhiteSpace(currentEmployee.Авторизация.))
            //{
            //    errors.AppendLine("Укажите Фамилию Имя и Отчество агента через пробел");
            //}
            //if (string.IsNullOrWhiteSpace(currentEmployee.Контактный_телефон))
            //{
            //    errors.AppendLine("Укажите телефон");
            //}
            //if (errors.Length > 0)
            //{
            //    MessageBox.Show(errors.ToString());
            //    return;
            //}

            //if (currentEmployee.ID_сотрудника == 0)
            //{
            //    DatabaseContext.db.Сотрудник.Add(currentEmployee);
            //}
            //try
            //{
            //    DatabaseContext.db.SaveChanges();
            //    MessageBox.Show("Информация сохранена");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            
        }
    }
}

