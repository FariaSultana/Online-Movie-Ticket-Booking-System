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
    public partial class Now_Showing_Movie_List : Form
    {
        public Now_Showing_Movie_List()
        {
            InitializeComponent();
        }

       

     

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie_details_Of_TheMummy sx = new Movie_details_Of_TheMummy();
            //Movies_Details sx = new Movies_Details();
            sx.Show();
        }

       

        

        

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Movies_Details sx = new Movies_Details();
            sx.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie_Details_Of_Nawbab ww = new Movie_Details_Of_Nawbab();
            ww.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie_Detail_Of_Aynabaji ee= new Movie_Detail_Of_Aynabaji();
            ee.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie_Details_Of_Spiderman uu = new Movie_Details_Of_Spiderman();
            uu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movies_Details_Of_Badshah oo = new Movies_Details_Of_Badshah();
            oo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie_Detail_Of_Transformer jj = new Movie_Detail_Of_Transformer();
            jj.Show();
        }
    }
}
