using RemontV2.Models;
using System.Drawing;
using System.Windows.Forms;

namespace RemontV2.Views
{
    public partial class AccessoriesCard : UserControl
    {
        public AccessoriesCard()
        {
            InitializeComponent();
        }

        //public void GenerateDataToAccessoriesCard(Комплектующее accessories)
        //{
        //    pictureBox1.ImageLocation = Комплектующее.Изображение;
        //    supplierNameLbl.Text = Комплектующее.Поставщик.Наименование + " | " + Комплектующее.Наименование;
        //    qtyStockLbl.Text = Комплектующее.КоличествоВналич.ToString();
        //    CostLbl.Text = Комплектующее.Стоимость.ToString();

        //    if (qtyStockLbl.Text == "")
        //    {
        //        supplierNameLbl.BackColor = Color.DarkRed;
        //    }
        //}

    }
}
