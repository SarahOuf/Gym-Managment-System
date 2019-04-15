namespace OOPProject2
{
    partial class DeleteTrainer
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
            this.label_TrainerID = new System.Windows.Forms.Label();
            this.textBox_trainerid = new System.Windows.Forms.TextBox();
            this.button_deletetrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_TrainerID
            // 
            this.label_TrainerID.AutoSize = true;
            this.label_TrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TrainerID.Location = new System.Drawing.Point(80, 83);
            this.label_TrainerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TrainerID.Name = "label_TrainerID";
            this.label_TrainerID.Size = new System.Drawing.Size(89, 20);
            this.label_TrainerID.TabIndex = 0;
            this.label_TrainerID.Text = "Trainer ID";
            this.label_TrainerID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_trainerid
            // 
            this.textBox_trainerid.Location = new System.Drawing.Point(248, 85);
            this.textBox_trainerid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_trainerid.Name = "textBox_trainerid";
            this.textBox_trainerid.Size = new System.Drawing.Size(113, 20);
            this.textBox_trainerid.TabIndex = 1;
            // 
            // button_deletetrainer
            // 
            this.button_deletetrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletetrainer.Location = new System.Drawing.Point(177, 232);
            this.button_deletetrainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_deletetrainer.Name = "button_deletetrainer";
            this.button_deletetrainer.Size = new System.Drawing.Size(112, 52);
            this.button_deletetrainer.TabIndex = 2;
            this.button_deletetrainer.Text = "Delete";
            this.button_deletetrainer.UseVisualStyleBackColor = true;
            this.button_deletetrainer.Click += new System.EventHandler(this.button_deletetrainer_Click);
            // 
            // DeleteTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_deletetrainer);
            this.Controls.Add(this.textBox_trainerid);
            this.Controls.Add(this.label_TrainerID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteTrainer";
            this.Size = new System.Drawing.Size(518, 446);
            this.Load += new System.EventHandler(this.DeleteTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TrainerID;
        private System.Windows.Forms.TextBox textBox_trainerid;
        private System.Windows.Forms.Button button_deletetrainer;
    }
}
