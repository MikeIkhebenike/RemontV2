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
            employeepictureBox.ImageLocation = Сотрудник.Фото;
            employeeNameLbl.Text = Сотрудник.Роль.Наименование + " | " + Сотрудник.ФИО;
            genderLbl.Text = Сотрудник.Пол.ToString();
            phoneLbl.Text = Сотрудник.Контактный_телефон.ToString();
            positionLbl.Text = Сотрудник.Должность.ToString();
            emailLbl.Text = Сотрудник.Email.ToString();
           
        }

    }
}
