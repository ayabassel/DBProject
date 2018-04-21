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
    public partial class CustomerReport : Form
    {
        CrystalReport5 CR;
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CoustomerReport_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport5();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
