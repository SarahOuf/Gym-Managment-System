namespace OOPProject2
{
    partial class RemoveGymHalls
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
            this.labelRemoveGymHall = new System.Windows.Forms.Label();
            this.textBoxRemoveGymHallsID = new System.Windows.Forms.TextBox();
            this.buttonDeleteGymHalls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRemoveGymHall
            // 
            this.labelRemoveGymHall.AutoSize = true;
            this.labelRemoveGymHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveGymHall.Location = new System.Drawing.Point(12, 88);
            this.labelRemoveGymHall.Name = "labelRemoveGymHall";
            this.labelRemoveGymHall.Size = new System.Drawing.Size(150, 25);
            this.labelRemoveGymHall.TabIndex = 0;
            this.labelRemoveGymHall.Text = "Gym Hall ID: ";
            // 
            // textBoxRemoveGymHallsID
            // 
            this.textBoxRemoveGymHallsID.Location = new System.Drawing.Point(231, 93);
            this.textBoxRemoveGymHallsID.Name = "textBoxRemoveGymHallsID";
            this.textBoxRemoveGymHallsID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemoveGymHallsID.TabIndex = 1;
            // 
            // buttonDeleteGymHalls
            // 
            this.buttonDeleteGymHalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteGymHalls.Location = new System.Drawing.Point(117, 217);
            this.buttonDeleteGymHalls.Name = "buttonDeleteGymHalls";
            this.buttonDeleteGymHalls.Size = new System.Drawing.Size(130, 38);
            this.buttonDeleteGymHalls.TabIndex = 2;
            this.buttonDeleteGymHalls.Text = "Delete";
            this.buttonDeleteGymHalls.UseVisualStyleBackColor = true;
            this.buttonDeleteGymHalls.Click += new System.EventHandler(this.buttonDeleteGymHalls_Click);
            // 
            // RemoveGymHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 316);
            this.Controls.Add(this.buttonDeleteGymHalls);
            this.Controls.Add(this.textBoxRemoveGymHallsID);
            this.Controls.Add(this.labelRemoveGymHall);
            this.Name = "RemoveGymHalls";
            this.Text = "RemoveGymHalls";
            this.Load += new System.EventHandler(this.RemoveGymHalls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRemoveGymHall;
        private System.Windows.Forms.TextBox textBoxRemoveGymHallsID;
        private System.Windows.Forms.Button buttonDeleteGymHalls;
    }
}