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
    public partial class BeforeQA : Form
    {
        private Timer timer;

        public BeforeQA()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            timer = new Timer();
            timer.Interval = 4200;
            timer.Tick += Timer_Tick;
            timer.Start();

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
            this.Dispose();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
