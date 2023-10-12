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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NIMESH;Initial Catalog=library;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Login (Username, Password) VALUES (@username, @password)", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Account created successfully.");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Account creation failed.");
                }

            }
           

           
            }

        private void label4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
