using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using BaoCAo.Class.Connection;
using BaoCAo.Class.Component;

namespace BaoCAo
{
    public partial class Login : Form
    {
        public User USN { get; private set; }
        private Connect dbConnection;

        public Login()
        {
            InitializeComponent();
            dbConnection = new Connect();
        }

        private void l_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void l_registerhere_Click(object sender, EventArgs e)
        {
            Register reg = new Register(this);
            reg.Show();
            //this.Hide();
        }




        private void L_loginbtn_Click(object sender, EventArgs e)
        {
            dbConnection.OpenConnection();
            string username = l_usernametb.Text;
            string password = l_passwordtb.Text;
            User u =  User.Login(username, password);
            if (u != null) 
            {
                Main mainForm = new Main(); 
                mainForm.u = u;
                mainForm.Show(); 
                //this.Hide(); // Hide the login form // Close the login form after main form is shown
                mainForm.FormClosed += (s, args) => this.Close();
            } 
            else 
            { 
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            dbConnection.CloseConnection();
        }

        private void l_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            l_passwordtb.PasswordChar = l_showpassword.Checked ? '\0' : '*';
        }

        private void l_passwordtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                L_loginbtn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void l_register_hover(object sender, EventArgs e)
        {
            l_registerhere.ForeColor = Color.LightGray;
        }

        private void l_registerhere_MouseLeave(object sender, EventArgs e)
        {
            l_registerhere.ForeColor = Color.Black;
        }
    }
}
