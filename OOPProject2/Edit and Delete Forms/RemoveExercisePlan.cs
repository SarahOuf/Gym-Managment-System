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
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            int exerciseplan = Convert.ToInt16(textBoxDeleteExPlan.Text);
            SqlCommand cmd = new SqlCommand(@"delete from Exercise Plan where Exercise_ID ='" + exerciseplan + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The exercise plan has deleted successfully!");
        }
    }
}
