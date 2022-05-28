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
    public partial class RequestAddEditForm : Form
    {
        Заявка currentRequest = new Заявка();
        public RequestAddEditForm()
        {
            InitializeComponent();
        }

        private void RequestAddEditForm_Load(object sender, EventArgs e)
        {
            foreach (RequestCard Rcard in RequestsForm.selectedRequestCard)
            {
                currentRequest = DatabaseContext.db.Заявка.First(x => x.Контактный_номер == Rcard.phoneClientLbl.Text);
                заявкаBindingSource.DataSource = currentRequest;
              
            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveChangeEMPBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentRequest.Описание_проблемы))
            {
                errors.AppendLine("Укажите описание проблемы");
            }
            if (string.IsNullOrWhiteSpace(currentRequest.Контактный_номер))
            {
                errors.AppendLine("Укажите телефон клиента");
            }
            if (string.IsNullOrWhiteSpace(currentRequest.Адрес_клиента))
            {
                errors.AppendLine("Укажите адрес клиента");
            }
            if (string.IsNullOrWhiteSpace(currentRequest.ФИО_клиента))
            {
                errors.AppendLine("Укажите имя клиента");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (currentRequest.ID_заявки == 0)
            {
                DatabaseContext.db.Заявка.Add(currentRequest);
            }
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //this.Close();
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveReqstBtn_Click(object sender, EventArgs e)
        {
            currentRequest.ФИО_клиента = фИО_клиентаTextBox.Text;
            currentRequest.Контактный_номер = контактный_номерTextBox.Text;
            currentRequest.Адрес_клиента = адрес_клиентаTextBox.Text;
            currentRequest.Количество = Convert.ToInt32(количествоTextBox.Text);
            currentRequest.Описание_проблемы = описание_проблемыTextBox.Text;
            currentRequest.Техника_клиента = техника_клиентаTextBox.Text;
            currentRequest.ДатаОткр = датаОткрDateTimePicker.Text;
            currentRequest.ДатаЗакр = датаЗакрDateTimePicker.Text;
            
            DatabaseContext.db.Заявка.Add(currentRequest);
            
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

             this.Close();

            }
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
