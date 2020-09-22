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
    public partial class issue_a_book : Form
    {
        public issue_a_book()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void issue_a_book_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                con.Open();

                  SqlCommand cmd = new SqlCommand("update  Data1 set Book_Quantity=Book_Quantity-1 where Book_Title ='" + textBox3.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cm = new SqlCommand("insert into Issue values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", con);
                    cm.ExecuteNonQuery();
 
                
                con.Close();
                MessageBox.Show("Do you want to update record?", "Confomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                MessageBox.Show("All Data Saved in Issue Library Database ", "Confomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            view_issue_book ob = new view_issue_book();
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            view_all_book ob = new view_all_book();
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

        private void button3_Click(object sender, EventArgs e)
        {
            issue_Search ob = new issue_Search();
            ob.Show();
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
                textBox3.Focus();
            }
        }

       

       

      

       

       
    }
}
