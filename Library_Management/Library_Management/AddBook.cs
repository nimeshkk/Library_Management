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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=NIMESH;Initial Catalog=library;Integrated Security=True;");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

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
                SqlCommand cmd = new SqlCommand("sp_add_book", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Publication", SqlDbType.NVarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@PurchaseDate", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@BookPrice", SqlDbType.Int).Value = textBox4.Text;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = textBox5.Text;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
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
