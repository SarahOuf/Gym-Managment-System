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
    public partial class EditMemberForm : Form
    {
        public EditMemberForm()
        {
            InitializeComponent();
        }

        private void UpdateMembers_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customers where Customer_ID =' " + textBoxmemid.Text + "'", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBoxfname.Text = (reader["Customer_FirstName"].ToString());
                    textBoxlname.Text = (reader["Customer_LastName"].ToString());
                    textBoxphone.Text = (reader["Customer_Contact"].ToString());
                    textBoxemail.Text = (reader["Customer_Email"].ToString());
                    textBoxsubdate.Text = (reader["Subscribtion_Date"].ToString());
                    textBoxtrainid.Text = (reader["Trainer_ID"].ToString());
                    textBoxheight.Text = (reader["CustomerHeight"].ToString());
                    textBoxweight.Text = (reader["CustomerWeight"].ToString());
                    textBoxgender.Text = (reader["Customer_Gender"].ToString());
                    textBoxTrainigtime.Text = (reader["TrainingTime"].ToString());
                    textBoxhall.Text = (reader["HallID"].ToString());
                    textBoxexerplan.Text = (reader["ExercisePlanID"].ToString());
                }
            }

            con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            int memid = Convert.ToInt16(textBoxmemid.Text);
            string firstname = textBoxfname.Text.ToString();
            string lastname = textBoxlname.Text.ToString();
            string phone = textBoxphone.Text.ToString();
            string email = textBoxemail.Text.ToString();
            string subdate = textBoxsubdate.Text.ToString();
            int trainid = Convert.ToInt16(textBoxtrainid.Text);
            int height = Convert.ToInt16(textBoxheight.Text);
            int weight = Convert.ToInt16(textBoxweight.Text);
            string gender = textBoxgender.Text.ToString();
            string time = textBoxTrainigtime.Text.ToString();
            int Hallid = Convert.ToInt16(textBoxhall.Text);
            int TrainID = Convert.ToInt16(textBoxtrainid.Text);
            int exerid = Convert.ToInt16(textBoxexerplan.Text);

            SqlCommand cmd = new SqlCommand(@"update Customers set Customer_FirstName = @firstName , Customer_LastName = @lastName , 
            Customer_Contact = @contact , Customer_Email = @email  , Subscribtion_Date = @subDate , Trainer_ID = @trainerID , CustomerHeight = @height , 
            CustomerWeight = @weight , Customer_Gender = @gender,TrainingTime=@time ,  HallID=@hallid , ExercisePlanID=@exerid where Customer_ID='"+memid+"'", con);
            cmd.Parameters.AddWithValue("@firstName", firstname);
            cmd.Parameters.AddWithValue("@lastName", lastname);
            cmd.Parameters.AddWithValue("@contact", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@subDate", subdate);
            cmd.Parameters.AddWithValue("TrainerID", trainid);
            cmd.Parameters.AddWithValue("height", height);
            cmd.Parameters.AddWithValue("weight", weight);
            cmd.Parameters.AddWithValue("gender", gender);
            cmd.Parameters.AddWithValue("@time" , time);
            cmd.Parameters.AddWithValue("@hallid" , Hallid);
            cmd.Parameters.AddWithValue("@exerid" , exerid);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your account was updated successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            int memid = Convert.ToInt16(textBoxmemid.Text);
            SqlCommand cmd = new SqlCommand("delete from Customers where Customer_ID ='" + memid + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("The account has been deleted successfully!");
        }

    } }
     