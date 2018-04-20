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
    public partial class ShowTableData : Form
    {
        public ShowTableData()
        {
            InitializeComponent();
        }

        private void ShowTableData_Load(object sender, EventArgs e)
        {
            

            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = "select * from :T ";

            OracleDataAdapter myAdapter = new OracleDataAdapter(cmdstr, constr);

            myAdapter.SelectCommand.Parameters.Add("T", textBox1.ToString());

            DataSet myDataSet = new DataSet();

            myAdapter.Fill(myDataSet);


            dataGridView1.DataSource = myDataSet.Tables[0];



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
