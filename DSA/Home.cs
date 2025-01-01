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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            QA form8 = new QA(History.HistoryQuestions(), true, true, true, true);
            QA.myForm = form8;
            form8.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            /*Winning form8 = new Winning();
            form8.Show();
            this.Hide();*/
        }
    }
}
