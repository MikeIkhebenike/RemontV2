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
        public static List<WorkCard> selectedRequestCard = new List<WorkCard>();

        public WorksForm()
        {
            InitializeComponent();
        }


    }
}
