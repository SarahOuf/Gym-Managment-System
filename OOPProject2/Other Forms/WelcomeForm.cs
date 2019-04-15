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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button_members_Click(object sender, EventArgs e)
        {
            ManagersForm managersForm = new ManagersForm();
            managersForm.Show();
        }

        private void button_trainers_Click(object sender, EventArgs e)
        {
            TrainersForm trainersForm = new TrainersForm();
            trainersForm.Show();
        }

    }
}
