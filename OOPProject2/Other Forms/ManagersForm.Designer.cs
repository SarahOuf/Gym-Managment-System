namespace OOPProject2
{
    partial class ManagersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBonusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gymHallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGymHallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGymHallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeGymHallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.trainersToolStripMenuItem,
            this.gymHallsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.editMemberToolStripMenuItem,
            this.viewMemberToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // editMemberToolStripMenuItem
            // 
            this.editMemberToolStripMenuItem.Name = "editMemberToolStripMenuItem";
            this.editMemberToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editMemberToolStripMenuItem.Text = "Edit Member";
            this.editMemberToolStripMenuItem.Click += new System.EventHandler(this.editMemberToolStripMenuItem_Click);
            // 
            // viewMemberToolStripMenuItem
            // 
            this.viewMemberToolStripMenuItem.Name = "viewMemberToolStripMenuItem";
            this.viewMemberToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewMemberToolStripMenuItem.Text = "View Member";
            this.viewMemberToolStripMenuItem.Click += new System.EventHandler(this.viewMemberToolStripMenuItem_Click);
            // 
            // trainersToolStripMenuItem
            // 
            this.trainersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainerToolStripMenuItem,
            this.viewTrainersToolStripMenuItem,
            this.removeTrainerToolStripMenuItem,
            this.viewTrainerToolStripMenuItem,
            this.addBonusToolStripMenuItem});
            this.trainersToolStripMenuItem.Name = "trainersToolStripMenuItem";
            this.trainersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.trainersToolStripMenuItem.Text = "Trainers";
            // 
            // addTrainerToolStripMenuItem
            // 
            this.addTrainerToolStripMenuItem.Name = "addTrainerToolStripMenuItem";
            this.addTrainerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addTrainerToolStripMenuItem.Text = "Add Trainer";
            this.addTrainerToolStripMenuItem.Click += new System.EventHandler(this.addTrainerToolStripMenuItem_Click);
            // 
            // viewTrainersToolStripMenuItem
            // 
            this.viewTrainersToolStripMenuItem.Name = "viewTrainersToolStripMenuItem";
            this.viewTrainersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewTrainersToolStripMenuItem.Text = "View Trainers";
            this.viewTrainersToolStripMenuItem.Click += new System.EventHandler(this.viewTrainersToolStripMenuItem_Click);
            // 
            // removeTrainerToolStripMenuItem
            // 
            this.removeTrainerToolStripMenuItem.Name = "removeTrainerToolStripMenuItem";
            this.removeTrainerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.removeTrainerToolStripMenuItem.Text = "Remove Trainer";
            this.removeTrainerToolStripMenuItem.Click += new System.EventHandler(this.removeTrainerToolStripMenuItem_Click);
            // 
            // viewTrainerToolStripMenuItem
            // 
            this.viewTrainerToolStripMenuItem.Name = "viewTrainerToolStripMenuItem";
            this.viewTrainerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewTrainerToolStripMenuItem.Text = "View Trainer";
            this.viewTrainerToolStripMenuItem.Click += new System.EventHandler(this.viewTrainerToolStripMenuItem_Click);
            // 
            // addBonusToolStripMenuItem
            // 
            this.addBonusToolStripMenuItem.Name = "addBonusToolStripMenuItem";
            this.addBonusToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addBonusToolStripMenuItem.Text = "Add Bonus";
            this.addBonusToolStripMenuItem.Click += new System.EventHandler(this.addBonusToolStripMenuItem_Click);
            // 
            // gymHallsToolStripMenuItem
            // 
            this.gymHallsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGymHallToolStripMenuItem,
            this.viewGymHallsToolStripMenuItem,
            this.removeGymHallToolStripMenuItem});
            this.gymHallsToolStripMenuItem.Name = "gymHallsToolStripMenuItem";
            this.gymHallsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.gymHallsToolStripMenuItem.Text = "Gym Halls";
            // 
            // addGymHallToolStripMenuItem
            // 
            this.addGymHallToolStripMenuItem.Name = "addGymHallToolStripMenuItem";
            this.addGymHallToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addGymHallToolStripMenuItem.Text = "Add Gym Hall";
            this.addGymHallToolStripMenuItem.Click += new System.EventHandler(this.addGymHallToolStripMenuItem_Click);
            // 
            // viewGymHallsToolStripMenuItem
            // 
            this.viewGymHallsToolStripMenuItem.Name = "viewGymHallsToolStripMenuItem";
            this.viewGymHallsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewGymHallsToolStripMenuItem.Text = "View Gym Halls";
            this.viewGymHallsToolStripMenuItem.Click += new System.EventHandler(this.viewGymHallsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 367);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to FCIS Gym";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPProject2.Properties.Resources.GYM_Russia_Sibera;
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // removeGymHallToolStripMenuItem
            // 
            this.removeGymHallToolStripMenuItem.Name = "removeGymHallToolStripMenuItem";
            this.removeGymHallToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.removeGymHallToolStripMenuItem.Text = "Remove Gym Hall";
            this.removeGymHallToolStripMenuItem.Click += new System.EventHandler(this.removeGymHallToolStripMenuItem_Click);
            // 
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagersForm";
            this.Text = "Managers";
            this.Load += new System.EventHandler(this.ManagersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gymHallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGymHallToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem removeTrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMemberToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewTrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBonusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGymHallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGymHallToolStripMenuItem;
    }
}

