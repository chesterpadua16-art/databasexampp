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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Get username and password from the textboxes
           string USERNAME= txtUsername.Text.Trim();
            string PASSWORD= txtPassword.Text.Trim();
            //check if username or password is empty
            if (USERNAME == "" || PASSWORD == "") 
            {
                MessageBox.Show("Please enter username and password");
                return; // stop login process
            }
            //Create Data Base Connection 
            DBConnect db = new DBConnect();
            try
            {
                // Open Data Base 
                db.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";

                //Create MYSQL Query
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add Parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", USERNAME);
                cmd.Parameters.AddWithValue("@password", PASSWORD);
                //Execute query and gets results number
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose(); //Release command resources
                if (count == 1)
                {
                    MessageBox.Show("Login Successful");
                    //Open Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
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
