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
    public partial class ViewTrainer : Form
    {
        public ViewTrainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            int trainid = Convert.ToInt16(textBox_viewtrainer.Text);
            
            SqlCommand cmd = new SqlCommand("select * from Trainers where Trainer_ID ='" + trainid + "'", con);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable ViewTrainers = new DataTable();
            ViewTrainers.Columns.Add("Trainer_ID");
            ViewTrainers.Columns.Add("Trainer_FirstName");
            ViewTrainers.Columns.Add("Trainer_LastName");
            ViewTrainers.Columns.Add("Trainer_Gender");
            ViewTrainers.Columns.Add("Trainer_Email");
            ViewTrainers.Columns.Add("Trainer_Contact");
            ViewTrainers.Columns.Add("Working_Hours");
            ViewTrainers.Columns.Add("GymID");
            ViewTrainers.Columns.Add("Salary");

            DataRow row;
            while (reader.Read())
                {
                row = ViewTrainers.NewRow();
                row["Trainer_ID"] = reader["Trainer_ID"];
                row["Trainer_FirstName"] = reader["Trainer_FirstName"];
                row["Trainer_LastName"] = reader["Trainer_LastName"];
                row["Trainer_Gender"] = reader["Trainer_Gender"];
                row["Trainer_Email"] = reader["Trainer_Email"];
                row["Trainer_Contact"] = reader["Trainer_Contact"];
                row["Working_Hours"] = reader["Working_Hours"];
                row["GymID"] = reader["GymID"];
                row["Salary"] = reader["Salary"];
                ViewTrainers.ImportRow(row);
                ViewTrainers.Rows.Add(row);
                }

            reader.Close();
            con.Close();

                dgv_viewtrainer.DataSource = ViewTrainers;

        }

        private void ViewTrainer_Load(object sender, EventArgs e)
        {

        }

        }
    }

