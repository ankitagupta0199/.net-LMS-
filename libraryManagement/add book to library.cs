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
    public partial class add_book_to_library : Form
    {
        public add_book_to_library()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         //Reset Data //
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem=null;
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.SelectedItem=null;
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
            comboBox5.SelectedItem = null;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            view_all_book ob = new view_all_book();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert data to table//
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Data1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + textBox3.Text + "','" + comboBox3.SelectedItem + "','" + textBox4.Text + "','" + comboBox4.SelectedItem + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox5.SelectedItem + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Do you want to update record?", "Confomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            MessageBox.Show("All Data Saved in Main Library Database ", "Confomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem = null;
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.SelectedItem = null;
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
            comboBox5.SelectedItem = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Search ob = new Search();
            ob.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       

       

       
       
    }
}
