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
    public partial class carDetails : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public carDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            dataGridView1.Columns.Add("REGISTRATION_NO", "RegisterationNO");
            dataGridView1.Columns.Add("PURCHASE_PRICE", "PURCHASE PRICE");
            dataGridView1.Columns.Add("MAKE", "MAKE");
            dataGridView1.Columns.Add("RENT_PRICE", "RENT PRICE");
            dataGridView1.Columns.Add("YEAR_OF_PROD", "PrdYear");
            dataGridView1.Columns.Add("MODEL", "PURCHASE PRICE");
            dataGridView1.Columns.Add("PURCHASE_PRICE", "MODEL");
            dataGridView1.Columns.Add("ENGINE_SIZE", "ENGINE");
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from CAR";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

                
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),reader[5].ToString(),reader[6].ToString(),
                reader[7].ToString());
                
            }
            reader.Close();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "select * from CAR where MODEL=:modl and STATUS=:stat";
            command.CommandType = CommandType.Text;
            command.Parameters.Add("modl", textBox1.Text);
            command.Parameters.Add("stat", textBox2.Text);
            OracleDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(),
                 rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString(), rd[11].ToString());

            }
            rd.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Reservation f = new Reservation();
            f.Show();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startup ts = new startup();
            ts.Show();

        }
    }
}
