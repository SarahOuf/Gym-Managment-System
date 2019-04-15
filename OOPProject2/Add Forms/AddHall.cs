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
    public partial class AddHall : Form
    {
        public AddHall()
        {
            InitializeComponent();
        }

        private void ADDOfGymHallsbutton_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();


            string NameOfGymHall = NameOfGymHalltextBox.Text.ToString();
            int IDOfGymHall = Convert.ToInt16(IDOfGymHalltextBox.Text);
           

            GymHalls GYMHALL = new GymHalls();
            GYMHALL.AddHall(NameOfGymHall,IDOfGymHall);

            SqlCommand command = new SqlCommand("insert into GymHalls(Hall_ID, HallName) values (@id , @name) " , con);
            command.Parameters.AddWithValue("@name", NameOfGymHall);
            command.Parameters.AddWithValue("@id", IDOfGymHall);
            command.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Hall was added successfully!");
       
        }

        private void AddHall_Load(object sender, EventArgs e)
            {

            }
    }
}
