using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace online_movie
{
    public partial class Work : Form
    {
        DataAccess dt;
        public Work()
        {
            InitializeComponent();
            dt = new DataAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.comm.CommandText = "insert into Movie_Time values('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"')";
            dt.conn.Open();
            dt.comm.ExecuteNonQuery();
            dt.comm.CommandText = "insert into Movie_Name values('" + textBox1.Text + "')";
            dt.comm.ExecuteNonQuery();
            dt.comm.CommandText = "insert into seat values('"+textBox5.Text+"')";
            dt.comm.ExecuteNonQuery();
            MessageBox.Show("Added.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dt.conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.comm.CommandText = "delete from Movie_Time where Movie_Name='" + textBox1.Text + "'";
            dt.conn.Open();
            dt.comm.ExecuteNonQuery();
            dt.comm.CommandText = "delete from seat where Seats='" + textBox5.Text + "'";
            dt.comm.ExecuteNonQuery();
            dt.comm.CommandText = "delete from Movie_Name where Movie_Name='" + textBox1.Text + "'";
            dt.comm.ExecuteNonQuery();
            MessageBox.Show("Deleted.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dt.conn.Close();

        }


        public void display_data1()
        {
            dt.conn.Open();
            dt.comm.CommandText = "select * from master_card";
            dt.comm.ExecuteNonQuery();
            DataTable ms = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(dt.comm);
            sd.Fill(ms);
            dataGridView1.DataSource = ms;
            dt.conn.Close();


        }

        public void display_data2()
        {
            dt.conn.Open();
            dt.comm.CommandText = "select * from Visa_card";
            dt.comm.ExecuteNonQuery();
            DataTable vi = new DataTable();
            SqlDataAdapter sd1 = new SqlDataAdapter(dt.comm);
            sd1.Fill(vi);
            dataGridView1.DataSource = vi;
            dt.conn.Close();


        }

        public void display_data3()
        {
            dt.conn.Open();
            dt.comm.CommandText = "select * from payment";
            dt.comm.ExecuteNonQuery();
            DataTable py = new DataTable();
            SqlDataAdapter sd2 = new SqlDataAdapter(dt.comm);
            sd2.Fill(py);
            dataGridView1.DataSource = py;
            dt.conn.Close();

        }
        private void Work_Load(object sender, EventArgs e)
        {
            //display_data1();
            //display_data2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display_data1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display_data2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display_data3();
        }
    }
}
