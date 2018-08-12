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
    public partial class Upcomimg_Movie : Form
    {
        public Upcomimg_Movie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie ap = new Movie();
            ap.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcoming_Detail_1 aw = new Upcoming_Detail_1();
            aw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcomming_Movie_Details2 sa = new Upcomming_Movie_Details2();
            sa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcoming_Movie_Details3 up = new Upcoming_Movie_Details3();
            up.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcoming_Movie_Details4 wo = new Upcoming_Movie_Details4();
            wo.Show();
        }
    }
}
