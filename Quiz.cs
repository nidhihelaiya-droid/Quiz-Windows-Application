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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Structure ds = new Data_Structure();
            ds.Show();
        }

        private void net_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOTNET dn = new DOTNET();
            dn.Show();
        }

        private void ada_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADA ad = new ADA();
            ad.Show();
        }

        private void AI_Click(object sender, EventArgs e)
        {
            this.Hide();
            AI a = new AI();
            a.Show();
        }

        private void DMDW_Click(object sender, EventArgs e)
        {
            this.Hide();
            DMDW dm = new DMDW();
            dm.Show();
        }

        private void CC_Click(object sender, EventArgs e)
        {
            this.Hide();
            CC c = new CC();
            c.Show();
        }
    }
}
