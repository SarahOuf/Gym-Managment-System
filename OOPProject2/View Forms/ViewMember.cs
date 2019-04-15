using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOPProject2
{
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }


        private void getMembers(string sqlQuery)
        {
            //"select * from Customers where Customer_FirstName LIKE '%" + textBox1.Text + "%' or  Customer_LastName LIKE '%" + textBox1.Text + "%'"
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            //to get query results
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Customers = new DataTable();
            Customers.Columns.Add("Customer_ID");
            Customers.Columns.Add("Customer_FirstName");
            Customers.Columns.Add("Customer_LastName");
            Customers.Columns.Add("Customer_Contact");
            Customers.Columns.Add("Customer_Email");
            Customers.Columns.Add("Subscribtion_Date");
            Customers.Columns.Add("Trainer_ID");
            Customers.Columns.Add("CustomerHeight");
            Customers.Columns.Add("CustomerWeight");
            Customers.Columns.Add("Customer_Gender");
            Customers.Columns.Add("Exercise Plan ID");
            DataRow row;
            while (reader.Read())
            {
                row = Customers.NewRow();
                row["Customer_ID"] = reader["Customer_ID"];
                row["Customer_FirstName"] = reader["Customer_FirstName"];
                row["Customer_LastName"] = reader["Customer_LastName"];
                row["Customer_Contact"] = reader["Customer_Contact"];
                row["Customer_Email"] = reader["Customer_Email"];
                row["Subscribtion_Date"] = reader["Subscribtion_Date"];
                row["Trainer_ID"] = reader["Trainer_ID"];
                row["CustomerHeight"] = reader["CustomerHeight"];
                row["CustomerWeight"] = reader["CustomerWeight"];
                row["Customer_Gender"] = reader["Customer_Gender"];
                row["Exercise Plan ID"] = reader["ExercisePlanID"];
                Customers.Rows.Add(row);
            }
            //close the reader
            reader.Close();
            con.Close();
            //set gridview with values
            dataGridViewCustomerInfo.DataSource = Customers;
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            getMembers("select * from Customers");
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            getMembers("select * from Customers where Customer_FirstName LIKE '%" + textBox1.Text + "%' or  Customer_LastName LIKE '%" + textBox1.Text + "%'");
        }
    }
}
