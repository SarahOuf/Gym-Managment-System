using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOPProject2
{
    public partial class ViewGymHalls : Form
    {
        public ViewGymHalls()
        {
            InitializeComponent();
        }

        private void buttonViewGymHall_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from GymHalls", con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable ViewGymHalls = new DataTable();
            ViewGymHalls.Columns.Add("GymHall_ID");
            ViewGymHalls.Columns.Add("Open_Time");
            ViewGymHalls.Columns.Add("Close_Time");
            ViewGymHalls.Columns.Add("Hall_Name");
            

            DataRow row;
            while (reader.Read())
            {
                row = ViewGymHalls.NewRow();
                row["GymHall_ID"] = reader["Hall_ID"];
                row["Open_Time"] = reader["Open_Time"];
                row["Close_Time"] = reader["Close_Time"];
                row["Hall_Name"] = reader["HallName"];
                ViewGymHalls.ImportRow(row);
                ViewGymHalls.Rows.Add(row);

            }
            reader.Close();
            con.Close();
            dataGridViewGymHalls.DataSource = ViewGymHalls;
        }
    }
}
