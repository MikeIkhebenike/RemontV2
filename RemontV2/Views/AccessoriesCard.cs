using RemontV2.Models;
using System.Drawing;
using System.Windows.Forms;
using RemontV2.Utils;

namespace RemontV2.Views
{
    public partial class AccessoriesCard : UserControl
    {
        public AccessoriesCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToAccessoriesCard(Комплектующее accessories)
        {
            label1.Text = accessories.Наименование;
            pictureBox1.ImageLocation = accessories.Изображение;
            supplierNameLbl.Text = accessories.Поставщик.Наименование + " | " + accessories.Наименование;
            qtyStockLbl.Text =  accessories.КоличествоВналич.ToString() + " в наличии";
            CostLbl.Text = accessories.СтоимостьШт.ToString();
            label2.Text = " руб.";



            if (qtyStockLbl.Text == ""| qtyStockLbl.Text == "0")
            {
                supplierNameLbl.BackColor = Color.DarkRed;
            }
        }

        private void AccessoriesCard_Load(object sender, System.EventArgs e)
        {

        }
    }
}
