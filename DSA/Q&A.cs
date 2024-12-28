using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//insert suspense animation in line 205 and 234
//insert winning animation in line 354
//insert losing animation in line 359


namespace DSA
{
    public partial class QA : Form
    {
        public QA()
        {
            InitializeComponent();
            AdjustBackgorund();
        }
        
        private string UserAnswer;
        private readonly string answerKey = "C";

        private int elapsedTime = -4;
        private int elapsedAnimation = -2;
        private int elapsedTransition = -2;

        private void Lifeline_5050_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            string answerKey = "C";

            list.Remove(answerKey);

            int count = 0;
            string random = list[rnd.Next(list.Count)];

            while (count < 2) 
            {
                if (random == "A" && random != answerKey)
                {
                    ChoiceA.Visible = false;
                    ChoiceA_Text.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == "B" && random != answerKey)
                {
                    ChoiceB.Visible = false;
                    ChoiceB_Text.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == "C" && random != answerKey)
                {
                    ChoiceC.Visible = false;
                    ChoiceC_Text.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == "D" && random != answerKey)
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
            TimeToAnswer.Stop();
            Lifeline_timeFreeze.Visible = false;
            GifTimer.Enabled = false;
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

        private void ChoiceA_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserAnswer = "A";

                panel_FinalAnswerNotif.Visible = true;
                panel_FinalAnswerNotif.BringToFront();
                panelB.Enabled = false;
                panelC.Enabled = false;
                panelD.Enabled = false;
                DisabledLifeLines();
            
        }

        private void ChoiceB_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserAnswer = "B";

                panel_FinalAnswerNotif.Visible = true;
                panelA.Enabled = false;
                panelC.Enabled = false;
                panelD.Enabled = false;
                DisabledLifeLines();
            
        }

        private void ChoiceC_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserAnswer = "C";
 
                panel_FinalAnswerNotif.Visible = true;
                panelA.Enabled = false;
                panelB.Enabled = false;
                panelD.Enabled = false;
                DisabledLifeLines();
            
        }

        private void ChoiceD_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserAnswer = "D";
 
                panel_FinalAnswerNotif.Visible = true;
                panelA.Enabled = false;
                panelB.Enabled = false;
                panelC.Enabled = false;
                DisabledLifeLines();

        }

        private void btn_YesFinalAnswer_Click(object sender, EventArgs e)
        {
            panel_FinalAnswerNotif.Visible = false;
            panelA.Enabled = true;
            panelB.Enabled = true;
            panelC.Enabled = true;
            panelD.Enabled = true;
            GifTimer.Visible = false;

            TimeToAnswer.Stop();
            TimeToAnswer.Dispose();
            AnimationTimer.Stop();
            AnimationTimer.Dispose();

            DisabledButtonEvent();

            BackgroundGif.Image = null;
            transitionTimer.Start();

        }

        private void TimeToAnswer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;            
            if (elapsedTime == 60)
            {
                TimeToAnswer.Stop();
                TimeToAnswer.Dispose();
                AnimationTimer.Stop();
                AnimationTimer.Dispose();

                GifTimer.Visible = false;
                panel_FinalAnswerNotif.Visible = false;
                panelA.Enabled = true;
                panelB.Enabled = true;
                panelC.Enabled = true;
                panelD.Enabled = true;

                UserAnswer = null;

                panelA.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
                panelB.BackgroundImage = Properties.Resources.Q_A_Choice_Left;
                panelC.BackgroundImage = Properties.Resources.Q_A_Choice_Right;
                panelD.BackgroundImage = Properties.Resources.Q_A_Choice_Right;

                BackgroundGif.Image = null;
                transitionTimer.Start();
                DisabledButtonEvent();
            }
        }

        private void btn_NoFinalAnswer_Click(object sender, EventArgs e)
        {
            panel_FinalAnswerNotif.Visible = false;
            UserAnswer = null;
            panelA.Enabled = true;
            panelB.Enabled = true;
            panelC.Enabled = true;
            panelD.Enabled = true;
            EnabledLifeLines();
        }

        private void DisabledLifeLines() 
        {
            Lifeline_5050.Enabled = false;          
            Lifeline_x2.Enabled = false;
            Lifeline_timeFreeze.Enabled = false;
            Lifeline_SwitchQ.Enabled = false;

        }

        private void EnabledLifeLines()
        {
            Lifeline_5050.Enabled = true;
            Lifeline_x2.Enabled = true;
            Lifeline_timeFreeze.Enabled = true;
            Lifeline_SwitchQ.Enabled = true;

        }

        private void ShowCorrectAnswer() 
        {
            if (answerKey == "A")
            {
                panelA.BackgroundImage = Properties.Resources.Q_A_Correct_Left;   
            }
            else if (answerKey == "B")
            {
                panelB.BackgroundImage = Properties.Resources.Q_A_Correct_Left;
            }
            else if (answerKey == "C")
            {
                panelC.BackgroundImage = Properties.Resources.Q_A_Correct_Right;
            }
            else if (answerKey == "D") 
            {
                panelD.BackgroundImage = Properties.Resources.Q_A_Correct_Right;
            }
        }

        private void AdjustBackgorund() 
        {
            
            panel_Question.Parent = BackgroundGif;
            
            panelA.Parent = BackgroundGif;
            panelB.Parent = BackgroundGif;
            panelC.Parent = BackgroundGif;
            panelD.Parent = BackgroundGif;
            
            MoneyTree_BG_Panel.Parent = BackgroundGif;
            MoneyTree_BG_Panel.BringToFront();

            Lifeline_5050.Parent = BackgroundGif;
            Lifeline_x2.Parent = BackgroundGif;
            Lifeline_timeFreeze.Parent = BackgroundGif;
            Lifeline_SwitchQ.Parent = BackgroundGif;
        }

        private void DisabledButtonEvent() 
        {
            ChoiceA_Text.Click -= ChoiceA_Text_Click;
            ChoiceB_Text.Click -= ChoiceB_Text_Click;
            ChoiceC_Text.Click -= ChoiceC_Text_Click;
            ChoiceD_Text.Click -= ChoiceD_Text_Click;
            ChoiceA_Text.MouseDoubleClick -= ChoiceA_Text_MouseDoubleClick;
            ChoiceB_Text.MouseDoubleClick -= ChoiceB_Text_MouseDoubleClick;
            ChoiceC_Text.MouseDoubleClick -= ChoiceC_Text_MouseDoubleClick;
            ChoiceD_Text.MouseDoubleClick -= ChoiceD_Text_MouseDoubleClick;
            Lifeline_5050.Click -= Lifeline_5050_Click;
            Lifeline_x2.Click -= Lifeline_x2_Click;
            Lifeline_timeFreeze.Click -= Lifeline_timeFreeze_Click;
            Lifeline_SwitchQ.Click -= Lifeline_SwitchQ_Click;
            GifTimer.Enabled = false;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            elapsedAnimation++;
            if (elapsedAnimation == 15)
            {
                BackgroundGif.Image = Properties.Resources.GIF_Contestant1_Answering;
                AnimationTimer.Stop();
                AnimationTimer.Dispose();
            }
        }

        private void transitionTimer_Tick(object sender, EventArgs e)
        {        
            elapsedTransition++;
            if (elapsedTransition == 5)
            {
                
                transitionTimer.Stop();
                transitionTimer.Dispose();
                ShowResult();
            }
        }

        public void ShowResult() 
        {
            
            ShowCorrectAnswer();
            if (UserAnswer == answerKey)
            {
                BackgroundGif.Image = Properties.Resources.GIF_Homescreen1;
                MessageBox.Show("Correct");
            }
            else 
            {
                BackgroundGif.Image = Properties.Resources.GIF_Homescreen1;
                MessageBox.Show("Wrong");
            }
        }
    }
}
