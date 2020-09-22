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
    public partial class Return_a_Book : Form
    {
        public Return_a_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_return_book ob = new view_return_book();
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            view_all_book ob = new view_all_book();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("update  Data1 set Book_Quantity=Book_Quantity+1 where Book_Title ='" + textBox3.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlCommand cm = new SqlCommand("insert into Re_Data values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.SelectedItem + "')", con);
            cm.ExecuteNonQuery();


            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            return_Search ob = new return_Search();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       

       
    }
}
