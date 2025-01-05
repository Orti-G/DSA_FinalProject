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
        public static Character characterInstance;

        private Image player1_image = Properties.Resources.Character_GIF_P1;
        private Image player1_Stillimage = Properties.Resources.Character_still_P1;

        private Image player2_image = Properties.Resources.Character_GIF_P2;
        private Image player2_Stillimage = Properties.Resources.Character_still_P2;

        private Image player3_image = Properties.Resources.Character_GIF_P3;
        private Image player3_Stillimage = Properties.Resources.Character_still_P3;

        private Image panelBackground = Properties.Resources.CharacterSelectedBox;

        public static string playerCharacter;
        public static string playerName;
        public Character()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

        }

        private void Character_Load(object sender, EventArgs e)
        {

        }

        private void selectCharacter1_Click(object sender, EventArgs e)
        {
            playerCharacter = "Jeff";
            pictureBox_P1.Image = player1_image;
            panel_P1.BackgroundImage = panelBackground;

            pictureBox_P2.Image = player2_Stillimage;
            panel_P2.BackgroundImage = null;

            pictureBox_P3.Image = player3_Stillimage;
            panel_P3.BackgroundImage = null;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            playerCharacter = "Golfy";

            pictureBox_P1.Image = player1_Stillimage;
            panel_P1.BackgroundImage = null;

            pictureBox_P2.Image = player2_image;
            panel_P2.BackgroundImage = panelBackground;

            pictureBox_P3.Image = player3_Stillimage;
            panel_P3.BackgroundImage = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playerCharacter = "Squidward";

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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home.homeInstance.Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            bool nextPanel = true;
            playerName = txtBox_userName.Text;

            if (playerCharacter == null)
            {
                MessageBox.Show("Please select a character");
                nextPanel = false;
            } 
            else if (playerName == "Name Your Character" || playerName == "")
            {
               MessageBox.Show("Please input name for your character");
                nextPanel = false;
            }

            if (Category.categoryInstance == null && nextPanel)
            {
                Category categoryForm = new Category();
                Category.categoryInstance = categoryForm;
                categoryForm.Show();
                this.Hide();
            }
            else if (nextPanel)
            {
                Category.categoryInstance.Show();
                this.Hide();
            }
            
            
        }
    }
}
