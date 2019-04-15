namespace OOPProject2
{
    partial class WelcomeForm
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
            this.button_members = new System.Windows.Forms.Button();
            this.button_trainers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_members
            // 
            this.button_members.Location = new System.Drawing.Point(240, 30);
            this.button_members.Name = "button_members";
            this.button_members.Size = new System.Drawing.Size(94, 57);
            this.button_members.TabIndex = 0;
            this.button_members.Text = "Managers Login";
            this.button_members.UseVisualStyleBackColor = true;
            this.button_members.Click += new System.EventHandler(this.button_members_Click);
            // 
            // button_trainers
            // 
            this.button_trainers.Location = new System.Drawing.Point(446, 30);
            this.button_trainers.Name = "button_trainers";
            this.button_trainers.Size = new System.Drawing.Size(93, 57);
            this.button_trainers.TabIndex = 1;
            this.button_trainers.Text = "Trainers Login";
            this.button_trainers.UseVisualStyleBackColor = true;
            this.button_trainers.Click += new System.EventHandler(this.button_trainers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPProject2.Properties.Resources.fcis_background;
            this.pictureBox1.Location = new System.Drawing.Point(7, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_trainers);
            this.Controls.Add(this.button_members);
            this.Name = "WelcomeForm";
            this.Text = "FCIS Gym";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_members;
        private System.Windows.Forms.Button button_trainers;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}