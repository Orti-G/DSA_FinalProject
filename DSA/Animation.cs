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
    public partial class Animation : Form
    {
        private Timer _timer;
        public Animation()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 4000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            BeforeQA beforeQA = new BeforeQA();
            BeforeQA.instanceBQA = beforeQA;
            this.Close();
            this.Dispose();

            if (Category.categoryName == "Math")
            {
                QA gameplay = new QA(Mathematics.MathematicsQuestions(), true, true, true, true);
                beforeQA.TopMost = true;
                beforeQA.Show();
                gameplay.Show();
                gameplay = null;
            }
            else if (Category.categoryName == "Science")
            {
                QA gameplay = new QA(Science.ScienceQuestions(), true, true, true, true);
                beforeQA.TopMost = true;
                beforeQA.Show();
                gameplay.Show();
                gameplay = null;
            }
            else 
            {
                QA gameplay = new QA(History.HistoryQuestions(), true, true, true, true);
                beforeQA.TopMost = true;
                beforeQA.Show();
                gameplay.Show();
                gameplay = null;
            }

            beforeQA = null;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
