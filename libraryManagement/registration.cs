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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                 //registed user with username and password//
                SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into login values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedItem + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New User Created Now you can Login Press Back Button for Login Page!", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            else
            {
                label12.Visible = true;
                label12.Text="Password & confirm Password is not same.!";           
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login ob = new login();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
