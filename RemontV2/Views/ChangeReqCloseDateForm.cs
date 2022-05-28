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
    public partial class ChangeReqCloseDateForm : Form
    {
        Заявка currentRequest = new Заявка();
        public ChangeReqCloseDateForm()
        {
            InitializeComponent();
            датаЗакрDateTimePicker.Value.ToShortDateString();
        }

        private void ChangeReqCloseDateForm_Load(object sender, EventArgs e)
        {
            датаОткрDateTimePicker.Enabled = false;
            string dateTime = "";
            string dateTime2 = "";
            foreach (RequestCard a in RequestsForm.selectedRequestCard)
            {
                string dateClose = Convert.ToString(a.reqCloseLbl.Text);
                if (dateClose.Length > dateTime.Length)
                {
                    dateTime = dateClose;
                }

                string dateOpen = Convert.ToString(a.reqOpenLbl.Text);
                if (dateOpen.Length > dateTime2.Length)
                {
                    dateTime2 = dateOpen;
                }
                датаОткрDateTimePicker.Text = dateTime2;
                датаЗакрDateTimePicker.Text = dateTime;
            }
        }

        private void saveChangeEMPBtn_Click(object sender, EventArgs e)
        {
            string valueTxtBox = Convert.ToString(датаЗакрDateTimePicker.Text);
            foreach (RequestCard a in RequestsForm.selectedRequestCard)
            {
                Заявка LstReq = DatabaseContext.db.Заявка.First(x => x.Контактный_номер == a.phoneClientLbl.Text);
                LstReq.ДатаЗакр = valueTxtBox;
            }

            try
            {
                DatabaseContext.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
