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
    public partial class AddBonus : Form
        {
        public AddBonus()
            {
            InitializeComponent();
            }

        private void buttonadd_Click(object sender, EventArgs e)
            {
            SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            int trainid = Convert.ToInt16(textBoxtrainid.Text);
            int bonus = Convert.ToInt16(textBoxbonus.Text);
            SqlCommand cmd = new SqlCommand("select Salary from Trainers where Trainer_ID='"+trainid+"'" , con);
            int salary = (int)cmd.ExecuteScalar();
            Trainer t = new Trainer();
            t.setSalary(salary);
            Trainer t2 = t + bonus;                      //new object from trainer carries the result of the addition op.
            SqlCommand cmd2 = new SqlCommand("update Trainers set Salary=@salary where Trainer_ID='"+trainid+"'" , con);
            cmd2.Parameters.AddWithValue("@salary" , t2.getSalary());
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Bonus Added!");
            }

        private void AddBonus_Load(object sender, EventArgs e)
            {

            }
        }
    }
