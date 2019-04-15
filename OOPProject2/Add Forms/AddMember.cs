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
    public partial class AddMember : Form
    {
        SqlConnection con;
        public AddMember()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            
            //con.Open();

        Customer cust = new Customer();

            int MemID = Convert.ToInt16(textBoxid.Text);
            string firstname = textBoxFname.Text.ToString();
            string lastname = TextBoxLname.Text.ToString();
            string email = textBoxEmail.Text.ToString();
            string phone = textBoxPnum.Text.ToString();
            string gender = "";
            int weight = Convert.ToInt32(textBoxWeight.Text);
            int height = Convert.ToInt32(textBoxHeight.Text);
            string dateFrom = dateTimePickerDate.Value.ToString();
            string time = comboBoxtime.SelectedItem.ToString();
            int Hallid = Convert.ToInt16(comboBoxhallid.Text);
            int TrainID = Convert.ToInt16(comboBoxtarinid.Text);
            int exerid = Convert.ToInt16(comboBoxerxerid.Text);

            if (radioButtonMale.Checked)
            {
                gender = radioButtonMale.Text.ToString();
            }
            else if (radioButtonFemale.Checked)
            {
                gender = radioButtonFemale.Text.ToString();
            }

            //SqlCommand cmd2 = new SqlCommand("select count(*) from Customers where Trainer_ID='"+TrainID+"' and TrainingTime='"+time+"'" , con);
            //int count = (int)cmd2.ExecuteScalar();
            //if (count.ToString() == "1")
            //{
            //    MessageBox.Show("The trainer is already occupied at this time check another trainer or another time!");
            //}
            
                cust.Add(MemID, firstname, lastname, email, gender, phone , Hallid);
                cust.setHeightAndWeight(height , weight);
                cust.setSubDate(dateFrom);
                cust.setExerid(exerid);
                con.Open();
                SqlCommand cmd = new SqlCommand(@"insert into Customers (Customer_ID , Customer_FirstName , Customer_LastName , Customer_Email , Customer_Contact, Customer_Gender,CustomerWeight,CustomerHeight,Subscribtion_Date, TrainingTime , Trainer_ID , HallID , ExercisePlanID)
                values(@custid , @Firstname,@Lastname,@Email,@Phone,@Gender,@Weight,@Height,@date,@time , @trainid , @hallid , @exerid)", con);

                cmd.Parameters.AddWithValue("@custid" , MemID);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@date", dateFrom);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@trainid" , TrainID);
                cmd.Parameters.AddWithValue("@hallid" , Hallid);
                cmd.Parameters.AddWithValue("@exerid" , exerid);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Member was added successfully!");
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            //con.Open();
           /* int MemID = Convert.ToInt16(textBoxid.Text);
            string firstname = textBoxFname.Text.ToString();
            string lastname = TextBoxLname.Text.ToString();
            string email = textBoxEmail.Text.ToString();
            string phone = textBoxPnum.Text.ToString();
            string gender = "";
            int weight = Convert.ToInt32(textBoxWeight.Text);
            int height = Convert.ToInt32(textBoxHeight.Text);
            string dateFrom = dateTimePickerDate.Value.ToString(); */
           // string time = comboBoxday.SelectedItem.ToString();
           // int Hallid = Convert.ToInt16(comboBoxGymHall.Text);

           ///* if (radioButtonMale.Checked)
           // {
           //     gender = radioButtonMale.Text.ToString();
           // }
           // else if (radioButtonFemale.Checked)
           // {
           //     gender = radioButtonFemale.Text.ToString();
           // } */

           // SqlCommand cmd2 = new SqlCommand("select Trainer_ID from Trainers where GymID='" + Hallid + "' ", con);
           // SqlDataReader DR = cmd2.ExecuteReader();

           // while (DR.Read())
           // {
           //     comboBoxTrainer.Items.Add(DR[0]);

           // }

        }

        private void AddMember_Load(object sender, EventArgs e)
            {

            }

        private void comboBoxhallid_SelectedIndexChanged(object sender, EventArgs e)
            {
            
            string time = comboBoxtime.SelectedItem.ToString();
            int Hallid = Convert.ToInt16(comboBoxhallid.Text);
            SqlCommand cmd3 = new SqlCommand("select Trainer_ID from Trainers where GymID='" + Hallid + "' ", con);
            SqlDataReader DR = cmd3.ExecuteReader();

            while (DR.Read())
                {
                comboBoxtarinid.Items.Add(DR[0]);

                }
            DR.Close();
           
            con.Close();
            }

        private void comboBoxtarinid_SelectedIndexChanged(object sender, EventArgs e)
            {
            int trainid = Convert.ToInt16(comboBoxtarinid.Text);
            string time = comboBoxtime.Text.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select count(*) from Customers where Trainer_ID='" + trainid + "' and TrainingTime='" + time + "'", con);
            int count = (int)cmd2.ExecuteScalar();
            if (count.ToString() == "1")
                {
                MessageBox.Show("The trainer is already occupied at this time check another trainer or another time!");
                }
            else
                {
                SqlCommand cmd = new SqlCommand("select Exersice_ID from ExersicePlans where TrainerID='" + trainid + "'", con);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                    {
                    comboBoxerxerid.Items.Add(DR[0]);

                    }
                }
            con.Close();
                
            }

        private void comboBoxerxerid_SelectedIndexChanged(object sender, EventArgs e)
            {
                con.Open();
                int exerid = Convert.ToInt16(comboBoxerxerid.Text);
                string time = comboBoxtime.Text.ToString();
                int trainid = Convert.ToInt16(comboBoxtarinid.Text);
                SqlCommand cmd = new SqlCommand("select count(*) from Customers where Trainer_ID='" + trainid + "' and TrainingTime='" + time + "' and ExercisePlanID='" + exerid + "'", con);
                int count = (int)cmd.ExecuteScalar();
                if (count.ToString() == "1")
                    {
                       MessageBox.Show("This exercise plan is full at this time choose another!");
                    }
                con.Close();
            
                
            }
    }
}
