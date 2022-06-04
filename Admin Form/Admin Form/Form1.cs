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

namespace Admin_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystem1.employeee' table. You can move, or remove it, as needed.
            this.employeeeTableAdapter.Fill(this.bankSystem1.employeee);
            // TODO: This line of code loads data into the 'bankSystem.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bankSystem.employee);

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=EL-SHAAER;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO employeee (ID, name, salary) VALUES('" + Convert.ToInt32(this.textBox1.Text) + "','" + textBox2.Text.ToString() + "','" + Convert.ToInt16(this.textBox3.Text)  +"')";
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
            sqlCommand.CommandText = "update employeee set name = '"  + textBox2.Text.ToString() + "', salary ='" + Convert.ToInt16(this.textBox3.Text)+ "'Where ID ='" + Convert.ToInt32(this.textBox1.Text) + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update Done");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=EL-SHAAER;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from employeee where ID= '" + Convert.ToInt32(this.textBox1.Text) + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion Done");
        }

        private void show_Click(object sender, EventArgs e)
        {
            this.employeeeTableAdapter.Fill(this.bankSystem1.employeee);
        }
    }
}
