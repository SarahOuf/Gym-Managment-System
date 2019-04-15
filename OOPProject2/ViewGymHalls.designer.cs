namespace OOPProject2
{
    partial class ViewGymHalls
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
            this.buttonViewGymHall = new System.Windows.Forms.Button();
            this.dataGridViewGymHalls = new System.Windows.Forms.DataGridView();
            this.labelViewAllGymHalls = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGymHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewGymHall
            // 
            this.buttonViewGymHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewGymHall.Location = new System.Drawing.Point(56, 161);
            this.buttonViewGymHall.Name = "buttonViewGymHall";
            this.buttonViewGymHall.Size = new System.Drawing.Size(75, 34);
            this.buttonViewGymHall.TabIndex = 2;
            this.buttonViewGymHall.Text = "View";
            this.buttonViewGymHall.UseVisualStyleBackColor = true;
            this.buttonViewGymHall.Click += new System.EventHandler(this.buttonViewGymHall_Click);
            // 
            // dataGridViewGymHalls
            // 
            this.dataGridViewGymHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGymHalls.Location = new System.Drawing.Point(207, 77);
            this.dataGridViewGymHalls.Name = "dataGridViewGymHalls";
            this.dataGridViewGymHalls.Size = new System.Drawing.Size(366, 256);
            this.dataGridViewGymHalls.TabIndex = 3;
            // 
            // labelViewAllGymHalls
            // 
            this.labelViewAllGymHalls.AutoSize = true;
            this.labelViewAllGymHalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewAllGymHalls.Location = new System.Drawing.Point(267, 26);
            this.labelViewAllGymHalls.Name = "labelViewAllGymHalls";
            this.labelViewAllGymHalls.Size = new System.Drawing.Size(163, 37);
            this.labelViewAllGymHalls.TabIndex = 4;
            this.labelViewAllGymHalls.Text = "GymHalls";
            // 
            // ViewGymHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 364);
            this.Controls.Add(this.labelViewAllGymHalls);
            this.Controls.Add(this.dataGridViewGymHalls);
            this.Controls.Add(this.buttonViewGymHall);
            this.Name = "ViewGymHalls";
            this.Text = "ViewGymHalls";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGymHalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewGymHall;
        private System.Windows.Forms.DataGridView dataGridViewGymHalls;
        private System.Windows.Forms.Label labelViewAllGymHalls;
    }
}