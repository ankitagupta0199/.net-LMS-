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
    public partial class search_book : Form
    {
        public search_book()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //Book Title of All BOOk DATABASE Heading radiobutton1//
                SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from Data1 where Book_Title= '" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else
                if (radioButton2.Checked == true)
                {

                    ////
                    SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select* from Data1 where Author_Name= '" + textBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();

                }
                else
                    if (radioButton3.Checked == true)
                    {

                        ////
                        SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select* from Data1 where Book_Type= '" + textBox1.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        con.Close();

                    }
                    else
                        if (radioButton4.Checked == true)
                        {

                            ////
                            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("select* from Data1 where ISBN= '" + textBox1.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);

                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            con.Close();

                        }

                        else
                            if (radioButton5.Checked == true)
                            {

                                ////
                                SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("select* from Issue where Book_Call= '" + textBox1.Text + "'", con);
                                cmd.ExecuteNonQuery();
                                DataTable dt = new DataTable();
                                SqlDataAdapter da = new SqlDataAdapter(cmd);

                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                                con.Close();

                            }
                            else
                                if (radioButton6.Checked == true)
                                {

                                    ////
                                    SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("select* from Issue where Book_Name= '" + textBox1.Text + "'", con);
                                    cmd.ExecuteNonQuery();
                                    DataTable dt = new DataTable();
                                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                                    da.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                    con.Close();

                                }
                                else
                                    if (radioButton7.Checked == true)
                                    {

                                        ////
                                        SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                                        con.Open();
                                        SqlCommand cmd = new SqlCommand("select* from Issue where Department= '" + textBox1.Text + "'", con);
                                        cmd.ExecuteNonQuery();
                                        DataTable dt = new DataTable();
                                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                                        da.Fill(dt);
                                        dataGridView1.DataSource = dt;
                                        con.Close();

                                    }
                                    else
                                        if (radioButton8.Checked == true)
                                        {

                                            ////
                                            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                                            con.Open();
                                            SqlCommand cmd = new SqlCommand("select* from Issue where Registration= '" + textBox1.Text + "'", con);
                                            cmd.ExecuteNonQuery();
                                            DataTable dt = new DataTable();
                                            SqlDataAdapter da = new SqlDataAdapter(cmd);

                                            da.Fill(dt);
                                            dataGridView1.DataSource = dt;
                                            con.Close();

                                        }
                                        else
                                            if (radioButton9.Checked == true)
                                            {

                                                ////
                                                SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                                                con.Open();
                                                SqlCommand cmd = new SqlCommand("select* from Re_Data where Book_Name= '" + textBox1.Text + "'", con);
                                                cmd.ExecuteNonQuery();
                                                DataTable dt = new DataTable();
                                                SqlDataAdapter da = new SqlDataAdapter(cmd);

                                                da.Fill(dt);
                                                dataGridView1.DataSource = dt;
                                                con.Close();

                                            }
                                            else
                                                if (radioButton10.Checked == true)
                                                {

                                                    ////
                                                    SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                                                    con.Open();
                                                    SqlCommand cmd = new SqlCommand("select* from Re_Data where Department= '" + textBox1.Text + "'", con);
                                                    cmd.ExecuteNonQuery();
                                                    DataTable dt = new DataTable();
                                                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                                                    da.Fill(dt);
                                                    dataGridView1.DataSource = dt;
                                                    con.Close();

                                                }
                                                else
                                                    if (radioButton11.Checked == true)
                                                    {

                                                        ////
                                                        SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Library_management;Integrated Security=True");
                                                        con.Open();
                                                        SqlCommand cmd = new SqlCommand("select* from Re_Data where Registration_No= '" + textBox1.Text + "'", con);
                                                        cmd.ExecuteNonQuery();
                                                        DataTable dt = new DataTable();
                                                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                                                        da.Fill(dt);
                                                        dataGridView1.DataSource = dt;
                                                        con.Close();

                                                    }
        }

       
       

    }
}
