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
        private async Task LoadDataAsync()
        {

            await Task.Delay(3000);

        }
        private async void EndScreen_Load(object sender, EventArgs e)
        {
            PlayerCard.PlayerDescription.AddLast(UserTotalMoney.ToString());
            PlayerCard.UnloadPlayerDescription();

            await LoadDataAsync();

            showCaseMoney();
            SetUpPlayer();

            BeforeQA.instanceBQA.Dispose();
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
                userWinnings.Image = Properties.Resources.GIF_NewCashPrize_0;
            }
        }

        private void SetUpPlayer()
        {
            label_userName.Text = Character.playerName;

            if (Character.playerCharacter == "Jeff")
            {
                pic_player.Image = Properties.Resources.Character_GIF_P1;
            }
            else if (Character.playerCharacter == "Golfy")
            {
                pic_player.Image = Properties.Resources.Character_GIF_P2;
            }
            else
            {
                pic_player.Image = Properties.Resources.Character_GIF_P3;
            }

            if (Category.categoryName == "Math")
            {
                picBox_Category.Image = Properties.Resources.Category_Math_Clicked;
            }
            else if (Category.categoryName == "History")
            {
                picBox_Category.Image = Properties.Resources.Category_History_Clicked;
            }

            if (Category.moneyTree == "Classic")
            {
                picBox_MoneyTree.Image = Properties.Resources.Format_ClassicMT_Clicked;
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();
            Character.characterInstance = character;
            character.Show();
            this.Close();
            this.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            Leaderboard myForm = new Leaderboard();
            myForm.Show();
            this.Close();
            this.Dispose();
            myForm = null;
        }

        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            Home.homeInstance = homeForm;
            homeForm.Show();
            this.Close();
            this.Dispose();
            homeForm = null;
        }
    }
}
