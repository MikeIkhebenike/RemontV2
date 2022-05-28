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
    public partial class ChangePriceForm : Form
    {
        Комплектующее currentAccessories = new Комплектующее();
        public ChangePriceForm()
        {
            InitializeComponent();
        }

        private void ChangePriceForm_Load(object sender, EventArgs e)
        {
            foreach (AccessoriesCard a in AccessoriesForm.selectedAccessoriesCard)
            {
                currentAccessories = DatabaseContext.db.Комплектующее.First(x => x.Наименование == a.label1.Text);
                изображениеPictureBox.ImageLocation = currentAccessories.Изображение;
                наименованиеTextBox.Text = currentAccessories.Наименование;
            }
        }

        private void ShutDownEMPBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAccessoriesCostBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentAccessories.СтоимостьШт))
            {
                errors.AppendLine("Укажите стоимость комплектующего");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (currentAccessories.ID_комплектующего == 0)
            {
                DatabaseContext.db.Комплектующее.Add(currentAccessories);
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
