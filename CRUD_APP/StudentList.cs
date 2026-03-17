using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_APP
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbCourse.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });
            LoadStudents();
        }

        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();
            //Create database connection 
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT * FROM students WHERE " +
                    "firstname LIKE @search " +
                    "OR lastname LIKE @search " +
                    "OR course LIKE @search " +
                    "OR section LIKE @search";
                //Create MYSQL command 
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add Parameters
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                //Declare DataAdapter for Data Table with the query results
                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                    new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                //Create a DATA Table
                System.Data.DataTable table = new System.Data.DataTable();
                //Fill Table
                adapter.Fill(table);
                dgvStudents.DataSource = table;

                //Change Column headers 
                dgvStudents.Columns["id"].HeaderText = "Student ID";
                dgvStudents.Columns["firstname"].HeaderText = "First Name";
                dgvStudents.Columns["lastname"].HeaderText = "Last Name";
                dgvStudents.Columns["course"].HeaderText = "Course";
                dgvStudents.Columns["section"].HeaderText = "Section";
                dgvStudents.Columns["age"].HeaderText = "Age";
                adapter.Dispose(); //reset value after used
                cmd.Dispose(); //rset value after used


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }

        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                //Transfer data from table to Textboxes
                txtID.Text = row.Cells["ID"].ToString();
                txtFirstName.Text = row.Cells["firstname"].ToString();
                txtLastName.Text = row.Cells["lastname"].ToString();
                cmbCourse.Text = row.Cells["course"].ToString();
                cmbSection.Text = row.Cells["section"].ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
            }
                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            int ID;
            int age;
            if (string.IsNullOrEmpty(firstname)
                || string.IsNullOrEmpty(lastname)
                || string.IsNullOrEmpty(course)
                || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all fields");
                return; // stop process
            }
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter a valid Age");
                return; // stop process
            }
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Select Record");
                return; // stop process
            }
            //Call Data Connection 
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "UPDATE students " +
                    "SET firstname=@firstname, " +
                    "lastname=@lastname, " +
                    "course=@course, " +
                    "section=@section, " +
                    "age=@age " +
                    "WHERE id=@id";
                //Create command 
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add parameters
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                cmd.Parameters.AddWithValue("@section", cmbSection.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                //Execute Command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Succesfully");
                txtID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DELETE BUTTON
            int ID;
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Select Record");
                return; // stop process
            }
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE this student", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                {
                    return; //Stop
                }
                // Create DB
                DBConnect db = new DBConnect();
                try
                {
                    db.Open();
                    string query = "UPDATE students ";
                    MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Record Delete Successfully");
                    txtID.Clear();
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAge.Clear();
                    cmbCourse.SelectedIndex = -1;
                    cmbSection.SelectedIndex = -1;
                    LoadStudents();
                }


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
