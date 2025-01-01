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
    public partial class Winning : Form
    {
        private bool HalfChanceVisible;
        private bool Life2xVisible;
        private bool timeFreezeVisible;
        private bool SwitchQuestionVisible;
        private Queue<Inventory> Questions;

        private int UserMoney;
        public Winning(Queue<Inventory> questions, bool halfchance, bool life2x, bool timeFreeze, bool switchQuestion)
        {
            
            HalfChanceVisible = halfchance;
            Life2xVisible = life2x;
            timeFreezeVisible = timeFreeze;
            SwitchQuestionVisible = switchQuestion;
            Questions = questions;

            InitializeComponent();
        }

        private void Winning_Load(object sender, EventArgs e)
        {
            btn_takeMoney.Parent = backgroundGif;
            currentMoneyGif.Parent = backgroundGif;
            ShowMoney(15 - Questions.Count);
        }

        public void ShowMoney(int level)
        {
            if (level == 1)
            {
                UserMoney = 1000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_1K;
            }
            else if (level == 2)
            {
                UserMoney = 3000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_3K;
            }
            else if (level == 3)
            {
                UserMoney = 5000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_5K;
            }
            else if (level == 4)
            {
                UserMoney = 10000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_10K;
            }
            else if (level == 5)
            {
                UserMoney = 20000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_20K;
            }
            else if (level == 6)
            {
                UserMoney = 35000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_35K;
            }
            else if (level == 7)
            {
                UserMoney = 50000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_50K;
            }
            else if (level == 8)
            {
                UserMoney = 70000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_70K;
            }
            else if (level == 9)
            {
                UserMoney = 100000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_100K;
            }
            else if (level == 10)
            {
                UserMoney = 150000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_150K;
            }
            else if (level == 11)
            {
                UserMoney = 250000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_250K;
            }
            else if (level == 12)
            {
                UserMoney = 400000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_400K;
            }
            else if (level == 13)
            {
                UserMoney = 600000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_600K;
            }
            else if (level == 14)
            {
                UserMoney = 1000000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_1M;
            }
            else if (level == 15) 
            {
                UserMoney = 2000000;
                currentMoneyGif.Image = Properties.Resources.GIF_NewCashPrize_2M;
            }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            QA nextQuestion = new QA(Questions, HalfChanceVisible, Life2xVisible, timeFreezeVisible, SwitchQuestionVisible);
            QA.myForm = nextQuestion;
            nextQuestion.Show();
            this.Close();
            this.Dispose();
            
        }

        private void btn_takeMoney_Click(object sender, EventArgs e)
        {
            EndScreen gameResult = new EndScreen(UserMoney);
            gameResult.Show();
            this.Close();
            this.Dispose();
        }

        
    }
}
