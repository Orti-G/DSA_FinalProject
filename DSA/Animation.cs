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
            _timer.Interval = 5500;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            QA gameplay = new QA(Mathematics.MathematicsQuestions(), true, true, true, true);
            gameplay.Show();
            this.Hide();
            //this.Close();
            //this.Dispose();
        }
    }
}
