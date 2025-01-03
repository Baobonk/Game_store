using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using BaoCAo.Class.Connection;
using BaoCAo.CustomForm;
using BaoCAo.Class.Component;

namespace BaoCAo
{
    public partial class Register : Form
    {
        private Connect dbconnect;
        private Login login;

        public Register()
        {
            InitializeComponent();
            dbconnect = new Connect();
        }

        public Register(Login l)
        {
            InitializeComponent();
            this.login = l;
            dbconnect = new Connect();
        }

        private void l_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void l_Login_Click(object sender, EventArgs e)
        {
            this.login.Show();
            this.Close();
        }


        private void register_btn_Click(object sender, EventArgs e)
        {
            string username = r_usernametb.Text.Trim();
            string email = r_emailtb.Text.Trim();
            string password = r_passwordtb.Text;
            string confirm = r_confirmtb.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                Name = username,
                Email = email,
                Password = password,
                Role = UserRole.customer,
                IsBanned = false
            };

            try
            {
                dbconnect.OpenConnection();
                using (SqlConnection conn = dbconnect.sqlConnection)
                {
                    string checkuser = "SELECT COUNT (*) FROM Users WHERE userName = @userName";
                    using (SqlCommand check = new SqlCommand(checkuser, conn))
                    {
                        check.Parameters.AddWithValue("@userName", username);
                        int usercount = (int)check.ExecuteScalar();
                        if (usercount > 0)
                        {
                            MessageBox.Show("This account already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                newUser.Register();

                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK);
                this.login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconnect.CloseConnection();
            }
        }

        private void r_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = r_showpassword.Checked ? '\0' : '*';
            r_passwordtb.PasswordChar = passwordChar;
            r_confirmtb.PasswordChar = passwordChar;
        }

        private void r_confirmtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register_btn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void l_Login_Hover(object sender, EventArgs e)
        {
            l_Login.ForeColor = Color.FromArgb(210, 255, 64);
        }

        private void l_Login_MouseLeave(object sender, EventArgs e)
        {
            l_Login.ForeColor = Color.Black;
        }
    }
}
