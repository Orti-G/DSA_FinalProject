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
    public partial class HistoryUC : UserControl
    {
        PlayerCard PlayerDescription;
        public HistoryUC(PlayerCard pCard)
        {
            InitializeComponent();
            PlayerDescription = pCard;
        }

        private void HistoryUC_Load(object sender, EventArgs e)
        {
            label_userName.Text = PlayerDescription.GetPlayerName();
            label_Category.Text = PlayerDescription.GetPlayerCategory();
            label_MoneyTree.Text = PlayerDescription.GetPlayerMoneyTree();

            if (PlayerDescription.GetPlayerCharacter() == "Jeff")
            {
                picBox_character.Image = Properties.Resources.Character_still_P1;
            }
            else if (PlayerDescription.GetPlayerCharacter() == "Golfy")
            {
                picBox_character.Image = Properties.Resources.Character_still_P2;
            }
            else 
            {
                picBox_character.Image = Properties.Resources.Character_still_P3;
            }

            if (PlayerDescription.GetPlayerWinnings() == "1000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_1K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "3000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_3K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "5000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_5K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "10000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_10K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "20000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_20K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "35000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_35K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "50000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_50K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "70000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_70K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "100000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_100K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "150000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_150K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "250000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_250K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "400000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_400K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "600000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_600K;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "1000000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_1M;
            }
            else if (PlayerDescription.GetPlayerWinnings() == "2000000")
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_2M;
            }
            else
            {
                picBox_winnings.Image = Properties.Resources.GIF_NewCashPrize_0;
            }

        }

        private void picBox_character_Click(object sender, EventArgs e)
        {

        }
    }
}
