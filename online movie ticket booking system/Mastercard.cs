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
    public partial class Mastercard : Form
    {
        DataAccess dt;
        public Mastercard()
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
            
                dt.comm.CommandText = "insert into master_card values ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "', '" + comboBox5.Text + "', '" + comboBox6.Text + "', '" + textBox2.Text + "')";
                dt.conn.Open();
                dt.comm.ExecuteNonQuery();
                MessageBox.Show("Your Data Is Sucessfully Added To Our Database. Thank You For Using Our Application");
                MessageBox.Show("[[[[[If you want to delete your booking then please write your booking Username and Press Delete Button]]]]]");
                dt.conn.Close();
                /*textBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
                comboBox5.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox2.Text = "";*/
                //comboBox6.Text = "";
                //textBox2.Text = "";

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.index4;
            Image newimage = bmp;
            e.Graphics.DrawImage(newimage, 100, 0, newimage.Width, newimage.Height);

           // Image image = Resources.i;

            //e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date :" + DateTime.Now, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 550));
            e.Graphics.DrawString("UserName :" + textBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 600));
            //e.Graphics.DrawString("Date :" + DateTime.Now , new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Movie_Name :" + comboBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 650));
            e.Graphics.DrawString("CardHolder_Name :" + textBox3.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 700));
            e.Graphics.DrawString("Card_Number :" + textBox4.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 750));
            e.Graphics.DrawString("Seats :" + comboBox2.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 800));
            e.Graphics.DrawString("Hall :" + comboBox3.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 850));
            e.Graphics.DrawString("Date :" + comboBox4.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 900));
            e.Graphics.DrawString("Showtime :" + comboBox5.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 950));
            e.Graphics.DrawString("Ticket_Number :" + comboBox6.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 1000));
            //e.Graphics.DrawString("Bkash_Number :" + textBox9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 950));
            e.Graphics.DrawString("Total_To_Pay :" + textBox2.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 1050));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            printDocument1.Print();
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            //comboBox6.Text = "";
            //textBox2.Text = "";
            //textBox2.Text = "";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToInt32(comboBox6.Text) * 300).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dt.comm.CommandText = "delete from master_card where User_Name='" + textBox1.Text + "'";
            dt.conn.Open();
            dt.comm.ExecuteNonQuery();
            MessageBox.Show("Your Data Is Sucessfully Deleted To Our Database. Please Choose Again.");
            dt.conn.Close();
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            //comboBox6.Text = "";
            //textBox2.Text = "";
            //textBox9.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                
                dt.comm.CommandText = "Update master_card set User_Name= '" + textBox1.Text + "', Movie_Name= '" + comboBox1.Text + "' , CardHolder_Name= '" + textBox3.Text + "', Card_Number= '" + textBox4.Text + "', Seats= '" + comboBox2.Text + "', Hall= '" + comboBox3.Text + "', Date= '" + comboBox4.Text + "', Showtime= '" + comboBox5.Text + "',Ticket_Number= '" + comboBox6.Text + "' where User_Name='" + textBox1.Text + "'";
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

        private void Mastercard_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            dt.comm.CommandText = "select Movie_Name from Movie_Name";
            //dt.comm.CommandText = "select Seats from seat";
            //dt.comm.CommandText = "select Hall from hall";
            dt.conn.Open();
            dt.comm.ExecuteNonQuery();
            SqlDataReader reader = dt.comm.ExecuteReader();
            comboBox5.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

           
            //SqlDataReader re = dt.comm.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString());
                //comboBox2.Items.Add(re.GetValue(0).ToString());

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dt.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select distinct Date from Movie_Time where Movie_Name='"+comboBox1.Text+"'",dt.conn);
            DataTable du = new DataTable();
            da.Fill(du);
            comboBox5.Items.Clear();
           foreach(DataRow row in du.Rows)
           {
               //comboBox4.Items.Add(row["Showtimes"].ToString());
               comboBox5.Items.Add(row["Date"].ToString());
                             
               //comboBox3.Items.Add(row["Hall"].ToString());


           }
           //comboBox5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You..");
            this.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter du = new SqlDataAdapter("select distinct Hall from Movie_Time where Date='"+comboBox5.Text+"' and Movie_Name='"+comboBox1.Text+"'", dt.conn);
            DataTable dr = new DataTable();
            du.Fill(dr);
            //comboBox4.Items.Add();
            comboBox3.Items.Clear();
            foreach (DataRow row in dr.Rows)
            {
                //comboBox4.Items.Add(row["Showtimes"].ToString());
                //comboBox5.Items.Add(row["Date"].ToString());
                comboBox3.Items.Add(row["Hall"].ToString());


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dy = new SqlDataAdapter("select distinct Showtimes from Movie_Time where Date='"+comboBox5.Text+"' and Hall='" + comboBox3.Text + "' and Movie_Name='" + comboBox1.Text + "'", dt.conn);
            DataTable dw = new DataTable();
            dy.Fill(dw);
            comboBox4.Items.Clear();
            foreach (DataRow row in dw.Rows)
            {
                comboBox4.Items.Add(row["Showtimes"].ToString());
                //comboBox5.Items.Add(row["Date"].ToString());
                //comboBox3.Items.Add(row["Hall"].ToString());


            }
        }

       

        

        



        

    }
}
