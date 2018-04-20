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
    public partial class EXPENDITURES : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        
        public EXPENDITURES()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getCOMPANY_EXPENDITURES_by_id";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id1", textBox1.Text);
            cmd.Parameters.Add("numb", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("purch", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("rep", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("insure", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("maint", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int number = Convert.ToInt32(cmd.Parameters["numb"].Value.ToString());
            int purchas = Convert.ToInt32(cmd.Parameters["purch"].Value.ToString());
            int repair = Convert.ToInt32(cmd.Parameters["rep"].Value.ToString());
            int insur = Convert.ToInt32(cmd.Parameters["insure"].Value.ToString());
            int maintn = Convert.ToInt32(cmd.Parameters["maint"].Value.ToString());
            
            dataGridView1.Rows.Add(textBox1.Text, number, purchas, repair, insur, maintn);


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getCOMPANY_EXPENDITURES_by_no";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("numb", textBox2.Text);
            cmd.Parameters.Add("allow", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            }
            reader.Close();
        }
    }
}
