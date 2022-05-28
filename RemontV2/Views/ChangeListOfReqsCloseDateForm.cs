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
    public partial class ChangeListOfReqsCloseDateForm : Form
    {

        ЗаявкаНаПоставку currentListReq = new ЗаявкаНаПоставку();

        public ChangeListOfReqsCloseDateForm()
        {
            InitializeComponent();
            дата_закрытияDateTimePicker.Value.ToShortDateString();
        }

        private void ChangeListOfReqsCloseDateForm_Load(object sender, EventArgs e)
        {
            
            дата_созданияDateTimePicker.Enabled = false;
            string dateTime = "";
            string dateTime2 = "";
            foreach (ListOfRequestsCard a in ListOfReqsForm.selectedListOfRequestsCard)
            {
                string dateClose = Convert.ToString(a.ListOfReqCloseLbl.Text);
                if (dateClose.Length > dateTime.Length)
                {
                    dateTime = dateClose;
                }

                string dateOpen = Convert.ToString(a.ListOfReqOpenLbl.Text);
                if (dateOpen.Length > dateTime2.Length)
                {
                    dateTime2 = dateOpen;
                }
                дата_созданияDateTimePicker.Text = dateTime2;
                дата_закрытияDateTimePicker.Text = dateTime;
            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueTxtBox = Convert.ToString(дата_закрытияDateTimePicker.Text);
            foreach (ListOfRequestsCard a in ListOfReqsForm.selectedListOfRequestsCard)
            {
                ЗаявкаНаПоставку LstReq = DatabaseContext.db.ЗаявкаНаПоставку.First(x => x.Наименование == a.titleListOfReqLbl.Text);
                LstReq.Дата_закрытия = valueTxtBox;
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
    }
}
