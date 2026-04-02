using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Start_Quiz : Form
    {
        public Start_Quiz()
        {
            InitializeComponent();
        }

        private void startquiz_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lf = new Login();
            lf.Show();
        }

        private void Start_Quiz_Load(object sender, EventArgs e)
        {

        }
    }
}
