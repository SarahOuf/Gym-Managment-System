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
    public partial class AddexercisePlan : Form
    {
        SqlConnection con;
        public AddexercisePlan()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            
            con.Open();
            ExercisePlan ex = new ExercisePlan();
            string eqName = comboBoxLsteq.SelectedItem.ToString();
            string duration = textBoxPlayDuration.Text.ToString();
            string steps = textBoxPlaySteps.Text.ToString();
            string exerID = textBoxexerplanID.Text.ToString();
            string exercisename = textBoxexrPlanName.Text.ToString();
            int exerciseDuration = Convert.ToInt32(textBoxexcerPlanDuration.Text);

            EquipmentExer eqex = new EquipmentExer();
            eqex.AddExerciseEq(eqName , duration , steps);
            ex.setListEq(eqex);
            List<EquipmentExer> lst = ex.getListeq();
            //dataGridViewExerciseEq.DataSource = lst;
            //this.Refresh();
            //dataGridViewExerciseEq.Refresh();
        
           SqlCommand cmd2 = new SqlCommand("select Equipment_ID from Equipments where Equipment_Name='" + eqName + "' ", con);
            int id = (int)cmd2.ExecuteScalar();
            SqlCommand cmd3 = new SqlCommand("insert into Exersice_Equipment (ExersiceID , EquipmentID , ExerciseDuration , Steps) values (@id , @eqID , @exerduration , @steps)", con);
            cmd3.Parameters.AddWithValue("@id", exerID);
            cmd3.Parameters.AddWithValue("@eqID", id);
            cmd3.Parameters.AddWithValue("@exerduration", duration);
            cmd3.Parameters.AddWithValue("steps", steps);
            cmd3.ExecuteNonQuery();
            con.Close();
               
            
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string trainID = textBoxTrainerid.Text.ToString();
            string exercisename = textBoxexrPlanName.Text.ToString();
            int exerciseDuration = Convert.ToInt32(textBoxexcerPlanDuration.Text);
            string exerID = textBoxexerplanID.Text.ToString();

            ExercisePlan ex = new ExercisePlan();
            List<EquipmentExer> lst = ex.getListeq();
            ex.AddExerPlan(exerID, exercisename , exerciseDuration , lst);

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ExersicePlans (Exersice_ID , ExerciseName , ExerciseTime) values (@exerid , @exername , @exertime)", con);
            cmd.Parameters.AddWithValue("exerid", exerID);
            cmd.Parameters.AddWithValue("exername", exercisename);
            cmd.Parameters.AddWithValue("exertime", exerciseDuration);
            cmd.ExecuteNonQuery();
            con.Close();
                
        }

        private void AddexercisePlan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            {
            this.Hide();
            }                                           
    }
}
