using ComponentFactory.Krypton.Toolkit;
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
    public partial class GrandPrize : Form
    {
        private Timer timer;
        private Timer buttonTimer;

        public GrandPrize()
        {
            InitializeComponent();
            cashPrize_Panel.Parent = pictureBoX_2MilGIF;
            timer = new Timer();
            timer.Interval = 120000;
            timer.Tick += Timer_Tick;
            timer.Start();

            buttonTimer = new Timer();
            buttonTimer.Interval = 30000;
            buttonTimer.Tick += ButtonTimer_Tick;
            buttonTimer.Start();
        }
             private void Timer_Tick(object sender, EventArgs e)
        {
           
            Home homeForm = new Home();
            Home.homeInstance = homeForm;
            homeForm.Show();
            timer.Stop();
            this.Hide();
        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
           /* startButton.Visible = true;
            kryptonButton1.Visible = true;

            buttonTimer.Stop();*/
        }

        

        private void userWinnings_Click(object sender, EventArgs e)
        {

        }
    }
}
