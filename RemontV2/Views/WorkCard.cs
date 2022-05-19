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
    public partial class WorkCard : UserControl
    {
        public WorkCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToWorkCard(Ремонт work)
        {
            reqIDLbl.Text = work.Заявка.ID_заявки.ToString();
            repairTypeLbl.Text = "Характер ремонта: " + work.Характер_ремонта;
            employeeIDLbl.Text = "Ответственный за работу: " + work.Сотрудник.ФИО;
            serviceNameLbl.Text = "Услуга: " + work.Услуга.Наименование.ToString();
            wkCostLbl.Text = "Стоимость: " + work.Комплектующее.СтоимостьШт.ToString();
            usedAccessoriesLbl.Text = "Использовалось: " + work.Комплектующее.Наименование;
            wkOpenLbl.Text = "Количество: " + work.ДатаНач.ToString();
            wkCloseLbl.Text = "Открыта: " + work.ДатаЗаверш.ToString();
            workStatusLbl.Text = "Закрыта: " + work.СтатусРабот.Наименование.ToString();

        }

    }
}
