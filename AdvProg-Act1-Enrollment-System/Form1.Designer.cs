namespace AdvProg_Act1_Enrollment_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label8 = new Label();
            txtAge = new TextBox();
            label7 = new Label();
            dtpDOB = new DateTimePicker();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            clbSubjects = new CheckedListBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            cmbStrand = new Label();
            cmbTrack = new ComboBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            mtbContactNumber = new MaskedTextBox();
            txtContactPerson = new TextBox();
            label15 = new Label();
            label14 = new Label();
            clbAccessibility = new CheckedListBox();
            cmbBloodType = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            groupBox4 = new GroupBox();
            txtEnrollmentDetails = new TextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtMiddleName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(976, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(796, 159);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(90, 25);
            rbFemale.TabIndex = 15;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(720, 159);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(70, 25);
            rbMale.TabIndex = 14;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(632, 161);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 13;
            label8.Text = "Gender:";
            // 
            // txtAge
            // 
            txtAge.Enabled = false;
            txtAge.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(547, 152);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(55, 28);
            txtAge.TabIndex = 12;
            txtAge.TextChanged += txtAge_TextChanged;
            txtAge.VisibleChanged += txtAge_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(489, 161);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 11;
            label7.Text = "Age:";
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(143, 156);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(317, 28);
            dtpDOB.TabIndex = 10;
            dtpDOB.ValueChanged += txtAge_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(11, 161);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 9;
            label6.Text = "Date of Birth:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(143, 106);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(764, 28);
            txtAddress.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(11, 111);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 7;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(756, 67);
            label4.Name = "label4";
            label4.Size = new Size(82, 22);
            label4.TabIndex = 6;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(499, 67);
            label3.Name = "label3";
            label3.Size = new Size(96, 22);
            label3.TabIndex = 5;
            label3.Text = "Middle Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(221, 67);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(679, 34);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(228, 28);
            txtLastName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(442, 34);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(221, 28);
            txtMiddleName.TabIndex = 2;
            txtMiddleName.TextChanged += txtMiddleName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(143, 34);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 28);
            txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(11, 39);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(clbSubjects);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cmbStrand);
            groupBox2.Controls.Add(cmbTrack);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(18, 238);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(976, 212);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Academic Information";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(151, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 44);
            panel1.TabIndex = 19;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(139, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 25);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Grade 12";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(3, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 25);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Grade 11";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // clbSubjects
            // 
            clbSubjects.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSubjects.FormattingEnabled = true;
            clbSubjects.Items.AddRange(new object[] { "Oral Communication", "Earth & Life Science", "Physical Education 1", "General Mathematics", "Specialized Subjects" });
            clbSubjects.Location = new Point(501, 75);
            clbSubjects.Name = "clbSubjects";
            clbSubjects.Size = new Size(406, 119);
            clbSubjects.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(499, 43);
            label10.Name = "label10";
            label10.Size = new Size(231, 21);
            label10.TabIndex = 17;
            label10.Text = "Select Subjects to Enroll:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.Alpha;
            comboBox1.Items.AddRange(new object[] { "STEM      ", "ABM", "GAS", "HUMSS    ", "ICT            ", "EIM", "FCS" });
            comboBox1.Location = new Point(151, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 29);
            comboBox1.TabIndex = 14;
            comboBox1.VisibleChanged += cmbTrack_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(13, 155);
            label11.Name = "label11";
            label11.Size = new Size(57, 21);
            label11.TabIndex = 13;
            label11.Text = "Year:";
            // 
            // cmbStrand
            // 
            cmbStrand.AutoSize = true;
            cmbStrand.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStrand.ForeColor = SystemColors.ControlLightLight;
            cmbStrand.Location = new Point(11, 100);
            cmbStrand.Name = "cmbStrand";
            cmbStrand.Size = new Size(134, 21);
            cmbStrand.TabIndex = 12;
            cmbStrand.Text = "Select Strand:";
            // 
            // cmbTrack
            // 
            cmbTrack.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTrack.FormattingEnabled = true;
            cmbTrack.Items.AddRange(new object[] { "Academic", "TVL" });
            cmbTrack.Location = new Point(151, 40);
            cmbTrack.Name = "cmbTrack";
            cmbTrack.Size = new Size(250, 29);
            cmbTrack.TabIndex = 11;
            cmbTrack.SelectedIndexChanged += cmbTrack_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(11, 43);
            label9.Name = "label9";
            label9.Size = new Size(124, 21);
            label9.TabIndex = 10;
            label9.Text = "Select Track:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.AppWorkspace;
            groupBox3.Controls.Add(mtbContactNumber);
            groupBox3.Controls.Add(txtContactPerson);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(clbAccessibility);
            groupBox3.Controls.Add(cmbBloodType);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(18, 472);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(976, 188);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Health Information";
            // 
            // mtbContactNumber
            // 
            mtbContactNumber.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbContactNumber.Location = new Point(656, 100);
            mtbContactNumber.Mask = "+639 - 000000000";
            mtbContactNumber.Name = "mtbContactNumber";
            mtbContactNumber.Size = new Size(251, 28);
            mtbContactNumber.TabIndex = 23;
            // 
            // txtContactPerson
            // 
            txtContactPerson.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactPerson.Location = new Point(656, 40);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(251, 28);
            txtContactPerson.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(499, 100);
            label15.Name = "label15";
            label15.Size = new Size(159, 21);
            label15.TabIndex = 21;
            label15.Text = "Contact Number:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(499, 40);
            label14.Name = "label14";
            label14.Size = new Size(151, 21);
            label14.TabIndex = 20;
            label14.Text = "Contact Person:";
            // 
            // clbAccessibility
            // 
            clbAccessibility.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbAccessibility.FormattingEnabled = true;
            clbAccessibility.Items.AddRange(new object[] { "Mobility Support", "Hearing Support", "Visual Aids" });
            clbAccessibility.Location = new Point(209, 94);
            clbAccessibility.Name = "clbAccessibility";
            clbAccessibility.Size = new Size(251, 73);
            clbAccessibility.TabIndex = 19;
            // 
            // cmbBloodType
            // 
            cmbBloodType.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBloodType.FormattingEnabled = true;
            cmbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodType.Location = new Point(151, 37);
            cmbBloodType.Name = "cmbBloodType";
            cmbBloodType.Size = new Size(250, 29);
            cmbBloodType.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(13, 100);
            label13.Name = "label13";
            label13.Size = new Size(190, 21);
            label13.TabIndex = 12;
            label13.Text = "Accessibility Needs:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(13, 40);
            label12.Name = "label12";
            label12.Size = new Size(116, 21);
            label12.TabIndex = 11;
            label12.Text = "Blood Type:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlDarkDark;
            groupBox4.Controls.Add(txtEnrollmentDetails);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(1009, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(342, 645);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Enrollment Details";
            // 
            // txtEnrollmentDetails
            // 
            txtEnrollmentDetails.Location = new Point(17, 32);
            txtEnrollmentDetails.Multiline = true;
            txtEnrollmentDetails.Name = "txtEnrollmentDetails";
            txtEnrollmentDetails.ScrollBars = ScrollBars.Vertical;
            txtEnrollmentDetails.Size = new Size(304, 592);
            txtEnrollmentDetails.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.InfoText;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(619, 679);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 44);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.MenuHighlight;
            btnSubmit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ControlText;
            btnSubmit.Location = new Point(784, 679);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(141, 44);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 735);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private DateTimePicker dtpDOB;
        private Label label7;
        private Label label8;
        private TextBox txtAge;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private ComboBox cmbTrack;
        private Label label9;
        private Label label11;
        private Label cmbStrand;
        private ComboBox comboBox1;
        private Label label10;
        private CheckedListBox clbSubjects;
        private ComboBox cmbBloodType;
        private Label label13;
        private Label label12;
        private Label label15;
        private Label label14;
        private CheckedListBox clbAccessibility;
        private MaskedTextBox mtbContactNumber;
        private TextBox txtContactPerson;
        private TextBox txtEnrollmentDetails;
        private Button btnClear;
        private Button btnSubmit;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
