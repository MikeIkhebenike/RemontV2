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
    public partial class PrintWork : Form
    {
        Ремонт currentWork = new Ремонт();
        public string Date, WorkID, RequestID, DateStart, DateEnd, WorkType, Employee,
            Accessorie, Service, Status, Cost;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        Bitmap bitmap;

        public PrintWork()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("d/M/yyyy");
        }
       

        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Печать");
        }

        private void PrintWork_Load(object sender, EventArgs e)
        {
            WorkLbl.Text = WorkID;
            RequestLbl.Text = RequestID;
            DateNowLbl.Text = Date;
            dateStartLbl.Text = DateStart;
            dateEndLbl.Text = DateEnd;
            workTypeLbl.Text = WorkType;
            employeeLbl.Text = Employee;
            accessorieLbl.Text = Accessorie;
            ServiceLbl.Text = Service;
            statusLbl.Text = Status;
            costLbl.Text = Cost;


        }
    }
}
