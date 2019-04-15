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
    public partial class DeleteTrainer : Form
    {
        public DeleteTrainer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_deletetrainer_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            int trainid = Convert.ToInt16(textBox_trainerid.Text);
            SqlCommand cmd = new SqlCommand(@"delete from Trainers where Trainer_ID ='" + trainid + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The account has deleted successfully!");

        }

        private void DeleteTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
