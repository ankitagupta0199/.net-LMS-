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
    public partial class return_Search : Form
    {
        public return_Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search//
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select* from Re_Data where Id= '" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
