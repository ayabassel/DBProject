using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBproject
{
    public partial class GuestRep : Form
    {
        GuestReport CR;
        public GuestRep()
        {
            InitializeComponent();
        }

        private void GuestRep_Load(object sender, EventArgs e)
        {
            CR = new GuestReport();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
