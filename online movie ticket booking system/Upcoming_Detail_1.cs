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
    public partial class Upcoming_Detail_1 : Form
    {
        public Upcoming_Detail_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcomimg_Movie yp = new Upcomimg_Movie();
            yp.Show();
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
