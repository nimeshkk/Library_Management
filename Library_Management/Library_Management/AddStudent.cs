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

namespace Library_Management
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NIMESH;Initial Catalog=library;Integrated Security=True;");
        private void button2_Click(object sender, EventArgs e)
        {
            Dashbord dab = new Dashbord();
            dab.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_add_student", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@EnrollNo", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@DepName", SqlDbType.NVarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@StudentContact", SqlDbType.NVarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@StudentEmail", SqlDbType.NVarChar).Value = textBox5.Text;
                cmd.Parameters.Add("@StudentSemester", SqlDbType.NVarChar).Value = textBox6.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added Successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
               
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
