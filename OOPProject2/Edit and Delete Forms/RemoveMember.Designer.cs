namespace OOPProject2
{
    partial class RemoveMember
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
            this.labelmemberID = new System.Windows.Forms.Label();
            this.textBoxmemberID = new System.Windows.Forms.TextBox();
            this.buttonDeletememberID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelmemberID
            // 
            this.labelmemberID.AutoSize = true;
            this.labelmemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmemberID.Location = new System.Drawing.Point(23, 90);
            this.labelmemberID.Name = "labelmemberID";
            this.labelmemberID.Size = new System.Drawing.Size(124, 24);
            this.labelmemberID.TabIndex = 0;
            this.labelmemberID.Text = "Member ID: ";
            // 
            // textBoxmemberID
            // 
            this.textBoxmemberID.Location = new System.Drawing.Point(194, 95);
            this.textBoxmemberID.Name = "textBoxmemberID";
            this.textBoxmemberID.Size = new System.Drawing.Size(100, 20);
            this.textBoxmemberID.TabIndex = 1;
            // 
            // buttonDeletememberID
            // 
            this.buttonDeletememberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletememberID.Location = new System.Drawing.Point(105, 193);
            this.buttonDeletememberID.Name = "buttonDeletememberID";
            this.buttonDeletememberID.Size = new System.Drawing.Size(115, 39);
            this.buttonDeletememberID.TabIndex = 2;
            this.buttonDeletememberID.Text = "Delete";
            this.buttonDeletememberID.UseVisualStyleBackColor = true;
            this.buttonDeletememberID.Click += new System.EventHandler(this.buttonDeletememberID_Click);
            // 
            // Remove_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 289);
            this.Controls.Add(this.buttonDeletememberID);
            this.Controls.Add(this.textBoxmemberID);
            this.Controls.Add(this.labelmemberID);
            this.Name = "Remove_Member";
            this.Text = "Remove_Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmemberID;
        private System.Windows.Forms.TextBox textBoxmemberID;
        private System.Windows.Forms.Button buttonDeletememberID;
    }
}