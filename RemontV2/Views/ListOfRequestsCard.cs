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
    public partial class ListOfRequestsCard : UserControl
    {
        public ListOfRequestsCard()
        {
            InitializeComponent();
            ListOfReqIDLbl.AutoSize = false;
            ListOfReqIDLbl.Paint += ListOfReqIDLbl_Paint;
        }

        private void ListOfReqIDLbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(ListOfReqIDLbl.Text, ListOfReqIDLbl.Font);
            ListOfReqIDLbl.Width = (int)textSize.Height + 2;
            ListOfReqIDLbl.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-ListOfReqIDLbl.Height / 2, ListOfReqIDLbl.Width / 2);
            e.Graphics.DrawString(ListOfReqIDLbl.Text, ListOfReqIDLbl.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }

        public void GenerateDataToListOfReqCard(ЗаявкаНаПоставку ReqOnSupp)
        {

            ListOfReqIDLbl.Text = ReqOnSupp.ID_заявНаПост.ToString();
            titleListOfReqLbl.Text = ReqOnSupp.Наименование;
            qtyListOfReqLbl.Text ="Количество: "+ ReqOnSupp.Количество.ToString();
            employeeListOfReqIDLbl.Text = "Ответственный: " + ReqOnSupp.Сотрудник.ФИО;
            supplierListOfReqLbl.Text = "Поставщик: " + ReqOnSupp.Поставщик.Наименование.ToString();
            ListOfReqOpenLbl.Text =  ReqOnSupp.Дата_создания.ToString();
            ListOfReqCloseLbl.Text =  ReqOnSupp.Дата_закрытия.ToString();

        }

    }
}
