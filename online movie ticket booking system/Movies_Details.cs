using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_movie
{
    public partial class Movies_Details : Form
    {
        public Movies_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment sl = new Payment();
            sl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Now_Showing_Movie_List yy = new Now_Showing_Movie_List();
            yy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.axWindowsMediaPlayer1.URL = opn.FileName;

            }
        }

        

       
    }
}
