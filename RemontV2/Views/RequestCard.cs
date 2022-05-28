using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemontV2.Utils;
using RemontV2.Models;

namespace RemontV2.Views
{
    public partial class RequestCard : UserControl
    {
        public RequestCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToRequestCard(Заявка request)
        {
            reqNumberLbl.Text = request.ID_заявки.ToString();
            FioLbl.Text ="ФИО: "+ request.ФИО_клиента;
            ReqAdresslLbl.Text ="Адрес: "+ request.Адрес_клиента;
            phoneClientLbl.Text =  request.Контактный_номер.ToString();
            ClientTechLbl.Text ="Техника: "+ request.Техника_клиента.ToString();
            ReqDescriptionLbl.Text = "Проблема: " + request.Описание_проблемы;
            techqtyLbl.Text = "Количество: " + request.Количество.ToString();
            reqOpenLbl.Text = request.ДатаОткр.ToString();
            reqCloseLbl.Text = request.ДатаЗакр.ToString();
                
        }

    }
}
