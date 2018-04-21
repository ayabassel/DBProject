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
    public partial class CarsReport : Form
    {
        CrystalReport3 CR;
        public CarsReport()
        {
            InitializeComponent();
        }

        private void CarsReport_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport3();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
