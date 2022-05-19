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

namespace RemontV2.Views
{
    public partial class SuppliersCard : UserControl
    {
        public SuppliersCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToSupplierCard(Поставщик supplier)
        {

            supplierNameLbl.Text = "Компания: "+ supplier.Наименование;
            adresslLbl.Text = "Адрес: " + supplier.Адрес.ToString();

        }
    }
}
