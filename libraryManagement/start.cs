using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryManagement
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            progress();
            this.Hide();
            login ob = new login();
            ob.Show();
           
           
           
        }

        public void progress()
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500000;

            for (i = 0; i <= 500000; i++)
            {
                progressBar1.Value = i;
            }
        }
    }
}
 


    