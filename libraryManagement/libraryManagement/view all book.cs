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
    public partial class view_all_book : Form
    {
        public view_all_book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show data in grid view//
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select* from Data1", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
