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
    public partial class Home : Form
    {
        public static Home homeInstance;
        public Home()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            /*Winning form8 = new Winning();
            form8.Show();
            this.Hide();*/
        }
    }
}
