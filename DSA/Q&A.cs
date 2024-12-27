using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*using System.Drawing;
using System.Windows.Forms;*/

namespace DSA
{
    /*public class TransparentLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Parent is PictureBox pictureBox && pictureBox.Image != null)
            {
                e.Graphics.DrawImage(pictureBox.Image, -Left, -Top, pictureBox.Image.Width, pictureBox.Image.Height);
            }
            else
            {
                base.OnPaintBackground(e);
            }


            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.Default);
        }
    }*/

    public partial class QA : Form
    {


        public QA()
        {
            InitializeComponent();

        }

        private void Lifeline_5050_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int answerKey = 1;

            list.Remove(answerKey);

            int count = 0;
            int random = list[rnd.Next(list.Count)];

            while (count < 2) 
            {
                if (random == 0 && random != answerKey)
                {
                    ChoiceA.Visible = false;
                    ChoiceA_Text.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == 1 && random != answerKey)
                {
                    ChoiceB.Visible = false;
                    ChoiceB_Text.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == 2 && random != answerKey)
                {
                    ChoiceC.Visible = false;
                    ChoiceC_Text.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == 3 && random != answerKey)
                {
                    ChoiceD.Visible = false;
                    ChoiceD_Text.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
            }
            Lifeline_5050.Visible = false;
            
            
        }

        private void Lifeline_x2_Click(object sender, EventArgs e)
        {

        }

        private void Lifeline_timeFreeze_Click(object sender, EventArgs e)
        {

        }

        private void Lifeline_SwitchQ_Click(object sender, EventArgs e)
        {

        }

        private void ChoiceA_Text_Click(object sender, EventArgs e)
        {
            panelA.BackgroundImage = Properties.Resources.Q_A_Wrong_Left;
            panelB.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
            panelC.BackgroundImage = Properties.Resources.Q_A_Choice_Right;
            panelD.BackgroundImage = Properties.Resources.Q_A_Choice_Right;
        }

        private void ChoiceB_Text_Click(object sender, EventArgs e)
        {
            panelA.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
            panelB.BackgroundImage = Properties.Resources.Q_A_Wrong_Left;
            panelC.BackgroundImage = Properties.Resources.Q_A_Choice_Right;
            panelD.BackgroundImage = Properties.Resources.Q_A_Choice_Right;
        }

        private void ChoiceC_Text_Click(object sender, EventArgs e)
        {
            panelA.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
            panelB.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
            panelC.BackgroundImage = Properties.Resources.Q_A_Wrong_Right;
            panelD.BackgroundImage = Properties.Resources.Q_A_Choice_Right;
        }


        private void ChoiceD_Text_Click(object sender, EventArgs e)
        {
            panelA.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
            panelB.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
            panelC.BackgroundImage = Properties.Resources.Q_A_Choice_Right;
            panelD.BackgroundImage = Properties.Resources.Q_A_Wrong_Right;
        }

        
    }
}
