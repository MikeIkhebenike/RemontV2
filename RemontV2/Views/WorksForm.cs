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
    public partial class WorksForm : Form
    {

        public List<Ремонт> work = new List<Ремонт>(DatabaseContext.db.Ремонт);
        public static List<WorkCard> selectedWorkCard = new List<WorkCard>();

        public WorksForm()
        {
            InitializeComponent();
            GenerateWorkCardList(work);
        }

        private void WorksForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.Ремонт.Select(type => type.СтатусРабот.Наименование).ToList();
            allType.Insert(0, "Все статусы");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }

        private void GenerateWorkCardList(List<Ремонт> work)
        {
            foreach (var a in work)
            {
                WorkCard Wcard = new WorkCard();
                Wcard.GenerateDataToWorkCard(a);
                WorksflowLayoutPanel.Controls.Add(Wcard);

                Wcard.Click += new System.EventHandler(this.Card_Click);
                Wcard.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            WorkCard Wcard = sender as WorkCard;
            selectedWorkCard.Add(Wcard);
            WorkAddEditForm RQedit = new WorkAddEditForm();
            DialogResult dialogResult = RQedit.ShowDialog();
            SortListView();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            WorkCard Wcard = sender as WorkCard;

            if (Wcard.BackColor == Color.White)
            {
                Wcard.BackColor = Color.FromArgb(177, 117, 238);
                selectedWorkCard.Add(Wcard);
            }
            else
            {
                Wcard.BackColor = Color.White;
                selectedWorkCard.Remove(Wcard);
            }
            if (selectedWorkCard.Count >= 1)
            {
                RemoveWorkBtn.Visible = true;
                ChangeStatusBtn.Visible = true;
            }
            else
            {
                RemoveWorkBtn.Visible = false;
                ChangeStatusBtn.Visible = false;
            }
        }

        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Ремонт.ToList();
            // Filter
            if (filterComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.СтатусРабот.Наименование == filterComboBox.SelectedItem
                    .ToString())
                    .ToList();
            }

            // Search
            if (searchTextBox.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.Сотрудник.ФИО.ToLower()
                    .Contains(searchTextBox.Text
                    .ToLower()) || Convert.ToString(x.ID_заявки)
                    .Contains(searchTextBox.Text) || x.Характер_ремонта.ToLower()
                    .Contains(searchTextBox.Text.ToLower()) ||x.Комплектующее.Наименование.ToLower()
                    .Contains(searchTextBox.Text)).ToList();
            }

            // Sort
            if (sortComboBox.Text == "Ответственный за работу")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Сотрудник.ФИО).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Сотрудник.ФИО).ToList();
                }
            }
            if (sortComboBox.Text == "Характер ремонта")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Характер_ремонта).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Характер_ремонта).ToList();
                }
            }
            if (sortComboBox.Text == "Дата начала")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ДатаНач).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ДатаНач).ToList();
                }
            }
            WorksflowLayoutPanel.Controls.Clear();
            GenerateWorkCardList(listUpdate);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            WorksflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorksflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WorksflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorksflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void AddWorkBtn_Click(object sender, EventArgs e)
        {
            WorkAddEditForm WrkAedit = new WorkAddEditForm();
            DialogResult dialogResult = WrkAedit.ShowDialog();
        }

        private void ChangeStatusBtn_Click(object sender, EventArgs e)
        {

        }

        private void RemoveWorkBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
