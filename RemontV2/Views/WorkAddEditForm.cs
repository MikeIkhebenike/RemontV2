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
    public partial class WorkAddEditForm : Form
    {
        Ремонт currentWork = new Ремонт();
        public WorkAddEditForm()
        {
            InitializeComponent();
        }

        private void WorkAddEditForm_Load(object sender, EventArgs e)
        {
            комплектующееBindingSource.DataSource = DatabaseContext.db.Комплектующее.ToList();
            заявкаBindingSource.DataSource = DatabaseContext.db.Заявка.ToList();
            сотрудникBindingSource.DataSource = DatabaseContext.db.Сотрудник.ToList();
            статусРаботBindingSource.DataSource = DatabaseContext.db.СтатусРабот.ToList();
            услугаBindingSource.DataSource = DatabaseContext.db.Услуга.ToList();
            
            foreach (WorkCard Wcard in WorksForm.selectedWorkCard)
            {
                currentWork = DatabaseContext.db.Ремонт.First(x => x.ДатаНач == Wcard.wkOpenLbl.Text);
                ремонтBindingSource.DataSource = currentWork;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SaveWorkBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteWorkBtn_Click(object sender, EventArgs e)
        {

        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
