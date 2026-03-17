using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
           RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.ShowDialog();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();    
            studentList.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
