using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

//insert suspense animation in line 205 and 234
//insert winning animation in line 354
//insert losing animation in line 359


namespace DSA
{
    public partial class QA : Form
    {
        public static QA myForm;

        private bool Life2x = false;

        private bool HalfChanceVisible;
        private bool Life2xVisible;
        private bool timeFreezeVisible;
        private bool SwitchQuestionVisible;

        private string UserAnswer;
        private string UserSecondAnswer;
        private string answerKey;

        private int elapsedTime = -4;
        private int elapsedAnimation = -2;
        private int elapsedTransition = -2;
        private int transitionCount = 0;

        private Image wrongLeft = Properties.Resources.Q_A_Wrong_Left;
        private Image wrongRight = Properties.Resources.Q_A_Wrong_Right;
        private Image choiceLeft = Properties.Resources.Q_A_Choice_Left;
        private Image choiceRight = Properties.Resources.Q_A_Choice_Right;

        private Queue<Inventory> Questions;
        private Inventory currentQuestion;
        private int MoneyTreeLevel;

        private int[] SafeHavens = {5,10,15};

        private Timer timerForLifelines;

        private SoundPlayer sfx;
        
        public QA(Queue<Inventory> questions,bool halfchance,bool life2x, bool timeFreeze, bool switchQuestion)
        {
            
            InitializeComponent();
            AdjustBackgorund();
            timerForLifelines = new Timer();
            timerForLifelines.Interval = 3000;
            timerForLifelines.Tick += Timer_Tick;

            HalfChanceVisible = halfchance;
            Life2xVisible = life2x;
            timeFreezeVisible = timeFreeze;
            SwitchQuestionVisible = switchQuestion;

            Questions = questions;

            BGMusic.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\BGM_Question_1kto20k.MP3";
            
        }

        

        private void QA_Load(object sender, EventArgs e)
        {
            currentQuestion = Questions.Dequeue();

            MoneyTreeLevel = 15 - Questions.Count;

            MoneyTreeLevelHighlight();

            Lifeline_5050.Visible = HalfChanceVisible;
            Lifeline_x2.Visible = Life2xVisible;
            Lifeline_timeFreeze.Visible = timeFreezeVisible;
            Lifeline_SwitchQ.Visible = SwitchQuestionVisible;

            Question_Text.Text = currentQuestion.getQuestion();

            if (currentQuestion.getOptions()[0].Length <= 26)
            {
                ChoiceA_Text.Text = currentQuestion.getOptions()[0];
            }
            else
            {
                ChoiceA_Text.Visible = false;
                ChoiceA_LongText.Visible = true;
                ChoiceA_LongText.Text = currentQuestion.getOptions()[0];
            }

            if (currentQuestion.getOptions()[1].Length <= 26)
            {
                ChoiceB_Text.Text = currentQuestion.getOptions()[1];
            }
            else
            {
                ChoiceB_Text.Visible = false;
                ChoiceB_LongText.Visible = true;
                ChoiceB_LongText.Text = currentQuestion.getOptions()[1];
            }

            if (currentQuestion.getOptions()[2].Length <= 26)
            {
                ChoiceC_Text.Text = currentQuestion.getOptions()[2];
            }
            else
            {
                ChoiceC_Text.Visible = false;
                ChoiceC_LongText.Visible = true;
                ChoiceC_LongText.Text = currentQuestion.getOptions()[2];
            }

            if (currentQuestion.getOptions()[3].Length <= 26)
            {
                ChoiceD_Text.Text = currentQuestion.getOptions()[3];
            }
            else
            {
                ChoiceD_Text.Visible = false;
                ChoiceD_LongText.Visible = true;
                ChoiceD_LongText.Text = currentQuestion.getOptions()[3];
            }

            answerKey = currentQuestion.getAnswer();
            
        }
        private void MoneyTreeLevelHighlight() 
        {
            if (MoneyTreeLevel == 1)
            {
                MoneyTree_1.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 2)
            {
                MoneyTree_2.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 3)
            {
                MoneyTree_3.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 4)
            {
                MoneyTree_4.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 5)
            {
                MoneyTree_5.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 6)
            {
                MoneyTree_6.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 7)
            {
                MoneyTree_7.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 8)
            {
                MoneyTree_8.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 9)
            {
                MoneyTree_9.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 10)
            {
                MoneyTree_10.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 11)
            {
                MoneyTree_11.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 12)
            {
                MoneyTree_12.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 13)
            {
                MoneyTree_13.BackColor = Color.Khaki;
            }
            else if (MoneyTreeLevel == 14)
            {
                MoneyTree_14.BackColor = Color.Khaki;
            }
            else
            {
                MoneyTree_15.BackColor = Color.Khaki;
            }
        }

        private void Lifeline_5050_Click(object sender, EventArgs e)
        {
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_LifelineActivated(wav).wav");
            sfx.Play();

            Random rnd = new Random();
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            list.Remove(answerKey);

            int count = 0;
            string random = list[rnd.Next(list.Count)];

            while (count < 2) 
            {
                if (random == "A" && random != answerKey)
                {
                    ChoiceA.Visible = false;
                    ChoiceA_Text.Visible = false;
                    ChoiceA_LongText.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == "B" && random != answerKey)
                {
                    ChoiceB.Visible = false;
                    ChoiceB_Text.Visible = false;
                    ChoiceB_LongText.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == "C" && random != answerKey)
                {
                    ChoiceC.Visible = false;
                    ChoiceC_Text.Visible = false;
                    ChoiceC_LongText.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
                else if (random == "D" && random != answerKey)
                {
                    ChoiceD.Visible = false;
                    ChoiceD_Text.Visible = false;
                    ChoiceD_LongText.Visible = false;
                    list.Remove(random);
                    random = list[rnd.Next(list.Count)];
                    count++;
                }
            }

            Lifeline_5050.Visible = false;
            HalfChanceVisible = false;
            timerForLifelines.Start();
            panel_CorrectAnswerNotice.BackgroundImage = Properties.Resources.LifelineActivated_5050;
            panel_CorrectAnswerNotice.Visible = true;
            DisabledLifeLines();
        }

        private void Lifeline_x2_Click(object sender, EventArgs e)
        {
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_LifelineActivated(wav).wav");
            sfx.Play();
            Life2x = true;
            Lifeline_x2.Visible = false;
            Life2xVisible = false;
            timerForLifelines.Start();
            panel_CorrectAnswerNotice.BackgroundImage = Properties.Resources.LifelineActivated__DoubleAnswer;
            panel_CorrectAnswerNotice.Visible = true;
            DisabledLifeLines();
        }

        private void Lifeline_timeFreeze_Click(object sender, EventArgs e)
        {
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_LifelineActivated(wav).wav");
            sfx.Play();
            TimeToAnswer.Stop();
            GifTimer.Enabled = false;

            Lifeline_timeFreeze.Visible = false;
            timeFreezeVisible = false;

            timerForLifelines.Start();
            panel_CorrectAnswerNotice.BackgroundImage = Properties.Resources.LifelineActivated__TimeFreeze;
            panel_CorrectAnswerNotice.Visible = true;

            DisabledLifeLines();

        }

        private void Lifeline_SwitchQ_Click(object sender, EventArgs e)
        {
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_LifelineActivated(wav).wav");
            sfx.Play();

            Question_Text.Text = currentQuestion.getSpareQuestion();

            if (currentQuestion.getSpareOptions()[0].Length <= 26)
            {
                ChoiceA_Text.Text = currentQuestion.getSpareOptions()[0];
            }
            else
            {
                ChoiceA_Text.Visible = false;
                ChoiceA_LongText.Visible = true;
                ChoiceA_LongText.Text = currentQuestion.getSpareOptions()[0];
            }

            if (currentQuestion.getSpareOptions()[1].Length <= 26)
            {
                ChoiceB_Text.Text = currentQuestion.getSpareOptions()[1];
            }
            else
            {
                ChoiceB_Text.Visible = false;
                ChoiceB_LongText.Visible = true;
                ChoiceB_LongText.Text = currentQuestion.getSpareOptions()[1];
            }

            if (currentQuestion.getSpareOptions()[2].Length <= 26)
            {
                ChoiceC_Text.Text = currentQuestion.getSpareOptions()[2];
            }
            else
            {
                ChoiceC_Text.Visible = false;
                ChoiceC_LongText.Visible = true;
                ChoiceC_LongText.Text = currentQuestion.getSpareOptions()[2];
            }

            if (currentQuestion.getSpareOptions()[3].Length <= 26)
            {
                ChoiceD_Text.Text = currentQuestion.getSpareOptions()[3];
            }
            else
            {
                ChoiceD_Text.Visible = false;
                ChoiceD_LongText.Visible = true;
                ChoiceD_LongText.Text = currentQuestion.getSpareOptions()[3];
            }

            answerKey = currentQuestion.getSpareAnswer();

            Lifeline_SwitchQ.Visible = false;
            SwitchQuestionVisible = false;
            timerForLifelines.Start();
            panel_CorrectAnswerNotice.BackgroundImage = Properties.Resources.LifelineActivated__SwitchQuestiom;
            panel_CorrectAnswerNotice.Visible = true;

            DisabledLifeLines();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerForLifelines.Stop();
            timerForLifelines.Dispose();
            timerForLifelines = null;
            panel_CorrectAnswerNotice.BackgroundImage = Properties.Resources.Q_A_Correct;
            panel_CorrectAnswerNotice.Visible = false;
        }
        private void ChoiceA_Text_Click(object sender, EventArgs e)
        {
            if (Life2x && UserAnswer != null) 
            {
                panelA.BackgroundImage = wrongLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = choiceRight;
                AvoidChangingColorUserAnswer();
            }
            else
            {
                panelA.BackgroundImage = wrongLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = choiceRight;
            }
            
        }

        private void ChoiceB_Text_Click(object sender, EventArgs e)
        {
            if (Life2x && UserAnswer != null)
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = wrongLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = choiceRight;
                AvoidChangingColorUserAnswer();
            }
            else
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = wrongLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = choiceRight;
            }
            
        }

        private void ChoiceC_Text_Click(object sender, EventArgs e)
        {
            if (Life2x && UserAnswer != null)
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = wrongRight;
                panelD.BackgroundImage = choiceRight;
                AvoidChangingColorUserAnswer();
            }
            else
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = wrongRight;
                panelD.BackgroundImage = choiceRight;
            }            
        }

        private void ChoiceD_Text_Click(object sender, EventArgs e)
        {
            if (Life2x && UserAnswer != null)
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = wrongRight;
                AvoidChangingColorUserAnswer();
            }
            else
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = wrongRight;
            }
            
        }

        private void ChoiceA_LongText_Click(object sender, EventArgs e)
        {
            ChoiceA_Text_Click(ChoiceA_Text, EventArgs.Empty);
        }
        private void ChoiceB_LongText_Click(object sender, EventArgs e)
        {
            ChoiceB_Text_Click(ChoiceB_Text, EventArgs.Empty);
        }
        private void ChoiceC_LongText_Click(object sender, EventArgs e)
        {
            ChoiceC_Text_Click(ChoiceC_Text, EventArgs.Empty);
        }

        private void ChoiceD_LongText_Click(object sender, EventArgs e)
        {
            ChoiceD_Text_Click(ChoiceD_Text, EventArgs.Empty);
        }

        private void AvoidChangingColorUserAnswer()
        {
            if (UserAnswer == "A")
            {
                panelA.BackgroundImage = wrongLeft;
            }
            else if (UserAnswer == "B")
            {
                panelB.BackgroundImage = wrongLeft;
            }
            else if (UserAnswer == "C")
            {
                panelC.BackgroundImage = wrongRight;
            }
            else if (UserAnswer == "D")
            {
                panelD.BackgroundImage = wrongRight;
            }
        }

        private void ChoiceA_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_AnswerDoubleClicked(wav).wav"); 
            sfx.Play();
            if (Life2x && UserAnswer == null)
            {
                UserAnswer = "A";
            }
            else if (Life2x && UserAnswer != null)
            {
                UserSecondAnswer = "A";
            }
            else 
            {
                UserAnswer = "A";
            }
            
                panel_FinalAnswerNotif.Visible = true;
                panelB.Enabled = false;
                panelC.Enabled = false;
                panelD.Enabled = false;
                DisabledLifeLines();       
        }

        private void ChoiceB_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_AnswerDoubleClicked(wav).wav");
            sfx.Play();
            if (Life2x && UserAnswer == null)
            {
                UserAnswer = "B";
            }
            else if (Life2x && UserAnswer != null)
            {
                UserSecondAnswer = "B";
            }
            else
            {
                UserAnswer = "B";
            }

                panel_FinalAnswerNotif.Visible = true;
                panelA.Enabled = false;
                panelC.Enabled = false;
                panelD.Enabled = false;
                DisabledLifeLines();  
        }

        private void ChoiceC_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_AnswerDoubleClicked(wav).wav");
            sfx.Play();
            if (Life2x && UserAnswer == null)
            {
                UserAnswer = "C";
            }
            else if (Life2x && UserAnswer != null)
            {
                UserSecondAnswer = "C";
            }
            else
            {
                UserAnswer = "C";
            }

            panel_FinalAnswerNotif.Visible = true;
                panelA.Enabled = false;
                panelB.Enabled = false;
                panelD.Enabled = false;
                DisabledLifeLines();
        }

        private void ChoiceD_Text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sfx = new SoundPlayer(@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\SFX_AnswerDoubleClicked(wav).wav");
            sfx.Play();
            if (Life2x && UserAnswer == null)
            {
                UserAnswer = "D";
            }
            else if (Life2x && UserAnswer != null)
            {
                UserSecondAnswer = "D";
            }
            else
            {
                UserAnswer = "D";
            }

            panel_FinalAnswerNotif.Visible = true;
            panelA.Enabled = false;
            panelB.Enabled = false;
            panelC.Enabled = false;
            DisabledLifeLines();
        }

        private void ChoiceA_LongText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChoiceA_Text_MouseDoubleClick(ChoiceA_Text, e);
        }
        private void ChoiceB_LongText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChoiceB_Text_MouseDoubleClick(ChoiceB_Text, e);
        }

        private void ChoiceC_LongText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChoiceC_Text_MouseDoubleClick(ChoiceC_Text, e);
        }

        private void ChoiceD_LongText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChoiceD_Text_MouseDoubleClick(ChoiceD_Text, e);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            panel_FinalAnswerNotif.Visible = false;

            if (Life2x && UserSecondAnswer == null)
            {
                AnswerChosen(UserAnswer);
                EnabledLifeLines();
            }
            else
            {
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
                BGMusic.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\BGM_Intense.MP3";

                BackgroundGif.Image = Properties.Resources.GIF_Intense_P1;
                transitionTimer.Start();
            }
        }

        private void AnswerChosen(string answer)
        {
            if (answer == "A")
            {
                panelA.BackgroundImage = wrongLeft;          
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = choiceRight;

                panelA.Enabled = false;
                panelB.Enabled = true;
                panelC.Enabled = true;
                panelD.Enabled = true;
            }
            else if (answer == "B")
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = wrongLeft;              
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = choiceRight;

                panelA.Enabled = true;
                panelB.Enabled = false;
                panelC.Enabled = true;
                panelD.Enabled = true;
            }
            else if (answer == "C")
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = wrongRight;
                panelD.BackgroundImage = choiceRight;

                panelA.Enabled = true;
                panelB.Enabled = true;
                panelC.Enabled = false;
                panelD.Enabled = true;
            }
            else if (answer == "D")
            {
                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = wrongRight;

                panelA.Enabled = true;
                panelB.Enabled = true;
                panelC.Enabled = true;
                panelD.Enabled = false;
            }
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

                panelA.BackgroundImage = choiceLeft;
                panelB.BackgroundImage = choiceLeft;
                panelC.BackgroundImage = choiceRight;
                panelD.BackgroundImage = choiceRight;

                if (Life2x && UserAnswer != null)
                {
                    UserSecondAnswer = null;
                    AvoidChangingColorUserAnswer();
                }
                else 
                {
                    UserAnswer = null;
                    
                }
                BGMusic.URL=@"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\BGM_Intense.MP3";
                BackgroundGif.Image = Properties.Resources.GIF_Intense_P1;
                transitionTimer.Start();
                DisabledButtonEvent();
            }
        }
        private void btn_FinalAnswerNo_Click(object sender, EventArgs e)
        {
            panel_FinalAnswerNotif.Visible = false;

            if (Life2x && UserSecondAnswer != null)
            {
                UserSecondAnswer = null;
                DisabledSpecifiedPanel(UserAnswer);
            }
            else
            {
                UserAnswer = null;
                panelA.Enabled = true;
                panelB.Enabled = true;
                panelC.Enabled = true;
                panelD.Enabled = true;
            }

            EnabledLifeLines();
        }

        private void DisabledSpecifiedPanel(string key) 
        {
            if(key == "A")
            {
                panelA.Enabled = false;
                panelB.Enabled = true;
                panelC.Enabled = true;
                panelD.Enabled = true;
            }
            else if (key == "B")
            {
                panelA.Enabled = true;
                panelB.Enabled = false;
                panelC.Enabled = true;
                panelD.Enabled = true;
            }
            else if (key == "C")
            {
                panelA.Enabled = true;
                panelB.Enabled = true;
                panelC.Enabled = false;
                panelD.Enabled = true;
            }
            else if (key == "D")
            {
                panelA.Enabled = true;
                panelB.Enabled = true;
                panelC.Enabled = true;
                panelD.Enabled = false;
            }
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

            GifTimer.Parent = BackgroundGif;

            panel_FinalAnswerNotif.Parent = BackgroundGif;
            panel_CorrectAnswerNotice.Parent = BackgroundGif;

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

            ChoiceA_LongText.Click -= ChoiceA_LongText_Click;
            ChoiceB_LongText.Click -= ChoiceB_LongText_Click;
            ChoiceC_LongText.Click -= ChoiceC_LongText_Click;
            ChoiceD_LongText.Click -= ChoiceD_LongText_Click;


            ChoiceA_Text.MouseDoubleClick -= ChoiceA_Text_MouseDoubleClick;
            ChoiceB_Text.MouseDoubleClick -= ChoiceB_Text_MouseDoubleClick;
            ChoiceC_Text.MouseDoubleClick -= ChoiceC_Text_MouseDoubleClick;
            ChoiceD_Text.MouseDoubleClick -= ChoiceD_Text_MouseDoubleClick;

            ChoiceA_LongText.MouseDoubleClick -= ChoiceA_LongText_MouseDoubleClick;
            ChoiceB_LongText.MouseDoubleClick -= ChoiceB_LongText_MouseDoubleClick;
            ChoiceC_LongText.MouseDoubleClick -= ChoiceC_LongText_MouseDoubleClick;
            ChoiceD_LongText.MouseDoubleClick -= ChoiceD_LongText_MouseDoubleClick;

            Lifeline_5050.Click -= Lifeline_5050_Click;
            Lifeline_x2.Click -= Lifeline_x2_Click;
            Lifeline_timeFreeze.Click -= Lifeline_timeFreeze_Click;
            Lifeline_SwitchQ.Click -= Lifeline_SwitchQ_Click;
            GifTimer.Enabled = false;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            elapsedAnimation++;
            if (elapsedAnimation == 10)
            {
                BackgroundGif.Image = Properties.Resources.GIF_Contestant1_Answering;
                AnimationTimer.Stop();
                AnimationTimer.Dispose();
            } 
        }

        private void transitionTimer_Tick(object sender, EventArgs e)
        {
            elapsedTransition++;
            if (elapsedTransition == 3 && transitionCount == 0)
            {

                transitionTimer.Stop();
                elapsedTransition = -2;
                ShowResult();

            }
            else if (elapsedTransition == 3 && transitionCount == 1)
            {
                transitionTimer.Stop();
                transitionTimer.Dispose();

                if (Questions.Count != 0)
                {
                    Winning winning = new Winning(Questions, HalfChanceVisible, Life2xVisible, timeFreezeVisible, SwitchQuestionVisible);
                    winning.Show();
                    this.Close();
                    this.Dispose();
                    myForm = null;
                }
                else
                {
                    EndScreen gameResult = new EndScreen(2000000);
                    gameResult.Show();
                    this.Close();
                    this.Dispose();
                    myForm = null;
                }
            } 
            else if(elapsedTransition == 5 && transitionCount == 2)
            {
                transitionTimer.Stop();
                transitionTimer.Dispose();

                EndScreen gameResult = new EndScreen(TotalWinningsAfterLosing());
                gameResult.Show();
                this.Close();
                this.Dispose();
                myForm = null;
            }
        }

        private int TotalWinningsAfterLosing()
        {
            int totalWinnings = 0;

            if (SafeHavens.Length == 3)
            {
                if (MoneyTreeLevel <= SafeHavens[2] && MoneyTreeLevel > SafeHavens[1])
                {
                    totalWinnings = 150000;
                }
                else if (MoneyTreeLevel <= SafeHavens[1] && MoneyTreeLevel > SafeHavens[0])
                {
                    totalWinnings = 20000;
                }
                else
                {
                    totalWinnings = 0;
                }
            }
            else 
            {
                if (MoneyTreeLevel <= SafeHavens[0])
                {
                    totalWinnings = 0;
                }
                else
                {
                    totalWinnings = 20000;
                }
            }

            return totalWinnings;
        }

        private void ShowResult()
        {

            ShowCorrectAnswer();
            if (UserAnswer == answerKey || UserSecondAnswer == answerKey)
            {
                BackgroundGif.Image = null;
                panel_CorrectAnswerNotice.Visible = true;
                transitionCount = 1;
                BGMusic.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\BGM_CorrectAnswer.MP3";
                transitionTimer.Start();
      
            }
            else 
            {
                BackgroundGif.Image = Properties.Resources.GIF_Host_Disappointed;
                transitionCount = 2;
                BGMusic.URL = @"C:\Users\manam\OneDrive\Desktop\DSA PROJECT-1stSem2ndY\INPUT MATERIALS\SFX\BGM_WrongAnswer.MP3";
                transitionTimer.Start();
               
            }
        }   
    }
}
