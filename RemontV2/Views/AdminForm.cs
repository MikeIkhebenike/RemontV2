using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RemontV2.Views
{
    public partial class AdminForm : Form
    {
        //Используется библиотека для "рисования" формы
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //Метод, который создает закругленные рамки для формы
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

        public AdminForm()
        {
            InitializeComponent();
            //Добавление округлых границ для формы
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = EmployeeListBtn.Height;
            PnlNav.Top = EmployeeListBtn.Top;
            PnlNav.Left = EmployeeListBtn.Left;
            EmployeeListBtn.BackColor = Color.FromArgb(93, 118, 203);

            //Изменение заголовка формы
            lblTitle.Text = "Список сотрудников";
            this.NewFormPanelLoader.Controls.Clear();
            //Предварительна загрузка формы со списком сотрудников при запуске формы
            EmployeeForm EmployeePanel = new EmployeeForm()
            {
                //Перечисление свойств дизайна формы
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

            };
            EmployeePanel.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(EmployeePanel);
            EmployeePanel.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        //Обработка события нажатия на кнопку "Список сотрудников"
        private void EmployeeListBtn_Click(object sender, EventArgs e)
        {
            //Цвет кнопки и вспомогательная полоса для навигации при нажатии на кнопку для перехода к нужной форме
            PnlNav.Height = EmployeeListBtn.Height;
            PnlNav.Top = EmployeeListBtn.Top;
            PnlNav.Left = EmployeeListBtn.Left;
            EmployeeListBtn.BackColor = Color.FromArgb(93, 118, 203);
    
            lblTitle.Text = "Список сотрудников";
            this.NewFormPanelLoader.Controls.Clear();
            EmployeeForm EmployeePanel = new EmployeeForm() 
            { 
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            EmployeePanel.FormBorderStyle = FormBorderStyle.None;
            //Загрузка формы EmployeeForm в элемент NewFormPanelLoader формы AdminForm
            this.NewFormPanelLoader.Controls.Add(EmployeePanel);
            EmployeePanel.Show();
        }
        //Обработка события нажатия на кнопку "Список заявок"
        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            //Цвет кнопки и вспомогательная полоса для навигации при нажатии на кнопку для перехода к нужной форме
            PnlNav.Height = RequestsBtn.Height;
            PnlNav.Top = RequestsBtn.Top;
            PnlNav.Left = RequestsBtn.Left;
            RequestsBtn.BackColor = Color.FromArgb(93, 118, 203);

            lblTitle.Text = "Список заявок";
            this.NewFormPanelLoader.Controls.Clear();
            RequestsForm ReqForm = new RequestsForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            ReqForm.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(ReqForm);
            ReqForm.Show();
        }

        private void AccessoriesBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = AccessoriesBtn.Height;
            PnlNav.Top = AccessoriesBtn.Top;
            PnlNav.Left = AccessoriesBtn.Left;
            AccessoriesBtn.BackColor = Color.FromArgb(93, 118, 203);

            lblTitle.Text = "Список комплектующих";
            this.NewFormPanelLoader.Controls.Clear();
            AccessoriesForm AccForm = new AccessoriesForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            AccForm.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(AccForm);
            AccForm.Show();
        }

        private void WorksBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = WorksBtn.Height;
            PnlNav.Top = WorksBtn.Top;
            PnlNav.Left = WorksBtn.Left;
            WorksBtn.BackColor = Color.FromArgb(93, 118, 203);

            lblTitle.Text = "Список работ";
            this.NewFormPanelLoader.Controls.Clear();
            WorksForm WrkForm = new WorksForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            WrkForm.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(WrkForm);
            WrkForm.Show();
        }

        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SuppliersBtn.Height;
            PnlNav.Top = SuppliersBtn.Top;
            PnlNav.Left = SuppliersBtn.Left;
            SuppliersBtn.BackColor = Color.FromArgb(93, 118, 203);

            lblTitle.Text = "Список поставщиков";
            this.NewFormPanelLoader.Controls.Clear();
            SuppliersForm SupplierPanel = new SuppliersForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            SupplierPanel.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(SupplierPanel);
            SupplierPanel.Show();
        }

        private void SuppRequestBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SuppRequestBtn.Height;
            PnlNav.Top = SuppRequestBtn.Top;
            PnlNav.Left = SuppRequestBtn.Left;
            SuppRequestBtn.BackColor = Color.FromArgb(93, 118, 203);

            lblTitle.Text = "Список запросов на поставку";
            this.NewFormPanelLoader.Controls.Clear();
            ListOfReqsForm ListReqsPanel = new ListOfReqsForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            ListReqsPanel.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(ListReqsPanel);
            ListReqsPanel.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            AuthFRM ATF = new AuthFRM();
            this.Close();
            ATF.Show();
            MessageBox.Show("Вы вышли из учетной записи!");
        }
        //кнопка уходит из фокуса и принимает изначальный цвет
        private void EmployeeListBtn_Leave(object sender, EventArgs e)
        {
            EmployeeListBtn.BackColor = Color.FromArgb(153, 180, 209);
        }

        private void RequestsBtn_Leave(object sender, EventArgs e)
        {
            RequestsBtn.BackColor = Color.FromArgb(153, 180, 209);
        }

        private void AccessoriesBtn_Leave(object sender, EventArgs e)
        {
            AccessoriesBtn.BackColor = Color.FromArgb(153, 180, 209);
        }

        private void WorksBtn_Leave(object sender, EventArgs e)
        {
            WorksBtn.BackColor = Color.FromArgb(153, 180, 209);
        }

        private void SuppliersBtn_Leave(object sender, EventArgs e)
        {
            SuppliersBtn.BackColor = Color.FromArgb(153, 180, 209);
        }

        private void SuppRequestBtn_Leave(object sender, EventArgs e)
        {
            SuppRequestBtn.BackColor = Color.FromArgb(153, 180, 209);
        }

        private void ExitBtn_Leave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(153, 180, 209);
        }

        private void ShutDownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
