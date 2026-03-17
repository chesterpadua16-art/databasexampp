namespace CRUD_APP
{
    partial class RegisterStudent
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
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            label5 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 51);
            label1.Name = "label1";
            label1.Size = new Size(275, 21);
            label1.TabIndex = 0;
            label1.Text = "REGISTER STUDENT INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 92);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(166, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(237, 29);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(166, 124);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(237, 29);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 127);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 162);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 5;
            label4.Text = "Course:";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "ACT ", "BSOA", "HM" });
            cmbCourse.Location = new Point(166, 159);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(237, 29);
            cmbCourse.TabIndex = 6;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "1A", "1B", "1C", "1D" });
            cmbSection.Location = new Point(166, 194);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(237, 29);
            cmbSection.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 197);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 7;
            label5.Text = "Section:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(166, 229);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(237, 29);
            txtAge.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 232);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 9;
            label6.Text = "Age:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(166, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(237, 43);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 358);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(label6);
            Controls.Add(cmbSection);
            Controls.Add(label5);
            Controls.Add(cmbCourse);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            Load += RegisterStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private Label label5;
        private TextBox txtAge;
        private Label label6;
        private Button btnSave;
    }
}