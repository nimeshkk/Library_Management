using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=NIMESH;Initial Catalog=library;Integrated Security=True;");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getbooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please enter a value in EnrollNo.");
            }
            else if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please select a value in comboBox1.");
            }
            else
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("ViewStudents", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@EnrollNo", SqlDbType.NVarChar).Value = textBox6.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    bool found = false; 

                    while (dr.Read())
                    {
                        found = true; 

                        string studentName = dr["StudentName"].ToString();
                        string enrollNo = dr["EnrollNo"].ToString();
                        string depName = dr["DepName"].ToString();
                        string studentContact = dr["StudentContact"].ToString();
                        string studentEmail = dr["StudentEmail"].ToString();

                        textBox1.Text = studentName;
                        textBox2.Text = enrollNo;
                        textBox3.Text = depName;
                        textBox4.Text = studentContact;
                        textBox5.Text = studentEmail;
                    }

                    dr.Close();

                    con.Close();

                    if (!found)
                    {
                        MessageBox.Show("No data found for the provided EnrollNo.");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                    }
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
           Dashbord db = new Dashbord();
            db.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_issuebook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@Enrollment_No", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Department ", SqlDbType.NVarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBox5.Text;
                cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = comboBox1.Text;
                cmd.Parameters.Add("@Issue_Date", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@Return_Date", SqlDbType.NVarChar).Value = "";

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Issue Book Added Successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
