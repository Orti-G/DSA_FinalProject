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
    public partial class Form4 : Form
    {
        private Timer timer; // Declare a Timer

        public Form4()
        {
            InitializeComponent();

            // Set up the video
            mechanicsVid.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\Graphics & Animations\VID_Mechanincs_Final.mp4";

            // Initialize buttons to be hidden initially
            btn_Start.Visible = false;
            btn_Home.Visible = false;
            btn_Restart.Visible = false;

            // Set up the Timer
            timer = new Timer();
            timer.Interval = 75000; // 75 seconds (1:15 in milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();

            // Attach event handlers to buttons
            btn_Restart.Click += Btn_Restart_Click;
            btn_Home.Click += Btn_Home_Click;
        }

        // Timer tick event handler
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Make the buttons visible
            btn_Start.Visible = true;
            btn_Home.Visible = true;
            btn_Restart.Visible = true;

            // Stop the timer since we only need it to run once
            timer.Stop();
        }

        // Restart button click event handler
        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            // Restart the video
            mechanicsVid.Ctlcontrols.stop(); // Stop the video
            mechanicsVid.Ctlcontrols.play(); // Play the video from the beginning
        }

        // Home button click event handler
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            // Navigate to the Home form
            Home homeForm = new Home();
            homeForm.Show();
            this.Close(); // Close the current form
            this.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        

        private void btn_Start_Click_1(object sender, EventArgs e)
        {
            // Navigate to the Character form
            Character characterForm = new Character();
            characterForm.Show();
            this.Close(); // Close the current form
            this.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
