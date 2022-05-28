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
        Авторизация currentAuth = new Авторизация();
        public EMPAddEditForm()
        {
            InitializeComponent();
        }
         private void groupBox1_Enter_1(object sender, EventArgs e)
         {

         }

        private void EMPAddEditForm_Load(object sender, EventArgs e)
        {
            
            roleBindingSource.DataSource = DatabaseContext.db.Роль.ToList();
            foreach (EmployeeCard ecard in EmployeeForm.selectedEmployeeCard)
            {
                currentEmployee = DatabaseContext.db.Сотрудник.First(x => x.Контактный_телефон == ecard.phoneLbl.Text);
                employeeBindingSource.DataSource = currentEmployee;
                photoPictureBox.ImageLocation = currentEmployee.Фото;
                if (currentEmployee.ID_сотрудника == 0)
                {
                    saveChangeEMPBtn.Visible = false;
                }
                else
                {
                    логинTextBox.Enabled = false;
                    авторизацияBindingSource.DataSource = DatabaseContext.db.Авторизация.ToList();
                    SaveChangeEMP2.Visible = false;
                }
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
                errors.AppendLine("Укажите Фамилию Имя и Отчество сотрудника через пробел");
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

        private void SaveChangeEMP2_Click(object sender, EventArgs e)
        {
            currentEmployee.ФИО = fioTextBox.Text;
            currentEmployee.ID_роли = roleEMPcomboBox.SelectedIndex+1;
            currentEmployee.Должность = placeTextBox.Text;
            currentEmployee.Контактный_телефон = phoneTextBox.Text;
            currentEmployee.Пол = полComboBox.Text;
            currentEmployee.Фото = pictureBox1.ImageLocation;
            currentEmployee.Email = emailTextBox.Text;
            //currentAuth.Логин = логинTextBox.Text;
            //currentAuth.Пароль = парольTextBox.Text;
            DatabaseContext.db.Сотрудник.Add(currentEmployee);
            //DatabaseContext.db.Авторизация.Add(currentAuth);
            try
            {

                DatabaseContext.db.SaveChanges();

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

