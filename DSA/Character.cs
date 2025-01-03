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
        public Character()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectCharacter1_Click(object sender, EventArgs e)
        {
           
            pictureBox_P1.Image=Properties.Resources.Character_GIF_P1;
            panel_P1.BackgroundImage = Properties.Resources.CharacterSelectedBox;

            pictureBox_P2.Image = Properties.Resources.Character_still_P2;
            panel_P2.BackgroundImage = null;

            pictureBox_P3.Image = Properties.Resources.Character_still_P3;
            panel_P3.BackgroundImage = null;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox_P1.Image = Properties.Resources.Character_still_P1;
            panel_P1.BackgroundImage = null;

            pictureBox_P2.Image = Properties.Resources.Character_GIF_P2;
            panel_P2.BackgroundImage = Properties.Resources.CharacterSelectedBox;

            pictureBox_P3.Image = Properties.Resources.Character_still_P3;
            panel_P3.BackgroundImage = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox_P1.Image = Properties.Resources.Character_still_P1;
            panel_P1.BackgroundImage = null;

            pictureBox_P2.Image = Properties.Resources.Character_still_P2;
            panel_P2.BackgroundImage = null;

            pictureBox_P3.Image = Properties.Resources.Character_GIF_P3;
            panel_P3.BackgroundImage = Properties.Resources.CharacterSelectedBox;

        }
    }
}
