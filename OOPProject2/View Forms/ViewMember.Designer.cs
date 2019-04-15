namespace OOPProject2
{
    partial class ViewMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.dataGridViewCustomerInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for a Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "First or Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(409, 91);
            this.buttonView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(94, 27);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "Search";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dataGridViewCustomerInfo
            // 
            this.dataGridViewCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerInfo.Location = new System.Drawing.Point(11, 122);
            this.dataGridViewCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomerInfo.Name = "dataGridViewCustomerInfo";
            this.dataGridViewCustomerInfo.RowTemplate.Height = 24;
            this.dataGridViewCustomerInfo.Size = new System.Drawing.Size(738, 243);
            this.dataGridViewCustomerInfo.TabIndex = 4;
            // 
            // ViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 376);
            this.Controls.Add(this.dataGridViewCustomerInfo);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewMember";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DataGridView dataGridViewCustomerInfo;
    }
}
