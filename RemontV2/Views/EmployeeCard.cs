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
using RemontV2.Views;
using RemontV2.Utils;

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
            genderLbl.Text = employee.Пол.ToString();
            phoneLbl.Text = employee.Контактный_телефон.ToString();
            positionLbl.Text = employee.Должность.ToString();
            emailLbl.Text = employee.Email.ToString();
           
        }

    }
}
