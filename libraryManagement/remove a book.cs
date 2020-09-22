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
    public partial class remove_a_book : Form
    {
        public remove_a_book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_all_book ob = new view_all_book();
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search ob = new Search();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            //delete//
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Data1 where Author_Name ='"+textBox1.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Do you want to delete record?", "Confomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            MessageBox.Show("Selected Data Deleted from Main Library Database ", "Confomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
