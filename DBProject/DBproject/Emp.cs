using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class Emp : Form
    {
        public Emp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = "select * from Emp where DEPTNO = :id ";

            OracleDataAdapter myAdapter = new OracleDataAdapter(cmdstr, constr);

            myAdapter.SelectCommand.Parameters.Add("id",textBox1.ToString());

            DataSet myDataSet = new DataSet();

            myAdapter.Fill(myDataSet);

           
            dataGridView1.DataSource = myDataSet.Tables[0];
        }
    }
}
