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
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            Home.homeInstance = homeForm;
            homeForm.Show();
            timer.Stop();
            this.Hide();
        }

        private void IntroPlayer_Enter(object sender, EventArgs e)
        {
            //IntroPlayer.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\Graphics & Animations\Try_Intro.mp4";
        }

        private void IntroPlayer_Enter_1(object sender, EventArgs e)
        {
            //IntroPlayer.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\Graphics & Animations\Try_Intro.mp4";
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }

        private void IntroPlayer_Enter_2(object sender, EventArgs e)
        {
            IntroPlayer.URL = @"C:\Users\ortig\Downloads\Try_Intro.mp4";
        }
    }
}
