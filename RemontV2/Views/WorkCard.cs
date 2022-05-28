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
            reqIDLbl.AutoSize = false;
            reqIDLbl.Paint += reqIDLbl_Paint;
        }

        private void reqIDLbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(reqIDLbl.Text, reqIDLbl.Font);
            reqIDLbl.Width = (int)textSize.Height + 2;
            reqIDLbl.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-reqIDLbl.Height / 2, reqIDLbl.Width / 2);
            e.Graphics.DrawString(reqIDLbl.Text, reqIDLbl.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }

        public void GenerateDataToWorkCard(Ремонт work)
        {
            reqIDLbl.Text = work.Заявка.ID_заявки.ToString();
            repairTypeLbl.Text = "Характер ремонта: " + work.Характер_ремонта;
            employeeIDLbl.Text = "Ответственный: " + work.Сотрудник.ФИО;
            serviceNameLbl.Text = "Услуга: " + work.Услуга.Наименование.ToString();
            wkCostLbl.Text = "Стоимость: " + work.Комплектующее.СтоимостьШт.ToString();
            usedAccessoriesLbl.Text = "Использовалось: " + work.Комплектующее.Наименование;
            wkOpenLbl.Text =  work.ДатаНач.ToString();
            wkCloseLbl.Text =  work.ДатаЗаверш.ToString();
            workStatusLbl.Text = "Статус: " + work.СтатусРабот.Наименование.ToString();

        }

    }
}
