namespace OOPProject2
{
    partial class RemoveExercisePlan
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
            this.textBoxDeleteExPlan = new System.Windows.Forms.TextBox();
            this.button1deleteplan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter exercise plan ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // textBoxDeleteExPlan
            // 
            this.textBoxDeleteExPlan.Location = new System.Drawing.Point(125, 116);
            this.textBoxDeleteExPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDeleteExPlan.Name = "textBoxDeleteExPlan";
            this.textBoxDeleteExPlan.Size = new System.Drawing.Size(76, 20);
            this.textBoxDeleteExPlan.TabIndex = 2;
            // 
            // button1deleteplan
            // 
            this.button1deleteplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1deleteplan.Location = new System.Drawing.Point(294, 257);
            this.button1deleteplan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1deleteplan.Name = "button1deleteplan";
            this.button1deleteplan.Size = new System.Drawing.Size(60, 28);
            this.button1deleteplan.TabIndex = 3;
            this.button1deleteplan.Text = "Delete";
            this.button1deleteplan.UseVisualStyleBackColor = true;
            this.button1deleteplan.Click += new System.EventHandler(this.button1deleteplan_Click);
            // 
            // RemoveExercisePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 336);
            this.Controls.Add(this.button1deleteplan);
            this.Controls.Add(this.textBoxDeleteExPlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveExercisePlan";
            this.Text = "RemoveExercisePlan";
            this.Load += new System.EventHandler(this.RemoveExercisePlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeleteExPlan;
        private System.Windows.Forms.Button button1deleteplan;
    }
}