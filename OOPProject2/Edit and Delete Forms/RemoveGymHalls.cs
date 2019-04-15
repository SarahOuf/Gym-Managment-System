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
    public partial class RemoveGymHalls : Form
    {
        public RemoveGymHalls()
        {
            InitializeComponent();
        }

        private void buttonDeleteGymHalls_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            int GymHallID = Convert.ToInt16(textBoxRemoveGymHallsID.Text);
            SqlCommand cmd = new SqlCommand(@"delete from GymHalls where Hall_ID ='" + GymHallID+ "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The hall has deleted successfully!");
        }
    }
}
