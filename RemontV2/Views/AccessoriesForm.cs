using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemontV2.Utils;
using RemontV2.Models;

namespace RemontV2.Views
{
    public partial class AccessoriesForm : Form
    {
        public List<Комплектующее> accessoriesC = new List<Комплектующее>(DatabaseContext.db.Комплектующее);
        public static List<AccessoriesCard> selectedAccessoriesCard = new List<AccessoriesCard>();
        public AccessoriesForm()
        {
            InitializeComponent();
            GenerateAccessoriesCardList(accessoriesC);
        }

        private void AccessoriesForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.Поставщик.Select(type => type.Наименование).ToList();
            allType.Insert(0, "Все поставщики");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }

        private void GenerateAccessoriesCardList(List<Комплектующее> accessoriesC)
        {
            foreach (var a in accessoriesC)
            {
                AccessoriesCard Acard = new AccessoriesCard();
                Acard.GenerateDataToAccessoriesCard(a);
                AccessoriesflowLayoutPanel.Controls.Add(Acard);

                Acard.Click += new System.EventHandler(this.Card_Click);
                Acard.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }


        private void Card_DoubleClick(object sender, EventArgs e)
        {
            AccessoriesCard Acard = sender as AccessoriesCard;
            selectedAccessoriesCard.Add(Acard);
            AccessoriesAddEditForm AccessoriesAEFrm = new AccessoriesAddEditForm();
            DialogResult dialogResult = AccessoriesAEFrm.ShowDialog();
            SortListView();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            AccessoriesCard Acard = sender as AccessoriesCard;

            if (Acard.BackColor == Color.White)
            {
                Acard.BackColor = Color.FromArgb(177, 117, 238);
                selectedAccessoriesCard.Add(Acard);
            }
            else
            {
                Acard.BackColor = Color.White;
                selectedAccessoriesCard.Remove(Acard);
            }
            if (selectedAccessoriesCard.Count >= 1)
            {
                ChangePriceBtn.Visible = true;
                DeleteAccBtn.Visible = true;
            }
            else
            {
                ChangePriceBtn.Visible = false;
                DeleteAccBtn.Visible = false;
            }

          
        }

        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Комплектующее.ToList();
            // Filter
            if (filterComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.Поставщик.Наименование == filterComboBox.SelectedItem
                    .ToString())
                    .ToList();
            }

            // Search
            if (searchTextBox.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.Наименование.ToLower()
                    .Contains(searchTextBox.Text
                    .ToLower()) || x.Поставщик.Наименование
                    .Contains(searchTextBox.Text)).ToList();
            }

            // Sort
            if (sortComboBox.Text == "Стоимость")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.СтоимостьШт).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.СтоимостьШт).ToList();
                }
            }
            if (sortComboBox.Text == "Наименование")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Наименование).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Наименование).ToList();
                }
            }
            AccessoriesflowLayoutPanel.Controls.Clear();
            GenerateAccessoriesCardList(listUpdate);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           AccessoriesflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessoriesflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AccessoriesflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessoriesflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void ChangePriceBtn_Click(object sender, EventArgs e)
        {
            ChangePriceForm NewPrice = new ChangePriceForm();
            DialogResult dialogResult = NewPrice.ShowDialog();
            SortListView();
        }

        private void AddAccessoriesBtn_Click(object sender, EventArgs e)
        {
            AccessoriesAddEditForm AccessoriesAEFrm = new AccessoriesAddEditForm();
            DialogResult dialogResult = AccessoriesAEFrm.ShowDialog();
        }

        private void DeleteAccBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
