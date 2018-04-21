using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DBproject
{
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        private void startup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation ff = new Reservation();
            ff.Show();
            //ff.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            carDetails frm = new carDetails();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EXPENDITURES fm = new EXPENDITURES();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Revenues tt = new Revenues();
            tt.Show();

        }

        private void btn_card_details_Click(object sender, EventArgs e)
        {
            Card_details form = new Card_details();
            form.Show();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            CarsReport form = new CarsReport();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomerReport form = new CustomerReport();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GuestRep form = new GuestRep();
            form.Show();
        }

 
    }
}
