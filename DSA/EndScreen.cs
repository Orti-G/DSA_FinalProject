using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void label_userName_Click(object sender, EventArgs e)
        {
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            Leaderboard myForm = new Leaderboard();
            myForm.Show();
            this.Hide();
        }
    }
}
