namespace OOPProject2
{
    partial class AddEquipmentForm
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
            this.namelabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.CategtextBox2 = new System.Windows.Forms.TextBox();
            this.AmounttextBox3 = new System.Windows.Forms.TextBox();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.NameOfEquipmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(12, 34);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(47, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = " Name:";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylabel.Location = new System.Drawing.Point(-2, 115);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(61, 13);
            this.Categorylabel.TabIndex = 1;
            this.Categorylabel.Text = "Category:";
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.Location = new System.Drawing.Point(6, 156);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(53, 13);
            this.Amountlabel.TabIndex = 2;
            this.Amountlabel.Text = "Amount:";
            // 
            // CategtextBox2
            // 
            this.CategtextBox2.Location = new System.Drawing.Point(76, 112);
            this.CategtextBox2.Name = "CategtextBox2";
            this.CategtextBox2.Size = new System.Drawing.Size(119, 20);
            this.CategtextBox2.TabIndex = 4;
            // 
            // AmounttextBox3
            // 
            this.AmounttextBox3.Location = new System.Drawing.Point(76, 153);
            this.AmounttextBox3.Name = "AmounttextBox3";
            this.AmounttextBox3.Size = new System.Drawing.Size(119, 20);
            this.AmounttextBox3.TabIndex = 5;
            // 
            // ADDbutton
            // 
            this.ADDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbutton.Location = new System.Drawing.Point(38, 199);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(205, 23);
            this.ADDbutton.TabIndex = 6;
            this.ADDbutton.Text = "ADD";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // NameOfEquipmentcomboBox
            // 
            this.NameOfEquipmentcomboBox.FormattingEnabled = true;
            this.NameOfEquipmentcomboBox.Items.AddRange(new object[] {
            "Squat Station",
            "Preacher Bench ",
            "Leg Press Machine",
            "Calf Machines",
            "Dipping Bars",
            "Rowing Machine",
            "Treadmill",
            "Leg Curl Machine",
            "Pec Deck Machine",
            "Hyper Extension Bench",
            "Barbells",
            "Incline Bench Press",
            "Exersice Bikes",
            "EZ Curl Bar",
            "Cables and Pulleys",
            "Abdominal Bench",
            "Pull Up Bar",
            "Lat Pull Down Machine",
            "Wall Balls",
            "Smith Machine"});
            this.NameOfEquipmentcomboBox.Location = new System.Drawing.Point(76, 31);
            this.NameOfEquipmentcomboBox.Name = "NameOfEquipmentcomboBox";
            this.NameOfEquipmentcomboBox.Size = new System.Drawing.Size(121, 21);
            this.NameOfEquipmentcomboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(76, 67);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // AddEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 253);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfEquipmentcomboBox);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.AmounttextBox3);
            this.Controls.Add(this.CategtextBox2);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.namelabel);
            this.Name = "AddEquipmentForm";
            this.Load += new System.EventHandler(this.AddEquipmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.TextBox CategtextBox2;
        private System.Windows.Forms.TextBox AmounttextBox3;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.ComboBox NameOfEquipmentcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
    }
}
