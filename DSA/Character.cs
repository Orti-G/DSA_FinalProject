using DSA.Properties;
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
    public partial class Character : Form
    {
        private Image player1_image = Resources.Character_GIF_P1;
        private Image player1_Stillimage = Properties.Resources.Character_still_P1;

        private Image player2_image = Resources.Character_GIF_P2;
        private Image player2_Stillimage = Resources.Character_still_P2;

        private Image player3_image = Resources.Character_GIF_P3;
        private Image player3_Stillimage = Resources.Character_still_P3;

        private Image panelBackground = Resources.CharacterSelectedBox;
        public Character()
        {
            InitializeComponent();
        }

        private void Character_Load(object sender, EventArgs e)
        {

        }

        private void selectCharacter1_Click(object sender, EventArgs e)
        {

            pictureBox_P1.Image = player1_image;
            panel_P1.BackgroundImage = panelBackground;

            pictureBox_P2.Image = player2_Stillimage;
            panel_P2.BackgroundImage = null;

            pictureBox_P3.Image = player3_Stillimage;
            panel_P3.BackgroundImage = null;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox_P1.Image = player1_Stillimage;
            panel_P1.BackgroundImage = null;

            pictureBox_P2.Image = player2_image;
            panel_P2.BackgroundImage = panelBackground;

            pictureBox_P3.Image = player3_Stillimage;
            panel_P3.BackgroundImage = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox_P1.Image = player1_Stillimage;
            panel_P1.BackgroundImage = null;

            pictureBox_P2.Image = player2_Stillimage;
            panel_P2.BackgroundImage = null;

            pictureBox_P3.Image = player3_image;
            panel_P3.BackgroundImage = panelBackground;

        }

        private void txtBox_userName_Click(object sender, EventArgs e)
        {
            if (txtBox_userName.Text == "Name Your Character") 
            {
                txtBox_userName.Text = null;
            }  
        }
    }
}
