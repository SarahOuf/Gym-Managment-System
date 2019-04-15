namespace OOPProject2
{
    partial class TrainersForm
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
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercisePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExercisePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeExercisePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipmentToolStripMenuItem,
            this.exercisePlanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEquipmentToolStripMenuItem});
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            // 
            // addEquipmentToolStripMenuItem
            // 
            this.addEquipmentToolStripMenuItem.Name = "addEquipmentToolStripMenuItem";
            this.addEquipmentToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addEquipmentToolStripMenuItem.Text = "Add Equipment";
            this.addEquipmentToolStripMenuItem.Click += new System.EventHandler(this.addEquipmentToolStripMenuItem_Click);
            // 
            // exercisePlanToolStripMenuItem
            // 
            this.exercisePlanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExercisePlanToolStripMenuItem,
            this.removeExercisePlanToolStripMenuItem});
            this.exercisePlanToolStripMenuItem.Name = "exercisePlanToolStripMenuItem";
            this.exercisePlanToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.exercisePlanToolStripMenuItem.Text = "Exercise Plans";
            // 
            // addExercisePlanToolStripMenuItem
            // 
            this.addExercisePlanToolStripMenuItem.Name = "addExercisePlanToolStripMenuItem";
            this.addExercisePlanToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addExercisePlanToolStripMenuItem.Text = "Add Exercise Plan";
            this.addExercisePlanToolStripMenuItem.Click += new System.EventHandler(this.addExercisePlanToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPProject2.Properties.Resources.trainer1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // removeExercisePlanToolStripMenuItem
            // 
            this.removeExercisePlanToolStripMenuItem.Name = "removeExercisePlanToolStripMenuItem";
            this.removeExercisePlanToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.removeExercisePlanToolStripMenuItem.Text = "Remove Exercise Plan";
            this.removeExercisePlanToolStripMenuItem.Click += new System.EventHandler(this.removeExercisePlanToolStripMenuItem_Click);
            // 
            // TrainersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrainersForm";
            this.Text = "Trainers";
            this.Load += new System.EventHandler(this.TrainersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercisePlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExercisePlanToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem removeExercisePlanToolStripMenuItem;
    }
}