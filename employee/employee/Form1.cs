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

namespace employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.bankSystemDataSet.customer);
            // TODO: This line of code loads data into the 'bank_systemDataSet.customer' table. You can move, or remove it, as needed.


        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=EL-SHAAER;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO customer (SSN, name, phone_num, address) VALUES('" + Convert.ToInt32(this.textBox1.Text) + "','" + textBox2.Text.ToString() + "','" + this.textBox3.Text.ToString() + "','" + textBox4.Text.ToString() +"')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion Done");
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=EL-SHAAER;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update customer set name = '" + textBox2.Text.ToString() + "', phone_num ='"+ textBox3.Text.ToString() + "', address ='" + textBox4.Text.ToString() + "'Where SSN ='" + Convert.ToInt32(this.textBox1.Text) + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Done");

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=EL-SHAAER;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from customer where SSN= '" + Convert.ToInt32(this.textBox1.Text) + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion Done");
        }

        private void show_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter1.Fill(this.bankSystemDataSet.customer);
        }
    }
}
