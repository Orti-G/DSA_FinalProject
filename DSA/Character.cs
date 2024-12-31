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
            //selectCharacter1.Image=Properties.Resources.ProxyPlayer_Clicked;
            selectCharacter1.BackgroundImage=Properties.Resources.CharacterSelectedBox;

            //selectCharacter2.Image=Properties.Resources.ProxyPlayer2;
            selectCharacter2.BackgroundImage = null;
            //selectCharacter3.Image = Properties.Resources.ProxyPlayer3;
            selectCharacter3.BackgroundImage = null;
        }

        private void selectCharacter2_Click(object sender, EventArgs e)
        {
            //selectCharacter2.Image = Properties.Resources.ProxyPlayer_Clicked2;
            selectCharacter2.BackgroundImage = Properties.Resources.CharacterSelectedBox;

            selectCharacter1.Image = Properties.Resources.ProxyPLayer;
            selectCharacter1.BackgroundImage = null;
           // selectCharacter3.Image = Properties.Resources.ProxyPlayer3;
            selectCharacter3.BackgroundImage = null;
        }

        private void selectCharacter3_Click(object sender, EventArgs e)
        {
            //selectCharacter3.Image = Properties.Resources.ProxyPlayer_Clicked3;
            selectCharacter3.BackgroundImage = Properties.Resources.CharacterSelectedBox;

            //selectCharacter2.Image = Properties.Resources.ProxyPlayer2;
            selectCharacter2.BackgroundImage = null;
            selectCharacter1.Image = Properties.Resources.ProxyPLayer;
            selectCharacter1.BackgroundImage = null;
        }
    }
}
