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
    public partial class RemoveMember : Form
    {
        public RemoveMember()
        {
            InitializeComponent();
        }

        private void buttonDeletememberID_Click(object sender, EventArgs e)
        {

        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            int memberid = Convert.ToInt16(textBoxmemberID.Text);
            SqlCommand cmd = new SqlCommand(@"delete from Customers where Customer_ID ='" + memberid + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The account has deleted successfully!");
        }

        private void RemoveMember_Load(object sender, EventArgs e)
            {

            }
    }
}
