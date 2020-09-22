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
    public partial class next : Form
    {
        public next()
        {

            InitializeComponent();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            issue_a_book obj = new issue_a_book();
            obj.Show();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            
            remove_a_book obj = new remove_a_book();
            obj.Show();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            
            view_all_book obj = new view_all_book();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            view_issue_book obj = new view_issue_book();
            obj.Show();
        }

      

        private void button8_Click(object sender, EventArgs e)
        {
            
            search_book ob = new search_book();
            ob.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + 5, label1.Location.Y);
            if (label1.Location.X > this.Width)
            {
                label1.Location = new Point(0 - label1.Width, label1.Location.Y);

            }

        }

      

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Return_a_Book ob = new Return_a_Book();
            ob.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            view_return_book ob = new view_return_book();
            ob.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            add_book_to_library obj = new add_book_to_library();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          Rules  ob = new Rules ();
          ob.Show();
        }

      

       
    }
}
