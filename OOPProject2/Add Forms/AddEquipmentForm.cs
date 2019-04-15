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
    public partial class AddEquipmentForm : Form
    {
        public AddEquipmentForm()
        {
            InitializeComponent();
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            //string NameOfEquipment = NameOfEquipmentcomboBox.SelectedItem.ToString();
            //string CategoryOfEquipment = CategtextBox2.Text.ToString();
            //string AmountOfEquipment = AmounttextBox3.Text.ToString();
            //string ID = textBoxID.Text.ToString();

            //Equipment eq = new Equipment();
            //eq.Addeq(ID, NameOfEquipment, CategoryOfEquipment, AmountOfEquipment);

            //SqlCommand cmd = new SqlCommand("insert into Equipments (Equipment_ID , Equipment_Name ,Equipment_Category , Amount) values (@ID , @Name, @Category , @Amount)" , con);
            //cmd.Parameters.AddWithValue("@ID" , ID);
            //cmd.Parameters.AddWithValue("@Name" , NameOfEquipment);
            //cmd.Parameters.AddWithValue("@Category" , CategoryOfEquipment);
            //cmd.Parameters.AddWithValue("@Amount" , AmountOfEquipment);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Equipment was added successfully!");

            try
                {
                con.Open();

                string NameOfEquipment = NameOfEquipmentcomboBox.SelectedItem.ToString();
                string CategoryOfEquipment = CategtextBox2.Text.ToString();
                string AmountOfEquipment = AmounttextBox3.Text.ToString();
                string ID = textBoxID.Text.ToString();

                Equipment eq = new Equipment();
                eq.Addeq(ID, NameOfEquipment, CategoryOfEquipment, AmountOfEquipment);

                SqlCommand cmd = new SqlCommand("insert into Equipments (Equipment_ID , Equipment_Name ,Equipment_Category , Amount) values (@ID , @Name, @Category , @Amount)", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Name", NameOfEquipment);
                cmd.Parameters.AddWithValue("@Category", CategoryOfEquipment);
                cmd.Parameters.AddWithValue("@Amount", AmountOfEquipment);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipment was added successfully!");
                }
            catch (Exception ex)
                {
                MessageBox.Show("Could not add a new equipment\n" + ex.Message);
                }
        }

        private void AddEquipmentForm_Load(object sender, EventArgs e)
            {

            }

    }
}
