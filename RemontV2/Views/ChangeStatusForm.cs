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
    public partial class ChangeStatusForm : Form
    {
        Ремонт currentWork = new Ремонт();
        public ChangeStatusForm()
        {
            InitializeComponent();
        }

        private void ChangeStatusForm_Load(object sender, EventArgs e)
        {
            статусРаботBindingSource.DataSource = DatabaseContext.db.СтатусРабот.ToList();
            foreach (WorkCard a in WorksForm.selectedWorkCard)
            {
                currentWork = DatabaseContext.db.Ремонт.First(x => x.ДатаНач == a.wkOpenLbl.Text);
                ремонтBindingSource.DataSource = currentWork;
            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void saveChangeEMPBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentWork.СтатусРабот.Наименование))
            {
                errors.AppendLine("Укажите статус работы");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (currentWork.ID_работы == 0)
            {
                DatabaseContext.db.Ремонт.Add(currentWork);
            }
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }

        
    }
}
