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
    public partial class SetupPanel : Form
    {
        public static SetupPanel instanceSetUp;
        public SetupPanel()
        {
            InitializeComponent();
            
        }


        private void SetupPanel_Load(object sender, EventArgs e)
        {

        }

        private void label_userName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            QA gameplay = new QA(Mathematics.MathematicsQuestions(),true,true,true,true);
            gameplay.Show();
            this.Close();
            this.Dispose();
            instanceSetUp = null;
            Category.categoryInstance = null;
            Character.characterInstance = null;
            Home.homeInstance = null;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Category.categoryInstance.Show();
            this.Hide();
        }
    }
}
