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
    public partial class Introduction : Form
    {
        private Timer timer;
        public Introduction()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            timer = new Timer();
            timer.Interval = 31000; 
            timer.Tick += Timer_Tick;
            timer.Start();

            IntroVid.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\Graphics & Animations\VID_Intro(long).mp4";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            Home.homeInstance = homeForm;
            homeForm.Show();
            timer.Stop();
            this.Hide();
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
