using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RemontV2.Models;
using RemontV2.Utils;

namespace RemontV2.Views
{
    public partial class EngineerForm : Form
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
        public EngineerForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = WorksBtn.Height;
            PnlNav.Top = WorksBtn.Top;
            PnlNav.Left = WorksBtn.Left;
            WorksBtn.BackColor = Color.FromArgb(93, 118, 203);

            //Показ данных формы через панель
            lblTitle.Text = "Список работ";
            this.NewFormPanelLoader.Controls.Clear();
            WorksForm WorksPanel = new WorksForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

            };
            WorksPanel.FormBorderStyle = FormBorderStyle.None;
            this.NewFormPanelLoader.Controls.Add(WorksPanel);
            WorksPanel.Show();
        }

        private void EngineerForm_Load(object sender, EventArgs e)
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            AuthFRM ATF = new AuthFRM();
            this.Close();
            ATF.Show();
            MessageBox.Show("Вы вышли из учетной записи!");
        }

        private void ShutDownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void ExitBtn_Leave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(153, 180, 209);
        }
    }
}
