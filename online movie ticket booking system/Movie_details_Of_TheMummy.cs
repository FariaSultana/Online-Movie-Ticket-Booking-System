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
    public partial class Movie_details_Of_TheMummy : Form
    {
        public Movie_details_Of_TheMummy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment sk = new Payment();
            sk.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Now_Showing_Movie_List dd = new Now_Showing_Movie_List();
            dd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.axWindowsMediaPlayer1.URL = opn.FileName;

            }
        }
//
        
    }
}
