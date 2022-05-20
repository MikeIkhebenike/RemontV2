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
            FiltrCombo.DataSource = allType;
            FiltrCombo.SelectedIndex = 0;
            SortCombo.SelectedIndex = 0;
            // устанавливаем тип сортировки - "Без сортировка"
            
            // загружаем список ФИО 
            List<string> lstTypes = DatabaseContext.db.Сотрудник.Select(a => a.Пол).ToList();
            lstTypes.Insert(0, "Любой пол");
            // передаем данные фильтру
            FiltrCombo.DataSource = lstTypes;

            employeeBindingSource.DataSource = DatabaseContext.db.Сотрудник.ToList();
            roleBindingSource.DataSource = DatabaseContext.db.Роль.ToList();
            authorizeBindingSource.DataSource = DatabaseContext.db.Авторизация.ToList();

            // подготавливаем данные для показа
            PodgotovkaData();
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
            if (FiltrCombo.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.Роль.Наименование == FiltrCombo.SelectedItem
                    .ToString())
                    .ToList();
            }

            // Search
            if (SearchTxt.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(SearchTxt.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.ФИО.ToLower()
                    .Contains(SearchTxt.Text
                    .ToLower()) || x.Контактный_телефон
                    .Contains(SearchTxt.Text) || x.Email.ToLower()
                    .Contains(SearchTxt.Text.ToLower())).ToList();
            }

            // Sort
            if (SortCombo.Text == "ФИО")
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
            if (SortCombo.Text == "Роль")
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

        string filtr = "Любой пол"; // фильтр показа продукции;
        string sort = "ФИО"; // сортировки продукции
        string sortDirection = "возрастание"; // направление сортировки
        string search = "";  // поиск по наименованию и описанию

        ////////////////////////////////////////////////////////
        //  Подготовка данных для показа 
        //  выполнение фильтрации, поиска и сортировки
        public void PodgotovkaData()
        {
            // вначале выбираем все товары
            employee = DatabaseContext.db.Сотрудник.ToList();

            /////////////////////////////////////////////            
            // фильтрация по типам товаров
            if (filtr != "Любой пол")
            {
                // отбираем только по заданному производителю
                employee = employee.Where(p => (p.Пол == filtr)).ToList();
            }
            /////////////////////////////////////////////
            // поиск по заданной строке
            if (search != "")
            {   // отбираем товары с заданной строкой в названии
                search = search.ToUpper();
                // поиск с учетом регистра
                // ToUpper() для пустой строки не срабатывает
                employee = employee
                    .Where(p => (p.Пол.ToUpper().Contains(search)) ||
                        (p.Должность != null && // есть описание ?
                         p.Должность.ToUpper().Contains(search)))
                    .ToList();
            }
            /////////////////////////////////////////////
            // сортировка по разным полям
            if (sort != "Без сортировки")
            {
                if (sort == "ФИО")
                {   // сортируем отобранные товары по наименованию
                    if (sortDirection == "возрастание")
                        employee = employee.OrderBy(p => p.ФИО).ToList();
                    else
                        employee = employee.
                            OrderByDescending(p => p.ФИО).ToList();
                }
                if (sort == "Номер роли")
                {
                    if (sort == "Номер роли")
                    {   // сортируем отобранные товары по наименованию
                        if (sortDirection == "возрастание")
                            employee = employee.OrderBy(p => p.ID_роли).ToList();
                        else
                            employee = employee.
                                OrderByDescending(p => p.ID_роли).ToList();
                    }
                }
                if (sort == "Должность")
                {   // сортируем отобранные товары по наименованию
                    if (sortDirection == "возрастание")
                        employee = employee.OrderBy(p => p.Должность).ToList();
                    else
                        employee = employee.
                                OrderByDescending(p => p.Должность).ToList();
                }
            }

            /////////////////////////////////////////////////
            // показываем данные (все или одну страницу)
            ShowCurrentPage();

        }

        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            //ChangePriorityForm changePriorityForm = new ChangePriorityForm();
            //    DialogResult dialogResult = changePriorityForm.ShowDialog();
            //    SortListView();
        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            search = SearchTxt.Text;
            PodgotovkaData();
        }

        private void sortComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sort = SearchTxt.Text;
            PodgotovkaData();
        }

        private void descCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (descCheckBox.Checked)
                sortDirection = "убывание";
            else
                sortDirection = "возрастание";

            PodgotovkaData();
        }

        private void filterComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            filtr = FiltrCombo.Text;
            PodgotovkaData();
        }

        private void ShowCurrentPage()
        {
            //////////////////////////////////////////////////////////////////
            // в данной версии просто передаем данные промежуточному элементу
            // 
            employeeBindingSource.DataSource = employee;
        }



        //private void changePriorityBtn_Click(object sender, EventArgs e)
        //{
        //    ChangePriorityForm changePriorityForm = new ChangePriorityForm();
        //    DialogResult dialogResult = changePriorityForm.ShowDialog();
        //    SortListView();
        //}
    }


}

