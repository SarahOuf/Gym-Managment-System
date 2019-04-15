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
    public partial class AddTrainer : Form
    {
        public AddTrainer()
        {
            InitializeComponent();
        }

        private void AddTrainer_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_AddTrainer_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            int ID = Convert.ToInt16(textBoxID.Text);
            string firstname = textBox_firstname.Text.ToString();
            string lastname = textBox_lastname.Text.ToString();
            string email = textBox_email.Text.ToString();
            string gender = "";
            string contact = textBox_contact.Text.ToString();
            int GymID = Convert.ToInt16(comboBoxgymid.SelectedItem);
            string workinghour = comboBoxhours.SelectedItem.ToString();
            int salary =Convert.ToInt16(textBox_salary.Text);

            if (radioButton_male.Checked)
            {
                gender = radioButton_male.Text.ToString();
            }
            else if (radioButton_female.Checked)
            {
                gender =radioButton_female.Text.ToString();
            }
            SqlCommand cmd2 = new SqlCommand("select count(*) from Trainers where Working_Hours='"+workinghour+"' and GymID='"+GymID+"'" , con);
            int count = (int)cmd2.ExecuteScalar();
            if (count.ToString() == "1")
            {
                MessageBox.Show("There is already a trainer working at the same time in this gym hall!");
            }
            else
            {
                Trainer train = new Trainer();
                train.Add(ID, firstname, lastname, email, gender, contact, GymID);
                train.setSalary(salary);
                train.setWorkingHours(workinghour);
                SqlCommand cmd = new SqlCommand(@"insert into Trainers(Trainer_ID, Trainer_FirstName, Trainer_LastName,Trainer_Gender, Trainer_Contact , Trainer_Email, Working_hours , GymID , Salary) 
                values(@Id , @FirstName, @LastName,@gender, @Contact, @Email, @WorkingHours,@gymid, @Salary)", con);
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@WorkingHours", workinghour);
                cmd.Parameters.AddWithValue("@gymid", GymID);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trainer was added successfully!");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxhours_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
    }
}
