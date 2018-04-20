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
    public partial class Revenues : Form
    {

        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Revenues()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(ordb);
            conn.Open();
            int maxID, newID;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GETID";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("idd", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(c.Parameters["idd"].Value.ToString());
                newID = maxID + 1;
                   
            }
            catch
            {
                newID = 1;
            }
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_COMPANY_REVENUES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id2", newID);
            cmd.Parameters.Add("insure", textBox2.Text);
            cmd.Parameters.Add("carsales", textBox3.Text);
            cmd.Parameters.Add("carhire", textBox4.Text);
            cmd.Parameters.Add("regestirationNO", textBox5.Text);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Revenues is succeffully recorded");




            }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open(); 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update_COMPANY_REVENUES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", comboBox1.Text);
            cmd.Parameters.Add("insur", textBox2.Text);
            cmd.Parameters.Add("carhir", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Revenue is updated succesfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete_COMPANY_REVENUES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("idd", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Revenue is Deleted succesfully");
        }
    }
}
