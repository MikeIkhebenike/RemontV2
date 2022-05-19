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
    public partial class SuppliersForm : Form
    {
        public List<Поставщик> supplier = new List<Поставщик>(DatabaseContext.db.Поставщик);
        public static List<SuppliersCard> selectedSupplierCard = new List<SuppliersCard>();
        public SuppliersForm()
        {
            InitializeComponent();
            GenerateSuppliersCardList(supplier);
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.Поставщик.Select(type => type.Адрес).ToList();
            allType.Insert(0, "Все города");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }

        private void GenerateSuppliersCardList(List<Поставщик> supplier)
        {
            foreach (var a in supplier)
            {
                SuppliersCard Scard = new SuppliersCard();
                Scard.GenerateDataToSupplierCard(a);
                SupplierflowLayoutPanel.Controls.Add(Scard);

                Scard.Click += new System.EventHandler(this.Card_Click);
                Scard.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            SuppliersCard Scard = sender as SuppliersCard;
            selectedSupplierCard.Add(Scard);
            SupplierAddEdit SPedit = new SupplierAddEdit();
            DialogResult dialogResult = SPedit.ShowDialog();
            SortListView();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            SuppliersCard Scard = sender as SuppliersCard;

            if (Scard.BackColor == Color.White)
            {
                Scard.BackColor = Color.FromArgb(177, 117, 238);
                selectedSupplierCard.Add(Scard);
            }
            else
            {
                Scard.BackColor = Color.White;
                selectedSupplierCard.Remove(Scard);
            }
            if (selectedSupplierCard.Count > 1)
            {
                RemoveSupplierBtn.Visible = true;
            }
            else
            {
                RemoveSupplierBtn.Visible = false;
            }
        }


        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Поставщик.ToList();
            // Filter
            if (filterComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.Адрес == filterComboBox.SelectedItem
                    .ToString())
                    .ToList();
            }

            // Search
            if (searchTextBox.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.Наименование.ToLower()
                    .Contains(searchTextBox.Text
                    .ToLower()) || x.Адрес
                    .Contains(searchTextBox.Text)).ToList();
            }

            // Sort
            if (sortComboBox.Text == "ID")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ID_поставщика).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ID_поставщика).ToList();
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
            SupplierflowLayoutPanel.Controls.Clear();
            GenerateSuppliersCardList(listUpdate);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SupplierflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SupplierflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            SupplierAddEdit suppAE = new SupplierAddEdit();
            DialogResult dialogResult = suppAE.ShowDialog();
            SortListView();
        }

        private void RemoveSupplierBtn_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Вы действительно хотите удалить поставщика - " + Поставщик.На,
            //    "Удаление продукции", MessageBoxButtons.YesNo);
        }
    }
}
