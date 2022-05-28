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
    public partial class ListOfReqsAddEditForm : Form
    {

        ЗаявкаНаПоставку currentListReq = new ЗаявкаНаПоставку();

        public ListOfReqsAddEditForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void ListOfReqsAddEditForm_Load(object sender, EventArgs e)
        {
            сотрудникBindingSource.DataSource = DatabaseContext.db.Сотрудник.ToList();
            поставщикBindingSource.DataSource = DatabaseContext.db.Поставщик.ToList();

            foreach (ListOfRequestsCard LReqcard in ListOfReqsForm.selectedListOfRequestsCard)
            {
                
                currentListReq = DatabaseContext.db.ЗаявкаНаПоставку.First(x =>  x.Наименование == LReqcard.titleListOfReqLbl.Text);
                заявкаНаПоставкуBindingSource.DataSource = currentListReq;


            }
        }

        

        private void SaveListReqBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentListReq.Наименование))
            {
                errors.AppendLine("Укажите наименование поставки");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(currentListReq.ID_поставщика)))
            {
                errors.AppendLine("Укажите наименование поставщика");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(currentListReq.ID_сотрудника)))
            {
                errors.AppendLine("Укажите сотрудника, обрабатывающего заявку");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (currentListReq.ID_заявНаПост == 0)
            {
                DatabaseContext.db.ЗаявкаНаПоставку.Add(currentListReq);
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

        private void DeleteListReqBtn_Click(object sender, EventArgs e)
        {

        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
