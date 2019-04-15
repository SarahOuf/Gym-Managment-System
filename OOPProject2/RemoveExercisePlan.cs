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
    public partial class RemoveExercisePlan : Form
    {
        public RemoveExercisePlan()
        {
            InitializeComponent();
        }

        private void button1deleteplan_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            int exerciseplan = Convert.ToInt16(textBoxDeleteExPlan.Text);
            SqlCommand cmd2 = new SqlCommand(@"delete from Exersice_Equipment where ExersiceID ='" + exerciseplan + "'" , con);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand(@"delete from ExersicePlans where Exersice_ID ='" + exerciseplan + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The exercise plan has deleted successfully!");
        }

        private void RemoveExercisePlan_Load(object sender, EventArgs e)
            {

            }
    }
}
