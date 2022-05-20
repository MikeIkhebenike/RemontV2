using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RemontV2.Views
{
    public partial class AdminForm : Form
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

        public AdminForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = EmployeeListBtn.Height;
            PnlNav.Top = EmployeeListBtn.Top;
            PnlNav.Left = EmployeeListBtn.Left;
            EmployeeListBtn.BackColor = Color.FromArgb(93, 118, 203);
            
            lblTitle.Text = "Список сотрудников";
            this.PnlFormLoad.Controls.Clear();
            EmployeeForm EmployeePanel_S = new EmployeeForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            EmployeePanel_S.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoad.Controls.Add(EmployeePanel_S);
            EmployeePanel_S.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeListBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = EmployeeListBtn.Height;
            PnlNav.Top = EmployeeListBtn.Top;
            PnlNav.Left = EmployeeListBtn.Left;
            EmployeeListBtn.BackColor = Color.FromArgb(93, 118, 203);
            lblTitle.Text = "Список сотрудников";
            this.PnlFormLoad.Controls.Clear();
            EmployeeForm EmployeePanel_S = new EmployeeForm() { Dock = DockStyle.Fill, TopLevel = false,
                TopMost = true};
            EmployeePanel_S.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoad.Controls.Add(EmployeePanel_S);
            EmployeePanel_S.Show();
        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = RequestsBtn.Height;
            PnlNav.Top = RequestsBtn.Top;
            PnlNav.Left = RequestsBtn.Left;
            RequestsBtn.BackColor = Color.FromArgb(93, 118, 203);
        }

        private void AccessoriesBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = AccessoriesBtn.Height;
            PnlNav.Top = AccessoriesBtn.Top;
            PnlNav.Left = AccessoriesBtn.Left;
            AccessoriesBtn.BackColor = Color.FromArgb(93, 118, 203);
        }

        private void WorksBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = WorksBtn.Height;
            PnlNav.Top = WorksBtn.Top;
            PnlNav.Left = WorksBtn.Left;
            WorksBtn.BackColor = Color.FromArgb(93, 118, 203);
        }

        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SuppliersBtn.Height;
            PnlNav.Top = SuppliersBtn.Top;
            PnlNav.Left = SuppliersBtn.Left;
            SuppliersBtn.BackColor = Color.FromArgb(93, 118, 203);
        }

        private void SuppRequestBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SuppRequestBtn.Height;
            PnlNav.Top = SuppRequestBtn.Top;
            PnlNav.Left = SuppRequestBtn.Left;
            SuppRequestBtn.BackColor = Color.FromArgb(93, 118, 203);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }

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
