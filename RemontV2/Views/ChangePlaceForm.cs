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
    public partial class ChangePlaceForm : Form
    {
        Сотрудник currentEmployee = new Сотрудник();
        public ChangePlaceForm()
        {
            InitializeComponent();
        }

        private void ChangePlaceForm_Load(object sender, EventArgs e)
        {
            foreach (EmployeeCard a in EmployeeForm.selectedEmployeeCard)
            {
                currentEmployee = DatabaseContext.db.Сотрудник.First(x => x.Контактный_телефон == a.phoneLbl.Text);
                сотрудникBindingSource.DataSource = currentEmployee;
                фИОTextBox.Text = currentEmployee.ФИО;
                рольTextBox.Text = currentEmployee.Роль.Наименование;
            }
            
        }

        private void SavePlaceBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentEmployee.Должность))
            {
                errors.AppendLine("Укажите должность сотрудника");
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

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
