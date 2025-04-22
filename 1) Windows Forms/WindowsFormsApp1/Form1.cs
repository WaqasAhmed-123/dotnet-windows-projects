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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=LAPTOP-8NA74C4E\SQLEXPRESS;Initial Catalog=DigithoDb;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            //string query = $"insert into User values('{2}','{Name.Text}','{Email.Text}','{Contact.Text}', '{Password.Text}')";
            string query = $"insert into CsvFiles values('{Name.Text}','{Email.Text}','{2545}', '{1}', '{1}', '{DateTime.Now}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection(@"Data Source=LAPTOP-8NA74C4E\SQLEXPRESS;Initial Catalog=WInForm1;Integrated Security=True");
            //cmd = new SqlCommand();
            //cmd.Connection = conn;
            displaydata();
        }

        private void displaydata()
        {
            conn = new SqlConnection(@"Data Source=LAPTOP-8NA74C4E\SQLEXPRESS;Initial Catalog=DigithoDb;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.CommandText = "select * from CsvFiles";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void cleardata()
        {
            Name.Clear();
            Email.Clear();
            Contact.Clear();
            Password.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
