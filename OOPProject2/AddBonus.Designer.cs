namespace OOPProject2
    {
    partial class AddBonus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxtrainid = new System.Windows.Forms.TextBox();
            this.textBoxbonus = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainer ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bonus: ";
            // 
            // textBoxtrainid
            // 
            this.textBoxtrainid.Location = new System.Drawing.Point(245, 112);
            this.textBoxtrainid.Name = "textBoxtrainid";
            this.textBoxtrainid.Size = new System.Drawing.Size(100, 20);
            this.textBoxtrainid.TabIndex = 2;
            // 
            // textBoxbonus
            // 
            this.textBoxbonus.Location = new System.Drawing.Point(245, 162);
            this.textBoxbonus.Name = "textBoxbonus";
            this.textBoxbonus.Size = new System.Drawing.Size(100, 20);
            this.textBoxbonus.TabIndex = 3;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(245, 255);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 4;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // AddBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 355);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxbonus);
            this.Controls.Add(this.textBoxtrainid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBonus";
            this.Text = "AddBonus";
            this.Load += new System.EventHandler(this.AddBonus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxtrainid;
        private System.Windows.Forms.TextBox textBoxbonus;
        private System.Windows.Forms.Button buttonadd;
        }
    }