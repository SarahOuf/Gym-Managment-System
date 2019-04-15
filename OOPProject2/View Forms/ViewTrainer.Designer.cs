namespace OOPProject2
{
    partial class ViewTrainer
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
            this.label_viewtrainer = new System.Windows.Forms.Label();
            this.textBox_viewtrainer = new System.Windows.Forms.TextBox();
            this.button_viewtrainer = new System.Windows.Forms.Button();
            this.dgv_viewtrainer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewtrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_viewtrainer
            // 
            this.label_viewtrainer.AutoSize = true;
            this.label_viewtrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_viewtrainer.Location = new System.Drawing.Point(47, 75);
            this.label_viewtrainer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_viewtrainer.Name = "label_viewtrainer";
            this.label_viewtrainer.Size = new System.Drawing.Size(89, 20);
            this.label_viewtrainer.TabIndex = 0;
            this.label_viewtrainer.Text = "Trainer ID";
            // 
            // textBox_viewtrainer
            // 
            this.textBox_viewtrainer.Location = new System.Drawing.Point(231, 77);
            this.textBox_viewtrainer.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_viewtrainer.Name = "textBox_viewtrainer";
            this.textBox_viewtrainer.Size = new System.Drawing.Size(116, 20);
            this.textBox_viewtrainer.TabIndex = 1;
            // 
            // button_viewtrainer
            // 
            this.button_viewtrainer.Location = new System.Drawing.Point(428, 72);
            this.button_viewtrainer.Margin = new System.Windows.Forms.Padding(2);
            this.button_viewtrainer.Name = "button_viewtrainer";
            this.button_viewtrainer.Size = new System.Drawing.Size(74, 29);
            this.button_viewtrainer.TabIndex = 2;
            this.button_viewtrainer.Text = "View";
            this.button_viewtrainer.UseVisualStyleBackColor = true;
            this.button_viewtrainer.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_viewtrainer
            // 
            this.dgv_viewtrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viewtrainer.Location = new System.Drawing.Point(193, 176);
            this.dgv_viewtrainer.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_viewtrainer.Name = "dgv_viewtrainer";
            this.dgv_viewtrainer.RowTemplate.Height = 24;
            this.dgv_viewtrainer.Size = new System.Drawing.Size(298, 210);
            this.dgv_viewtrainer.TabIndex = 3;
            // 
            // ViewTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 455);
            this.Controls.Add(this.dgv_viewtrainer);
            this.Controls.Add(this.button_viewtrainer);
            this.Controls.Add(this.textBox_viewtrainer);
            this.Controls.Add(this.label_viewtrainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewTrainer";
            this.Load += new System.EventHandler(this.ViewTrainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewtrainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_viewtrainer;
        private System.Windows.Forms.TextBox textBox_viewtrainer;
        private System.Windows.Forms.Button button_viewtrainer;
        private System.Windows.Forms.DataGridView dgv_viewtrainer;
    }
}
