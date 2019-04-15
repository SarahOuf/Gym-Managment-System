using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject2
{
    public partial class ManagersForm : Form
    {
        public ManagersForm()
        {
            InitializeComponent();
        }

        // Members:
        // ========

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember addMemberForm = new AddMember();
            addMemberForm.Show();
        }

        private void editMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMemberForm editMember = new EditMemberForm();
            editMember.Show();
        }

        private void viewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMember viewMemberForm = new ViewMember();
            viewMemberForm.Show();
        }

        
        // Trainers:
        // =========
        private void addTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTrainer addTrainerForm = new AddTrainer();
            addTrainerForm.Show();
        }


        private void viewTrainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllTrainers viewAllTrainersForm = new ViewAllTrainers();
            viewAllTrainersForm.Show();
        }


        private void removeTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTrainer deleteTrainerForm = new DeleteTrainer();
            deleteTrainerForm.Show();
        }



        // Gym Halls:
        // ==========
        private void addGymHallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHall addHallForm = new AddHall();
            addHallForm.Show();
        }

        private void ManagersForm_Load(object sender, EventArgs e)
            {

            }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

        private void viewTrainerToolStripMenuItem_Click(object sender, EventArgs e)
            {
            ViewTrainer frm = new ViewTrainer();
            frm.Show();
            }

        private void addBonusToolStripMenuItem_Click(object sender, EventArgs e)
            {
            AddBonus frm = new AddBonus();
            frm.Show();
            }

        private void viewGymHallsToolStripMenuItem_Click(object sender, EventArgs e)
            {
            ViewGymHalls frm = new ViewGymHalls();
            frm.Show();
            }

        private void removeGymHallToolStripMenuItem_Click(object sender, EventArgs e)
            {
            RemoveGymHalls frm = new RemoveGymHalls();
            frm.Show();
            }

    }
}
