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
    public partial class Reservation : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into RESERVATION (RESERVATION_ID, START_DATE, END_DATE, INSURANCE_PRICE, RENTAL_PRICE , CAR_NUMBER ) values( :id , :startDat ,:EndDat , :insurancePrice , :rentalPrice , :carNO)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.Text);
            cmd.Parameters.Add("startDat", Convert.ToDateTime(textBox1.Text));
            cmd.Parameters.Add("EndDat", Convert.ToDateTime(textBox2.Text));
            cmd.Parameters.Add("insurancePrice", textBox3.Text);
            cmd.Parameters.Add("rentalPrice", textBox4.Text);
            cmd.Parameters.Add("carNO", textBox5.Text);
            int t = cmd.ExecuteNonQuery();
            if( t!=-1 )
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("New Reservation is added");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " update RESERVATION set  ACTUAL_END_DATE=:actualEndDate , ADDITIONAL_PRICE=:AdditionalPrice where RESERVATION_ID=:reservationID ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("reservationID", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("AdditionalPrice", textBox6.Text);
            cmd.Parameters.Add("actualEndDate", textBox7.Text);
            int t = cmd.ExecuteNonQuery();
            if (t != 1)
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("Reservation is modified");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from RESERVATION where RESERVATION_ID=:reservationID";
            cmd.CommandType=CommandType.Text;
            cmd.Parameters.Add("reservationID", comboBox1.SelectedItem.ToString());
            int t = cmd.ExecuteNonQuery();
            if (t != -1)
            {
                MessageBox.Show("Reservation is deleted");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
