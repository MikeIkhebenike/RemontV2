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
using System.Runtime.InteropServices;

namespace RemontV2.Views
{
    public partial class ManagerForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

        public ManagerForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = RequestsBtn.Height;
            PnlNav.Top = RequestsBtn.Top;
            PnlNav.Left = RequestsBtn.Left;
            RequestsBtn.BackColor = Color.FromArgb(93, 118, 203);

            //Показ данных формы через панель
            lblTitle.Text = "Список заявок";
            this.NewFormPanelLoader.Controls.Clear();
            RequestsForm RequestsPanel = new RequestsForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

            };
            RequestsPanel.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(RequestsPanel);
            RequestsPanel.Show();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
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


        private void RequestsBtn_Leave(object sender, EventArgs e)
        {
            RequestsBtn.BackColor = Color.FromArgb(153, 180, 209);
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

        private void ShutDownBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
