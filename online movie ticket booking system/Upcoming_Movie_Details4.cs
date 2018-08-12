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
    public partial class Upcoming_Movie_Details4 : Form
    {
        public Upcoming_Movie_Details4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.axWindowsMediaPlayer1.URL = opn.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcomimg_Movie wo = new Upcomimg_Movie();
            wo.Show();
        }
    }
}
