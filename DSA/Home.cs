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
    public partial class Home : Form
    {
        public static Home homeInstance;
        public Home()
        {
            InitializeComponent();
        }


        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            Form4 mechanics = new Form4(); 
            mechanics.Show();
            this.Hide();
        }
private SoundPlayer sfx;
        private void startButton_Click(object sender, EventArgs e)
        {
            if (Character.characterInstance == null)
            {
                Character characterPanel = new Character();
                Character.characterInstance = characterPanel;
                characterPanel.Show();
            }
            else
            {
                Character.characterInstance.Show();
            }

            this.Hide();
        }
    }
}
