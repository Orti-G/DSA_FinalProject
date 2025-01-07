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
    public partial class SetupPanel : Form
    {
        public static SetupPanel instanceSetUp;
        public SetupPanel()
        {
            InitializeComponent();
            label_userName.Text = Character.playerName;
            SetUpPlayer();
        }
        private void SetUpPlayer()
        {
            if (Character.playerCharacter == "Jeff")
            {
                selectCharacter1.Image = Properties.Resources.Character_GIF_P1;
            }
            else if (Character.playerCharacter == "Golfy")
            {
                selectCharacter1.Image = Properties.Resources.Character_GIF_P2;
            }
            else 
            {
                selectCharacter1.Image = Properties.Resources.Character_GIF_P3;
            }

            if (Category.categoryName == "Math")
            {
                picBox_category.Image = Properties.Resources.Category_Math_Clicked;
            }
            else if (Category.categoryName == "History")
            {
                picBox_category.Image = Properties.Resources.Category_History_Clicked;
            }

            if (Category.moneyTree == "Classic") 
            {
                picBox_moneyTree.Image = Properties.Resources.Format_ClassicMT_Clicked;
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            PlayerCard.PlayerDescription.AddLast(Character.playerName);
            PlayerCard.PlayerDescription.AddLast(Character.playerCharacter);
            PlayerCard.PlayerDescription.AddLast(Category.categoryName);
            PlayerCard.PlayerDescription.AddLast(Category.moneyTree);

            Animation animate = new Animation();
            animate.Show();
            instanceSetUp = null;

            Category.categoryInstance.Dispose();
            Category.categoryInstance = null;

            Character.characterInstance.Dispose();
            Character.characterInstance = null;

            Home.homeInstance.Dispose();
            Home.homeInstance = null;
            animate = null;


            this.Close();
            this.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

        }
 private SoundPlayer sfx;
        private void btn_Back_Click(object sender, EventArgs e)
        {

            Category.categoryInstance.Show();
            this.Close();
            this.Dispose();
            instanceSetUp = null;
        }
    }
}
