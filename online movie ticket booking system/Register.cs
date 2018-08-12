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
    public partial class Register : Form
    {
        DataAccess dt;
        public Register()
        {
            InitializeComponent();
            dt = new DataAccess();
        }

        

        private void Register_Load(object sender, EventArgs e)
        {
            label5.Hide();

            textBox3.UseSystemPasswordChar = true ;
            textBox4.UseSystemPasswordChar = true;
            this.ActiveControl = textBox1;
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
             //dt.conn.Open();
             if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text=="" || textBox4.Text=="" || comboBox1.Text=="")
             {
                 MessageBox.Show("Please Enter Correctly. ");

             }
             else
             {
                 dt.conn.Open();
                 dt.comm.CommandText = "select * from login where Email='" + textBox2.Text + "'";
                 SqlDataAdapter dd = new SqlDataAdapter(dt.comm);
                 DataSet ds = new DataSet();
                 dd.Fill(ds);
                 if (ds.Tables[0].Rows.Count > 0)
                 {

                     MessageBox.Show("Email Already Exit.Plesae Put Another Email address");
                     //ds.Clear();
                 }
                 else
                 {
                     if (textBox3.Text == textBox4.Text)
                     {
                        //dt.conn.Open();
                         dt.comm.CommandText = "insert into Register values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "','"+comboBox1.Text+"')";
                         //dt.conn.Open();
                         dt.comm.ExecuteNonQuery();
                         dt.comm.CommandText = "insert into login values ('" + textBox1.Text + "', '"+textBox2.Text+"','" + textBox3.Text + "', '"+comboBox1.Text+"')";
                         dt.comm.ExecuteNonQuery();
                         MessageBox.Show("You are registered!!!!!!!!!!!");
                         //dt.conn.Close();
                         //this.Hide();
                         //Movie sc = new Movie();
                         //sc.Show();
                     }
                     else
                     {
                         MessageBox.Show("Check Your Password");

                     }
                    
                 }
                 dt.conn.Close();
             }
             //dt.conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login al = new login();
            al.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBox1.Checked)
            {

                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
            else
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;

            }
        }

       

       
        
    }
}
