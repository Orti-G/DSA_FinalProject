using System;
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
    public partial class GrandPrize2M : Form
    {
        private SoundPlayer sfx;
        public static GrandPrize2M grandPrizeInstance;
        public GrandPrize2M()
        {
            InitializeComponent();
            BGM.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\FinalBGM&SFX\BGM_WinFor2M.mp3";
           
            userWinnings2M.Parent = pictureBox1;
        }

        private void GrandPrize2M_Load(object sender, EventArgs e)
        {
            if (Character.playerCharacter == "Jeff")
            {
                pictureBox1.Image = Properties.Resources.GIF_GranPrize_P1;
            }
            else if (Character.playerCharacter == "Golfy")
            {
                pictureBox1.Image = Properties.Resources.GIF_GranPrize_p2;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.GIF_GranPrize_p3;
            }
        }
    }
}
