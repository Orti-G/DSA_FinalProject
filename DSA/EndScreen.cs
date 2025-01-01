using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    public partial class EndScreen : Form
    {
        private int UserTotalMoney;
        public EndScreen(int userTotalMoney)
        {
            InitializeComponent();
            UserTotalMoney = userTotalMoney;
        }
        private void EndScreen_Load(object sender, EventArgs e)
        {
            showCaseMoney();
        }

        private void showCaseMoney() 
        {
            if (UserTotalMoney == 1000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_1K;
            }
            else if (UserTotalMoney == 3000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_3K;
            }
            else if (UserTotalMoney == 5000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_5K;
            }
            else if (UserTotalMoney == 10000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_10K;
            }
            else if (UserTotalMoney == 20000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_20K;
            }
            else if (UserTotalMoney == 35000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_35K;
            }
            else if (UserTotalMoney == 50000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_50K;
            }
            else if (UserTotalMoney == 70000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_70K;
            }
            else if (UserTotalMoney == 100000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_100K;
            }
            else if (UserTotalMoney == 150000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_150K;
            }
            else if (UserTotalMoney == 250000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_250K;
            }
            else if (UserTotalMoney == 400000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_400K;
            }
            else if (UserTotalMoney == 600000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_600K;
            }
            else if (UserTotalMoney == 1000000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_1M;
            }
            else if (UserTotalMoney == 2000000)
            {
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_2M;
            }
            else 
            {
                userWinnings.Image = null;
            }
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
