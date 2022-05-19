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
using RemontV2.Views;

namespace RemontV2.Views
{
    public partial class EmployeeForm : Form
    {
        public List<Сотрудник> employee = new List<Сотрудник>(DatabaseContext.db.Сотрудник);
        public static List<EmployeeCard> selectedEmployeeCard = new List<EmployeeCard>();
        public EmployeeForm()
        {
            InitializeComponent();
            GenerateEmployeeCardList(employee);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.Роль.Select(type => type.Наименование).ToList();
            allType.Insert(0, "Все роли");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }
        private void GenerateEmployeeCardList(List<Сотрудник> employee)
        {
            foreach (var a in employee)
            {
                EmployeeCard card = new EmployeeCard();
                card.GenerateDataToEmployeeCard(a);
                flowLayoutPanel1.Controls.Add(card);

                card.Click += new System.EventHandler(this.Card_Click);
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }


        private void Card_DoubleClick(object sender, EventArgs e)
        {
            EmployeeCard card = sender as EmployeeCard;
            selectedEmployeeCard.Add(card);
            //AddEditForm editForm = new AddEditForm();
            //DialogResult dialogResult = editForm.ShowDialog();
            //SortListView();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            EmployeeCard card = sender as EmployeeCard;

            if (card.BackColor == Color.White)
            {
                card.BackColor = Color.FromArgb(177, 117, 238);
                selectedEmployeeCard.Add(card);
            }
            else
            {
                card.BackColor = Color.White;
                selectedEmployeeCard.Remove(card);
            }
            if (selectedEmployeeCard.Count > 1)
            {
                changePriorityBtn.Visible = true;
            }
            else
            {
                changePriorityBtn.Visible = false;
            }
        }

        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Сотрудник.ToList();
            // Filter
            if (filterComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.Роль.Наименование == filterComboBox.SelectedItem
                    .ToString())
                    .ToList();
            }

            // Search
            if (searchTextBox.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.ФИО.ToLower()
                    .Contains(searchTextBox.Text
                    .ToLower()) || x.Контактный_телефон
                    .Contains(searchTextBox.Text) || x.Email.ToLower()
                    .Contains(searchTextBox.Text.ToLower())).ToList();
            }

            // Sort
            if (sortComboBox.Text == "ФИО")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ФИО).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ФИО).ToList();
                }
            }
            if (sortComboBox.Text == "Роль")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Роль.Наименование).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Роль.Наименование).ToList();
                }
            }
            flowLayoutPanel1.Controls.Clear();
            GenerateEmployeeCardList(listUpdate);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            //ChangePriorityForm changePriorityForm = new ChangePriorityForm();
            //    DialogResult dialogResult = changePriorityForm.ShowDialog();
            //    SortListView();
        }



        //private void changePriorityBtn_Click(object sender, EventArgs e)
        //{
        //    ChangePriorityForm changePriorityForm = new ChangePriorityForm();
        //    DialogResult dialogResult = changePriorityForm.ShowDialog();
        //    SortListView();
        //}
    }


}

