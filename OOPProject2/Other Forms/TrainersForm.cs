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
    public partial class TrainersForm : Form
    {
        public TrainersForm()
        {
            InitializeComponent();
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipmentForm addEqForm = new AddEquipmentForm();
            addEqForm.Show();
        }

        private void addExercisePlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddexercisePlan addexplanform = new AddexercisePlan();
            addexplanform.Show();
        }

        private void TrainersForm_Load(object sender, EventArgs e)
            {

            }

        private void removeExercisePlanToolStripMenuItem_Click(object sender, EventArgs e)
            {
            RemoveExercisePlan frm = new RemoveExercisePlan();
            frm.Show();
            }
    }
}
