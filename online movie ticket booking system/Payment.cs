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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy_tickets fg = new Buy_tickets();
            fg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mastercard ii = new Mastercard();
            ii.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisaCard it = new VisaCard();
            it.Show();

        }

        
    }
}
