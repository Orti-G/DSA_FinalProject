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
    public partial class GrandPrize2M : Form
    {
        public static GrandPrize2M grandPrizeInstance;
        public GrandPrize2M()
        {
            InitializeComponent();
        }

        private void GrandPrize2M_Load(object sender, EventArgs e)
        {
            if (Character.playerCharacter == "Jeff")
            {
                pictureBox1.Image = Properties.Resources.GIF_Intense_P1;
            }
            else if (Character.playerCharacter == "Golfy")
            {
                pictureBox1.Image = Properties.Resources.GIF_Intense_P2;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.GIF_Intense_P3;
            }
        }
    }
}
