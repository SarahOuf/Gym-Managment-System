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
    public partial class ViewAllTrainers : Form
    {
        private Label label1;
        private DataGridView dgv_viewalltrainers;
    
        public ViewAllTrainers()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgv_viewalltrainers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewalltrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_viewalltrainers
            // 
            this.dgv_viewalltrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viewalltrainers.Location = new System.Drawing.Point(12, 60);
            this.dgv_viewalltrainers.Name = "dgv_viewalltrainers";
            this.dgv_viewalltrainers.RowTemplate.Height = 24;
            this.dgv_viewalltrainers.Size = new System.Drawing.Size(803, 452);
            this.dgv_viewalltrainers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trainers";
            // 
            // ViewAllTrainers
            // 
            this.ClientSize = new System.Drawing.Size(827, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_viewalltrainers);
            this.Name = "ViewAllTrainers";
            this.Load += new System.EventHandler(this.ViewAllTrainers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewalltrainers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ViewAllTrainers_Load(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=SARAHOUF-PC\SQLEXPRESS;Initial Catalog=Gym_Management_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Trainers", con);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable ViewTrainers = new DataTable();
            ViewTrainers.Columns.Add("Trainer_ID");
            ViewTrainers.Columns.Add("Trainer_FirstName");
            ViewTrainers.Columns.Add("Trainer_LastName");
            ViewTrainers.Columns.Add("Trainer_Gender");
            ViewTrainers.Columns.Add("Trainer_Email");
            ViewTrainers.Columns.Add("Trainer_Contact");
            ViewTrainers.Columns.Add("Working_Hours");
            ViewTrainers.Columns.Add("GymID");
            ViewTrainers.Columns.Add("Salary");

            DataRow row;
            while (reader.Read())
            {
                row = ViewTrainers.NewRow();
                row["Trainer_ID"] = reader["Trainer_ID"];
                row["Trainer_FirstName"] = reader["Trainer_FirstName"];
                row["Trainer_LastName"] = reader["Trainer_LastName"];
                row["Trainer_Gender"] = reader["Trainer_Gender"];
                row["Trainer_Email"] = reader["Trainer_Email"];
                row["Trainer_Contact"] = reader["Trainer_Contact"];
                row["Working_Hours"] = reader["Working_Hours"];
                row["GymID"] = reader["GymID"];
                row["Salary"] = reader["Salary"];
                ViewTrainers.ImportRow(row);
                ViewTrainers.Rows.Add(row);
            }

            reader.Close();
            con.Close();
            dgv_viewalltrainers.DataSource = ViewTrainers;
        }
    }
}
