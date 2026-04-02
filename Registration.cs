using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace QuizApp
{
    public partial class Registration : Form
    {
        

        public Registration()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
            cpass.PasswordChar = '*';
        }
        private void signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = emailtxt.Text.Trim();
            string password = pass.Text.Trim();
            string confirmPassword = cpass.Text.Trim();

            // Validation
            if (name == "" || username == "" || email == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

           


               

                MessageBox.Show("Registration Successful!");
                this.Hide();
                new Login().Show();
            }
         
       
       
        
    }
}