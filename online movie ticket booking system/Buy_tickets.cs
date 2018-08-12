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

//using online_movie.Properties;
namespace online_movie
{
    public partial class Buy_tickets : Form
    {
        DataAccess dt;
        public Buy_tickets()
        {
            InitializeComponent();
            dt = new DataAccess();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Now_Showing_Movie_List aa = new Now_Showing_Movie_List();
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dt.comm.CommandText = "insert into payment values ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "', '" + comboBox5.Text + "', '" + comboBox6.Text + "', '" + textBox9.Text + "', '"+textBox2.Text+"')";
            dt.conn.Open();
            dt.comm.ExecuteNonQuery();
            MessageBox.Show("Your Data Is Sucessfully Added To Our Database. Thank You For Using Our Application. [[[[[If you want to delete your booking then please write your booking Username and Press Delete Button]]]]]");
            dt.conn.Close();
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // Image image = Resources.i ;
            Bitmap bmp= Properties.Resources.index4;
            Image newimage= bmp;
            e.Graphics.DrawImage(newimage, 100, 0, newimage.Width, newimage.Height);
           
                e.Graphics.DrawString("Date :" + DateTime.Now, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25,550));
                e.Graphics.DrawString("UserName :" + textBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 600));
                //e.Graphics.DrawString("Date :" + DateTime.Now , new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 200));
                e.Graphics.DrawString("Movie_Name :" + comboBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 650));
                e.Graphics.DrawString("Seats :" + comboBox2.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 700));
                e.Graphics.DrawString("Hall :" + comboBox3.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 750));
                e.Graphics.DrawString("Date :" + comboBox4.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 800));
                e.Graphics.DrawString("Showtime :" + comboBox5.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 850));
                e.Graphics.DrawString("Ticket_Number :" + comboBox6.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 900));
                e.Graphics.DrawString("Bkash_Number :" + textBox9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 950));
                e.Graphics.DrawString("Total_To_Pay :" + textBox2.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 1000));
            


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            //comboBox6.Text = "";
            textBox9.Text = "";
            //textBox2.Text = "";

        }

             

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
           // textBox2.Text = (float.Parse(comboBox6.Text) * 300).ToString();
           // textBox2.Text = (Convert.ToInt32(comboBox6.Text) * 300).ToString();
            textBox2.Text = (Convert.ToInt32(comboBox6.Text) * 300).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            dt.comm.CommandText = "delete from payment where UserName='" + textBox1.Text + "'";
            dt.conn.Open();
            dt.comm.ExecuteNonQuery();
            MessageBox.Show("Your Data Is Sucessfully Deleted To Our Database. Please Choose Again.");
            dt.conn.Close();
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            //comboBox6.Text = "";
            //textBox2.Text = "";
            textBox9.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                
                dt.comm.CommandText = "Update payment set UserName= '" + textBox1.Text + "', Movie_name= '" + comboBox1.Text + "' , Seats= '" + comboBox2.Text + "', Hall= '" + comboBox3.Text + "', Date= '" + comboBox4.Text + "', Showtime= '" + comboBox5.Text + "', Bkash_Number= '" + textBox9.Text + "', Ticket_Number='"+comboBox6.Text+"' where UserName='" + textBox1.Text + "'";
                //dt.comm.CommandText = "Update payment set UserName= @textBox1, Movies_name=@comboBox1, Seats=@comboBox2, Hall=@comboBox3.Text, Date=@comboBox4, Showtimes=@comboBox5, Bkash_Number=@textBox9 where User_Nmae='" + textBox1.Text + "'";
                dt.conn.Open();
                dt.comm.ExecuteNonQuery();
                MessageBox.Show("Your Data Is Sucessfully Updated To Our Database. Thank You.");
                dt.conn.Close();
                //textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Not Updated");

            }
        }

        private void Buy_tickets_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            dt.comm.CommandText = "select Movie_Name from Movie_Name";
            dt.conn.Open();
            dt.comm.ExecuteNonQuery();
            SqlDataReader reader = dt.comm.ExecuteReader();
            comboBox5.Items.Clear();
            comboBox4.Items.Clear();
            comboBox3.Items.Clear();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString());

            }
            reader.Close();
            dt.comm.CommandText = "select Seats from seat";

            dt.comm.ExecuteNonQuery();
            SqlDataReader re = dt.comm.ExecuteReader();
            //SqlDataReader re = dt.comm.ExecuteReader();
            while (re.Read())
            {
                //comboBox1.Items.Add(reader.GetValue(0).ToString());
                comboBox2.Items.Add(re.GetValue(0).ToString());

            }


            //reader.Close();
            re.Close();

            dt.conn.Close();
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You.");
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select distinct Hall from Movie_Time where Movie_Name='" + comboBox1.Text + "' and Date='"+comboBox4.Text+"'", dt.conn);
            DataTable du = new DataTable();
            da.Fill(du);
            comboBox3.Items.Clear();
            foreach (DataRow row in du.Rows)
            {
                //comboBox4.Items.Add(row["Showtimes"].ToString());
                comboBox3.Items.Add(row["Hall"].ToString());
                //comboBox3.Items.Add(row["Hall"].ToString());


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter du = new SqlDataAdapter("select distinct Showtimes from Movie_Time where Date='"+comboBox4.Text+"' and Hall='" + comboBox3.Text + "' and Movie_Name='" + comboBox1.Text + "'", dt.conn);
            DataTable dr = new DataTable();
            du.Fill(dr);
            comboBox5.Items.Clear();
            foreach (DataRow row in dr.Rows)
            {
                //comboBox4.Items.Add(row["Showtimes"].ToString());
                //comboBox5.Items.Add(row["Date"].ToString());
                comboBox5.Items.Add(row["Showtimes"].ToString());


            }
        }

     

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select distinct Date from Movie_Time where Movie_Name='" + comboBox1.Text + "'", dt.conn);
            DataTable du = new DataTable();
            da.Fill(du);
            comboBox4.Items.Clear();
            foreach (DataRow row in du.Rows)
            {
                //comboBox4.Items.Add(row["Showtimes"].ToString());
                comboBox4.Items.Add(row["Date"].ToString());
                //comboBox3.Items.Add(row["Hall"].ToString());


            }
        }

       

        //private void fillcombo(ComboBox comboBox1, string query, string p)
        //{
          //  throw new NotImplementedException();
        //}

       
        

     
        //private void textBox9_TextChanged(object sender, EventArgs e)
        //{

       // }

        
        
    }
}
