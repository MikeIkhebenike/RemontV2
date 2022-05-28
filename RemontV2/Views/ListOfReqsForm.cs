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
    public partial class ListOfReqsForm : Form
    {

        public List<ЗаявкаНаПоставку> reqOnSupp = new List<ЗаявкаНаПоставку>(DatabaseContext.db.ЗаявкаНаПоставку);
        public static List<ListOfRequestsCard> selectedListOfRequestsCard = new List<ListOfRequestsCard>();

        public ListOfReqsForm()
        {
            InitializeComponent();
            GenerateListOfRequestsCardList(reqOnSupp);
        }

        private void ListOfReqsForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.ЗаявкаНаПоставку.Select(type => type.Поставщик.Наименование).ToList();
            allType.Insert(0, "Все поставщики");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }

        private void GenerateListOfRequestsCardList(List<ЗаявкаНаПоставку> reqOnSupp)
        {
            foreach (var a in reqOnSupp)
            {
                ListOfRequestsCard LstReqcard = new ListOfRequestsCard();
                LstReqcard.GenerateDataToListOfReqCard(a);
                ListOfReqsflowLayoutPanel.Controls.Add(LstReqcard);

                LstReqcard.Click += new System.EventHandler(this.Card_Click);
                LstReqcard.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            ListOfRequestsCard LstReqcard = sender as ListOfRequestsCard;
            selectedListOfRequestsCard.Add(LstReqcard);
            ListOfReqsAddEditForm LstRQedit = new ListOfReqsAddEditForm();
            DialogResult dialogResult = LstRQedit.ShowDialog();
            SortListView();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            ListOfRequestsCard LstReqcard = sender as ListOfRequestsCard;

            if (LstReqcard.BackColor == Color.White)
            {
                LstReqcard.BackColor = Color.FromArgb(177, 117, 238);
                selectedListOfRequestsCard.Add(LstReqcard);
            }
            else
            {
                LstReqcard.BackColor = Color.White;
                selectedListOfRequestsCard.Remove(LstReqcard);
            }
            if (selectedListOfRequestsCard.Count >= 1)
            {
                RemoveListOfReqBtn.Visible = true;
                ChangeCloseDateBtn.Visible = true;
            }
            else
            {
                RemoveListOfReqBtn.Visible = false;
                ChangeCloseDateBtn.Visible = false;
            }
        }

        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.ЗаявкаНаПоставку.ToList();
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
                    .ToLower()) || Convert.ToString(x.ID_заявНаПост)
                    .Contains(searchTextBox.Text) || x.Сотрудник.ФИО.ToLower()
                    .Contains(searchTextBox.Text.ToLower())).ToList();
            }

            // Sort
            if (sortComboBox.Text == "ID")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ID_заявНаПост).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ID_заявНаПост).ToList();
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
            if (sortComboBox.Text == "Дата создания")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Дата_создания).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Дата_создания).ToList();
                }
            }
            if (sortComboBox.Text == "Дата закрытия")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Дата_закрытия).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Дата_закрытия).ToList();
                }
            }
            ListOfReqsflowLayoutPanel.Controls.Clear();
            GenerateListOfRequestsCardList(listUpdate);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ListOfReqsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOfReqsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ListOfReqsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOfReqsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void AddListOfReqBtn_Click(object sender, EventArgs e)
        {
            ListOfReqsAddEditForm LstRQedit = new ListOfReqsAddEditForm();
            DialogResult dialogResult = LstRQedit.ShowDialog();
        }

        private void ChangeCloseDateBtn_Click(object sender, EventArgs e)
        {
            ChangeListOfReqsCloseDateForm CngLstRQedit = new ChangeListOfReqsCloseDateForm();
            DialogResult dialogResult = CngLstRQedit.ShowDialog();
            SortListView();
        }

        private void RemoveListOfReqBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
