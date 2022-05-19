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

namespace RemontV2.Views
{
    public partial class EmployeeCard : UserControl
    {
        public EmployeeCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToEmployeeCard(Сотрудник employee)
        {
            employeepictureBox.ImageLocation = employee.Фото;
            employeeNameLbl.Text = employee.Роль.Наименование + " | " + employee.ФИО;
            genderLbl.Text = "Пол: " + employee.Пол.ToString();
            phoneLbl.Text =  employee.Контактный_телефон.ToString();
            positionLbl.Text = "Должность: " + employee.Должность.ToString();
            emailLbl.Text = "Почта: " + employee.Email.ToString();
           
        }

    }
}
