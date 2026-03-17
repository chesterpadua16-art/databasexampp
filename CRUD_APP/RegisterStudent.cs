using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname= txtFirstName.Text;
            string lastname= txtLastName.Text;
            string course= cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            int age;
            if (string.IsNullOrEmpty(firstname)
                || string.IsNullOrEmpty(lastname) 
                || string.IsNullOrEmpty(course)
                || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all fields");
                return; // stop process
            }
            if (!int.TryParse(txtAge.Text.Trim(),out age)) 
            {
                MessageBox.Show("Please enter a valid Age");
                return; // stop process
            }
            //Call Data Connection 
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "INSERT INTO student (firstname,lastname, course, section, age) " +
                    "VALUES (@firstname,@lastname,@course,@section,@age)";
                //Create MYSQL QUERY
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add Parameters
                
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@age", age);
                //Execute Command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Succesfully");
                
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;


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
    }
}
