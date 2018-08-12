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
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
            
        }

        private void User_login_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox2.UseSystemPasswordChar = true;
            this.ActiveControl = textBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register sd = new Register();
            sd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 

                          
                    SqlConnection con = new SqlConnection(@"server=DESKTOP-CRBD5TP\SQLExpress; database=StudentDB; trusted_connection=True");
                    con.Open();
                    //SqlCommand cmd = new SqlCommand("Select Count(*) from login where UserName='" + textBox1.Text + "', Password= '" + textBox2.Text + "' and Type='"+comboBox1.Text+"'", con);
                    SqlDataAdapter sd = new SqlDataAdapter("select count(*) from login where UserName='"+textBox1.Text+"' and Password='"+textBox2.Text+"' and Type='"+comboBox1.Text+"'",con);
                    DataTable st = new DataTable();
                     sd.Fill(st);
                    if (st.Rows[0][0].ToString() == "1")
                    {
                        SqlDataAdapter sda1 = new SqlDataAdapter("select Type from login where UserName='" + textBox1.Text + "' and Password= '" + textBox2.Text + "'", con);
                        DataTable st1 = new DataTable();
                        sda1.Fill(st1);
                        if (st1.Rows[0][0].ToString() == "Admin")
                        {

                            this.Hide();
                            Work qq = new Work();
                            qq.Show();
                        }
                        if (st1.Rows[0][0].ToString() == "User")
                        {

                            this.Hide();
                            Movie nn = new Movie();
                            nn.Show();
                        }
                      

                        /*this.Hide();
                        Movie ss = new Movie();
                        ss.Show();*/
                    }
                    else
                    {
                        MessageBox.Show(" Please check your Username and Password and Type");

                    }
                
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {

                textBox2.UseSystemPasswordChar = true;
                //textBox4.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                //textBox4.UseSystemPasswordChar = false;

            }
        }

       
      
    }
}
