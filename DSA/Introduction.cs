﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    public partial class Introduction : Form
    {
        private Timer timer;
        private Timer buttonTimer;

        public Introduction()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            timer = new Timer();
            timer.Interval = 120000;
            timer.Tick += Timer_Tick;
            timer.Start();

            buttonTimer = new Timer();
            buttonTimer.Interval = 32000; 
            buttonTimer.Tick += ButtonTimer_Tick;
            buttonTimer.Start();

            IntroVid.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\Graphics & Animations\VID_Intro(long).mp4";

            startButton.Visible = false;
            kryptonButton1.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            Home.homeInstance = homeForm;
            homeForm.Show();
            timer.Stop();
            this.Close();
            this.Dispose();
        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
            startButton.Visible = true;
            kryptonButton1.Visible = true;

            buttonTimer.Stop();
        }

        private SoundPlayer sfx;
        private void startButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Home.homeInstance = home;
            home.Show();
            this.Close();
            this.Dispose();


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Form4 mechanics = new Form4();
            mechanics.Show();
            this.Close();
            this.Dispose();
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
