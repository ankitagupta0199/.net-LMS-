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
    public partial class Forget_password : Form
    {
        public Forget_password()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            login ob = new login();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label2.Visible = true;
            label2.Text = "Username";
            label4.Visible = true;
            label4.Text = "Password";
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Username,Password from login where Username='" + textBox1.Text + "' and Email='"+textBox2.Text+"' and Nickname='"+textBox3.Text+"' and Secret_Password='"+textBox4.Text+"' and Information='"+textBox5.Text+"'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                label6.Visible = true;
                label7.Visible = true;

                label6.Text = Convert.ToString(rd["Username"]);
                label7.Text = Convert.ToString(rd["Password"]);


            
            }

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }

       
}
