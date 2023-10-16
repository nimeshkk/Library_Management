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
    public partial class ReturnBookReport : Form
    {
        public ReturnBookReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NIMESH;Initial Catalog=library;Integrated Security=True;");

        private void ReturnBookReport_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Reports", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@report", SqlDbType.NVarChar).Value = "Return";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();





            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord db = new Dashbord();
            db.Show();
            this.Hide();
        }
    }
}
