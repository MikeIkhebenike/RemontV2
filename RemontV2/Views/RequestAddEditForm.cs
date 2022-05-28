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
    public partial class RequestAddEditForm : Form
    {
        Заявка currentRequest = new Заявка();
        public RequestAddEditForm()
        {
            InitializeComponent();
        }

        private void RequestAddEditForm_Load(object sender, EventArgs e)
        {
            foreach (RequestCard Rcard in RequestsForm.selectedRequestCard)
            {
                currentRequest = DatabaseContext.db.Заявка.First(x => x.Контактный_номер == Rcard.phoneClientLbl.Text);
                заявкаBindingSource.DataSource = currentRequest;
              
            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveChangeEMPBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
