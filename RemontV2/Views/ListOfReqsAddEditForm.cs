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
                this.Close();
                currentListReq = null;
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
            
        }

        private void DeleteListReqBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext.db.ЗаявкаНаПоставку.Remove(currentListReq);
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация удалена");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (System.Data.Entity.Validation.DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                    MessageBox.Show(" ");
                    foreach (System.Data.Entity.Validation.DbValidationError err in validationError.ValidationErrors)
                    {
                        MessageBox.Show(err.ErrorMessage + " ");
                    }
                }
                this.Close();

            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveLstReq2_Click(object sender, EventArgs e)
        {
            currentListReq.Наименование = наименованиеTextBox.Text;
            currentListReq.Количество = Convert.ToInt32(количествоTextBox.Text);
            currentListReq.Дата_создания = дата_созданияDateTimePicker.Text;
            currentListReq.Дата_закрытия = дата_закрытияDateTimePicker.Text;
            currentListReq.ID_поставщика = iD_поставщикаComboBox.SelectedIndex + 1;
            currentListReq.ID_сотрудника = iD_сотрудникаComboBox.SelectedIndex + 1;

            DatabaseContext.db.ЗаявкаНаПоставку.Add(currentListReq);
            try
            {

                DatabaseContext.db.SaveChanges();
                this.Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (System.Data.Entity.Validation.DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                    MessageBox.Show(" ");
                    foreach (System.Data.Entity.Validation.DbValidationError err in validationError.ValidationErrors)
                    {
                        MessageBox.Show(err.ErrorMessage + " ");
                    }
                }


            }
        }
    }
}
