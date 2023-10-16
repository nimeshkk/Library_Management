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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NIMESH;Initial Catalog=library;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a value in EnrollNo.");
            }

            else
            {
               

                using (SqlCommand cmd = new SqlCommand("ViewIssueBook", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Enrollment_No", SqlDbType.NVarChar).Value = textBox1.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();





                }
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
         
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update_issueBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Return_Date", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToShortDateString();

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Book Return Successfully");
                con.Close();





            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashbord db = new Dashbord();
            db.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
            this.Hide();

        }
    }
}
