namespace CRUD_APP
{
    partial class StudentList
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
            dgvStudents = new DataGridView();
            label1 = new Label();
            btnRefresh = new Button();
            btnSave = new Button();
            txtAge = new TextBox();
            label6 = new Label();
            cmbSection = new ComboBox();
            label5 = new Label();
            cmbCourse = new ComboBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            label8 = new Label();
            button1 = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(68, 153);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.Size = new Size(636, 364);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellClick += dgvStudents_CellClick;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 69);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 1;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(585, 59);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 37);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(854, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(237, 43);
            btnSave.TabIndex = 23;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(854, 280);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(237, 29);
            txtAge.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(804, 283);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 21;
            label6.Text = "Age:";
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(854, 245);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(237, 29);
            cmbSection.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(777, 248);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 19;
            label5.Text = "Section:";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(854, 210);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(237, 29);
            cmbCourse.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(777, 213);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 17;
            label4.Text = "Course:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(854, 175);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(237, 29);
            txtLastName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(752, 178);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 15;
            label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(854, 140);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(237, 29);
            txtFirstName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(752, 143);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 13;
            label2.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(794, 59);
            label7.Name = "label7";
            label7.Size = new Size(265, 21);
            label7.TabIndex = 12;
            label7.Text = "UPDATE STUDENT INFORMATION";
            // 
            // txtID
            // 
            txtID.Location = new Point(854, 102);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(237, 29);
            txtID.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(815, 105);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 24;
            label8.Text = "ID:";
            // 
            // button1
            // 
            button1.Location = new Point(854, 364);
            button1.Name = "button1";
            button1.Size = new Size(237, 43);
            button1.TabIndex = 26;
            button1.Text = "DELETE RECORD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(68, 118);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(237, 29);
            txtSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(311, 113);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 37);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 578);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(txtID);
            Controls.Add(label8);
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
            Controls.Add(label7);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "StudentList";
            Text = "StudentList";
            Load += StudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Label label1;
        private Button btnRefresh;
        private Button btnSave;
        private TextBox txtAge;
        private Label label6;
        private ComboBox cmbSection;
        private Label label5;
        private ComboBox cmbCourse;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private Label label7;
        private TextBox txtID;
        private Label label8;
        private Button button1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}