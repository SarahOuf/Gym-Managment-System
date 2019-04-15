namespace OOPProject2
{
    partial class AddHall
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gymhallnamelabel = new System.Windows.Forms.Label();
            this.GymHallIDlabel = new System.Windows.Forms.Label();
            this.NameOfGymHalltextBox = new System.Windows.Forms.TextBox();
            this.IDOfGymHalltextBox = new System.Windows.Forms.TextBox();
            this.ADDOfGymHallsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gymhallnamelabel
            // 
            this.gymhallnamelabel.AutoSize = true;
            this.gymhallnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymhallnamelabel.Location = new System.Drawing.Point(101, 116);
            this.gymhallnamelabel.Name = "gymhallnamelabel";
            this.gymhallnamelabel.Size = new System.Drawing.Size(43, 13);
            this.gymhallnamelabel.TabIndex = 0;
            this.gymhallnamelabel.Text = "Name:";
            // 
            // GymHallIDlabel
            // 
            this.GymHallIDlabel.AutoSize = true;
            this.GymHallIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GymHallIDlabel.Location = new System.Drawing.Point(120, 168);
            this.GymHallIDlabel.Name = "GymHallIDlabel";
            this.GymHallIDlabel.Size = new System.Drawing.Size(24, 13);
            this.GymHallIDlabel.TabIndex = 1;
            this.GymHallIDlabel.Text = "ID:";
            // 
            // NameOfGymHalltextBox
            // 
            this.NameOfGymHalltextBox.Location = new System.Drawing.Point(150, 113);
            this.NameOfGymHalltextBox.Name = "NameOfGymHalltextBox";
            this.NameOfGymHalltextBox.Size = new System.Drawing.Size(100, 20);
            this.NameOfGymHalltextBox.TabIndex = 4;
            // 
            // IDOfGymHalltextBox
            // 
            this.IDOfGymHalltextBox.Location = new System.Drawing.Point(150, 165);
            this.IDOfGymHalltextBox.Name = "IDOfGymHalltextBox";
            this.IDOfGymHalltextBox.Size = new System.Drawing.Size(100, 20);
            this.IDOfGymHalltextBox.TabIndex = 5;
            // 
            // ADDOfGymHallsbutton
            // 
            this.ADDOfGymHallsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDOfGymHallsbutton.Location = new System.Drawing.Point(150, 201);
            this.ADDOfGymHallsbutton.Name = "ADDOfGymHallsbutton";
            this.ADDOfGymHallsbutton.Size = new System.Drawing.Size(100, 23);
            this.ADDOfGymHallsbutton.TabIndex = 8;
            this.ADDOfGymHallsbutton.Text = "ADD";
            this.ADDOfGymHallsbutton.UseVisualStyleBackColor = true;
            this.ADDOfGymHallsbutton.Click += new System.EventHandler(this.ADDOfGymHallsbutton_Click);
            // 
            // AddHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 367);
            this.Controls.Add(this.ADDOfGymHallsbutton);
            this.Controls.Add(this.IDOfGymHalltextBox);
            this.Controls.Add(this.NameOfGymHalltextBox);
            this.Controls.Add(this.GymHallIDlabel);
            this.Controls.Add(this.gymhallnamelabel);
            this.Name = "AddHall";
            this.Load += new System.EventHandler(this.AddHall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gymhallnamelabel;
        private System.Windows.Forms.Label GymHallIDlabel;
        private System.Windows.Forms.TextBox NameOfGymHalltextBox;
        private System.Windows.Forms.TextBox IDOfGymHalltextBox;
        private System.Windows.Forms.Button ADDOfGymHallsbutton;
    }
}
