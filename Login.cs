using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace QuizApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz q1 = new Quiz();
            q1.Show();
        }

        
        private void login_button_Click_1(object sender, EventArgs e)
        {
            login_button_Click(sender, e); // call your main method
        }

        
        

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}