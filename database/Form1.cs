using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softtechDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softtechDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.softtechDataSet.customer);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string compname = companyname.Text;
            string contname = contactname.Text;
            string phn = phon.Text;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\softtech.mdf;Integrated Security=True";
            SqlConnection sqlc = new SqlConnection(connection);
            string query = "INSERT INTO customer (CompanyName,ContactName,Phone) VALUES('" + compname + "', '" + contname + "', '" + phn + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlc);
            sqlc.Open();
            int comm = sqlCommand.ExecuteNonQuery();
            if (comm > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                companyname.Text = "";
                contactname.Text = "";
                phon.Text = "";
            }
            else if(comm == 0)
            {
                MessageBox.Show("Failure! Data not inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\softtech.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM customer", sqlc);
            sqlc.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlc.Close();
            dataGridView1.DataSource = dt;
        }

        private void customer_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;   
        }

        private void order_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void submitorder_Click(object sender, EventArgs e)
        {
            string custid = customerid.Text;
            string orderdate = orddate.Text;
            string orderqty = ordqty.Text;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\softtech.mdf;Integrated Security=True";
            SqlConnection sqlc = new SqlConnection(connection);
            string query = "INSERT INTO orders (CustomerId,OrderDate,OrderQuantity) VALUES('" + custid + "', '" + orderdate + "', '" + orderqty + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlc);
            sqlc.Open();
            int comm = sqlCommand.ExecuteNonQuery();
            if (comm > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                customerid.Text = "";
                orddate.Text = "";
                ordqty.Text = "";
            }
            else if (comm == 0)
            {
                MessageBox.Show("Failure! Data not inserted");
            }
        }

        private void showorder_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\softtech.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM orders", sqlc);
            sqlc.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlc.Close();
            dataGridView2.DataSource = dt;
        }
    }
}
