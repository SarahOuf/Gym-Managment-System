namespace OOPProject2
{
    partial class AddTrainer
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
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.label_WorkingHours = new System.Windows.Forms.Label();
            this.label_Salary = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.button_AddTrainer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxgymid = new System.Windows.Forms.ComboBox();
            this.comboBoxhours = new System.Windows.Forms.ComboBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.Location = new System.Drawing.Point(113, 113);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(65, 24);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "Name";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(113, 185);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(62, 24);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email";
            this.label_email.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(113, 225);
            this.label_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(80, 24);
            this.label_Gender.TabIndex = 3;
            this.label_Gender.Text = "Gender";
            this.label_Gender.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contact.Location = new System.Drawing.Point(113, 260);
            this.label_Contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(80, 24);
            this.label_Contact.TabIndex = 4;
            this.label_Contact.Text = "Contact";
            // 
            // label_WorkingHours
            // 
            this.label_WorkingHours.AutoSize = true;
            this.label_WorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WorkingHours.Location = new System.Drawing.Point(113, 341);
            this.label_WorkingHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WorkingHours.Name = "label_WorkingHours";
            this.label_WorkingHours.Size = new System.Drawing.Size(146, 24);
            this.label_WorkingHours.TabIndex = 5;
            this.label_WorkingHours.Text = "Working hours";
            // 
            // label_Salary
            // 
            this.label_Salary.AutoSize = true;
            this.label_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Salary.Location = new System.Drawing.Point(113, 377);
            this.label_Salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(67, 24);
            this.label_Salary.TabIndex = 6;
            this.label_Salary.Text = "Salary";
            this.label_Salary.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(358, 113);
            this.textBox_firstname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(152, 20);
            this.textBox_firstname.TabIndex = 7;
            this.textBox_firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(358, 185);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(152, 20);
            this.textBox_email.TabIndex = 9;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(358, 260);
            this.textBox_contact.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(152, 20);
            this.textBox_contact.TabIndex = 11;
            this.textBox_contact.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button_AddTrainer
            // 
            this.button_AddTrainer.Location = new System.Drawing.Point(233, 413);
            this.button_AddTrainer.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddTrainer.Name = "button_AddTrainer";
            this.button_AddTrainer.Size = new System.Drawing.Size(79, 32);
            this.button_AddTrainer.TabIndex = 14;
            this.button_AddTrainer.Text = "Add";
            this.button_AddTrainer.UseVisualStyleBackColor = true;
            this.button_AddTrainer.Click += new System.EventHandler(this.button_AddTrainer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add New Trainer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.Location = new System.Drawing.Point(358, 225);
            this.radioButton_male.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(58, 22);
            this.radioButton_male.TabIndex = 17;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.Location = new System.Drawing.Point(438, 225);
            this.radioButton_female.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(75, 22);
            this.radioButton_female.TabIndex = 19;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gym Hall";
            // 
            // comboBoxgymid
            // 
            this.comboBoxgymid.FormattingEnabled = true;
            this.comboBoxgymid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxgymid.Location = new System.Drawing.Point(358, 303);
            this.comboBoxgymid.Name = "comboBoxgymid";
            this.comboBoxgymid.Size = new System.Drawing.Size(152, 21);
            this.comboBoxgymid.TabIndex = 22;
            // 
            // comboBoxhours
            // 
            this.comboBoxhours.FormattingEnabled = true;
            this.comboBoxhours.Items.AddRange(new object[] {
            "8 AM - 4 PM",
            "4 PM - 12 AM"});
            this.comboBoxhours.Location = new System.Drawing.Point(358, 343);
            this.comboBoxhours.Name = "comboBoxhours";
            this.comboBoxhours.Size = new System.Drawing.Size(152, 21);
            this.comboBoxhours.TabIndex = 23;
            this.comboBoxhours.SelectedIndexChanged += new System.EventHandler(this.comboBoxhours_SelectedIndexChanged);
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(358, 381);
            this.textBox_salary.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(152, 20);
            this.textBox_salary.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Trainer ID: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(358, 88);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(152, 20);
            this.textBoxID.TabIndex = 25;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(358, 149);
            this.textBox_lastname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(152, 20);
            this.textBox_lastname.TabIndex = 8;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.Location = new System.Drawing.Point(113, 149);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(102, 24);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "LastName";
            // 
            // AddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 442);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxhours);
            this.Controls.Add(this.comboBoxgymid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddTrainer);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.label_Salary);
            this.Controls.Add(this.label_WorkingHours);
            this.Controls.Add(this.label_Contact);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTrainer";
            this.Load += new System.EventHandler(this.AddTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Contact;
        private System.Windows.Forms.Label label_WorkingHours;
        private System.Windows.Forms.Label label_Salary;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Button button_AddTrainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxgymid;
        private System.Windows.Forms.ComboBox comboBoxhours;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label label_LastName;

    }
}
