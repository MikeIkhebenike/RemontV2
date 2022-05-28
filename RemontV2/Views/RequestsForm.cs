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
    public partial class RequestsForm : Form
    {

        public List<Заявка> request = new List<Заявка>(DatabaseContext.db.Заявка);
        public static List<RequestCard> selectedRequestCard = new List<RequestCard>();

        public RequestsForm()
        {
            InitializeComponent();
            GenerateRequestsCardList(request);
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.Заявка.Select(type => type.Описание_проблемы).ToList();
            allType.Insert(0, "Все типы проблем");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }

        private void GenerateRequestsCardList(List<Заявка> request)
        {
            foreach (var a in request)
            {
                RequestCard Rcard = new RequestCard();
                Rcard.GenerateDataToRequestCard(a);
                RequestsflowLayoutPanel.Controls.Add(Rcard);

                Rcard.Click += new System.EventHandler(this.Card_Click);
                Rcard.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            RequestCard Rcard = sender as RequestCard;
            selectedRequestCard.Add(Rcard);
            RequestAddEditForm RQedit = new RequestAddEditForm();
            DialogResult dialogResult = RQedit.ShowDialog();
            SortListView();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            RequestCard Scard = sender as RequestCard;

            if (Scard.BackColor == Color.White)
            {
                Scard.BackColor = Color.FromArgb(177, 117, 238);
                selectedRequestCard.Add(Scard);
            }
            else
            {
                Scard.BackColor = Color.White;
                selectedRequestCard.Remove(Scard);
            }
            if (selectedRequestCard.Count >= 1)
            {
                RemoveRequestBtn.Visible = true;
                ChangeCloseDateBtn.Visible = true;
            }
            else
            {
                RemoveRequestBtn.Visible = false;
                ChangeCloseDateBtn.Visible= false;
            }
        }

        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Заявка.ToList();
            // Filter
            if (filterComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.Описание_проблемы == filterComboBox.SelectedItem
                    .ToString())
                    .ToList();
            }

            // Search
            if (searchTextBox.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.Описание_проблемы.ToLower()
                    .Contains(searchTextBox.Text
                    .ToLower()) || Convert.ToString(x.ID_заявки)
                    .Contains(searchTextBox.Text) || x.Техника_клиента.ToLower()
                    .Contains(searchTextBox.Text.ToLower())).ToList();
            }

            // Sort
            if (sortComboBox.Text == "Дата открытия")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ДатаОткр).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ДатаОткр).ToList();
                }
            }
            if (sortComboBox.Text == "Дата закрытия")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ДатаЗакр).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ДатаЗакр).ToList();
                }
            }
            RequestsflowLayoutPanel.Controls.Clear();
            GenerateRequestsCardList(listUpdate);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            RequestsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RequestsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestsflowLayoutPanel.Controls.Clear();
            SortListView();
        }

        private void AddRequestBtn_Click(object sender, EventArgs e)
        {
            RequestAddEditForm ReqAedit = new RequestAddEditForm();
            DialogResult dialogResult = ReqAedit.ShowDialog();
        }

        private void RemoveRequestBtn_Click(object sender, EventArgs e)
        {

        }

        private void ChangeCloseDateBtn_Click(object sender, EventArgs e)
        {
            ChangeReqCloseDateForm NewCloseDate = new ChangeReqCloseDateForm();
            DialogResult dialogResult = NewCloseDate.ShowDialog();
            SortListView();
        }


    }
}
