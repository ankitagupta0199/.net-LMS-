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
    public partial class Change_password : Form
    {
        public Change_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //change password coding//
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
           
            SqlCommand cmd = new SqlCommand("select* from login  where Password='"+textBox1.Text+"' ", con);
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count.ToString() == "1")
            {

                if (textBox2.Text == textBox3.Text)
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand("update login set Password = '"+textBox2.Text+"' where Password = '"+textBox1.Text+"' ",con);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("successfully updated");
                    con.Close();
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "new password and confirm password should be same!";
                
                }
            }

            else
            {
                label4.Visible = true;
                label4.Text = "please check your old password";
            
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login ob = new login();
            ob.Show();
        }

       

       
    }
}
