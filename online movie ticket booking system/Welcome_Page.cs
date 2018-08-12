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
    public partial class Welcome_Page : Form
    {
        //DataAccess dt;
        public Welcome_Page()
        {
            InitializeComponent();
                       //dt = new DataAccess();
        }

      

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login ll = new login();
            ll.Show();
        
        }
     

       

    
    
        }

       
    
}
