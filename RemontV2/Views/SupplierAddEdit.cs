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
    public partial class SupplierAddEdit : Form
    {
        Поставщик currentSupplier = new Поставщик();
        public SupplierAddEdit()
        {
            InitializeComponent();
        }
 
        private void SupplierAddEdit_Load(object sender, EventArgs e)
        {
            
            foreach (SuppliersCard Scard in SuppliersForm.selectedSupplierCard)
            {

                currentSupplier = DatabaseContext.db.Поставщик.First(x => x.Наименование == Scard.supplierNameLbl.Text);
                поставщикBindingSource.DataSource = currentSupplier;

            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSupplierBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSupplierBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
