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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Now_Showing_Movie_List sb = new Now_Showing_Movie_List();
            sb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcomimg_Movie yy = new Upcomimg_Movie();
            yy.Show();
        }
    }
}
