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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //about us//
            MessageBox.Show("by team of Ankita!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit//
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //registration//
            this.Close();
            registration obj = new registration();
            obj.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //login on button click//
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select* from login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);

            da.Fill(ds);
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("enter username or password..!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else  if (ds.Tables[0].Rows.Count > 0)
            {
                next obj = new next();
                obj.Show();
                this.Hide();
            }
            else
                MessageBox.Show("invalid username or password..!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.textBox2.PasswordChar = Convert.ToChar(0);
            }
            else
            {
                this.textBox2.PasswordChar = '*';
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //registration//
            registration obj = new registration();
            obj.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

      
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //login on click ENTER key//
                SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=minii;Integrated Security=True");
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select* from login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);

                da.Fill(ds);
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("enter username or password..!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (ds.Tables[0].Rows.Count > 0)
                {
                    next obj = new next();
                    obj.Show();
                    this.Hide();


                }
                else
                    MessageBox.Show("invalid username or password..!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Change_password ob = new Change_password();
            ob.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Forget_password ob = new Forget_password();
            ob.Show();
        }

       
       
    }
}
