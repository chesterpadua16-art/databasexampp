namespace CRUD_APP
{
    partial class Dashboard
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
            btnRegisterStudent = new Button();
            btnStudentList = new Button();
            SuspendLayout();
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.Location = new Point(216, 270);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(353, 72);
            btnRegisterStudent.TabIndex = 0;
            btnRegisterStudent.Text = "REGISTER STUDENT";
            btnRegisterStudent.UseVisualStyleBackColor = true;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // btnStudentList
            // 
            btnStudentList.Location = new Point(594, 270);
            btnStudentList.Name = "btnStudentList";
            btnStudentList.Size = new Size(353, 72);
            btnStudentList.TabIndex = 1;
            btnStudentList.Text = "STUDENT LIST";
            btnStudentList.UseVisualStyleBackColor = true;
            btnStudentList.Click += btnStudentList_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 630);
            Controls.Add(btnStudentList);
            Controls.Add(btnRegisterStudent);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterStudent;
        private Button btnStudentList;
    }
}