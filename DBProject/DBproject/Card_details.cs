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
    public partial class Card_details : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public Card_details()
        {
            InitializeComponent();

        }

        private void Card_details_Load(object sender, EventArgs e)
        {
            string connstr = "Data Source=orcl; User ID=scott; Password=tiger; ";
            string command = @"select * from card_details;";

            adapter = new OracleDataAdapter(command, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);

        }

        private void lhom(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
