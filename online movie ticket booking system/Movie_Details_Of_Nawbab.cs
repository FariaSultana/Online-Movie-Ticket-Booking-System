﻿using System;
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
    public partial class Movie_Details_Of_Nawbab : Form
    {
        public Movie_Details_Of_Nawbab()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Now_Showing_Movie_List dd = new Now_Showing_Movie_List();
            dd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment sk = new Payment();
            sk.Show();
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
