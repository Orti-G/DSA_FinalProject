using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Yung mga comment ay animation kaso nagkkaconflict sa size kaya sa final polish nalang lalagay
namespace DSA
{
    public partial class Category : Form
    {
        public static Category categoryInstance;

        private Image Math_Default = Properties.Resources.Category_Math;
        private Image Science_Default = Properties.Resources.Category_Science;
        private Image History_Default = Properties.Resources.Category_History;
        private Image Classic_Default = Properties.Resources.Format_ClassicMT;
        private Image HighRisk_Default = Properties.Resources.Format_HighRiskMT;

        private Image Math_Clicked = Properties.Resources.Category_Math_Clicked;
        private Image Science_Clicked = Properties.Resources.Category_Science_Clicked;
        private Image History_Clicked = Properties.Resources.Category_History_Clicked;
        private Image Classic_Clicked = Properties.Resources.Format_ClassicMT_Clicked;
        private Image HighRisk_Clicked = Properties.Resources.Format_HighRiskMT_Clicked;

        private Timer animationTimer;
        private Panel activePanel;
        private Panel previousPanel;
        private const int DefaultHeight = 80;
        private const int ExpandedHeight = 140;
        private const int AnimationStep = 5;
        private bool isAnimating = false; // Track animation state

        public Category()
        {
            InitializeComponent();
            animationTimer = new Timer { Interval = 2 }; // Adjust interval for smoother animation
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void btn_Math_Click(object sender, EventArgs e)
        {
            if (isAnimating) return; // Prevent interaction while animation is in progress

            btn_Math.BackgroundImage = Math_Clicked;
            btn_Science.BackgroundImage = Science_Default;
            btn_History.BackgroundImage = History_Default;

            HandlePanelSwitch(panel_Math);
        }

        private void btn_Science_Click(object sender, EventArgs e)
        {
            if (isAnimating) return; // Prevent interaction while animation is in progress

            btn_Science.BackgroundImage = Science_Clicked;
            btn_Math.BackgroundImage = Math_Default;
            btn_History.BackgroundImage = History_Default;

            HandlePanelSwitch(panel_Science);
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            if (isAnimating) return; // Prevent interaction while animation is in progress

            btn_History.BackgroundImage = History_Clicked;
            btn_Math.BackgroundImage = Math_Default;
            btn_Science.BackgroundImage = Science_Default;

            HandlePanelSwitch(panel_History);
        }

        private void HandlePanelSwitch(Panel panel)
        {
            if (activePanel == panel) return; // Do nothing if the same panel is clicked

            // Set the previous panel for collapse
            previousPanel = activePanel;

            // Set the new panel as active for expansion
            activePanel = panel;

            // Start the animation timer
            isAnimating = true;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            bool isExpanding = false;
            bool isCollapsing = false;

            // Collapse the previous panel
            if (previousPanel != null && previousPanel.Height > DefaultHeight)
            {
                previousPanel.Height -= AnimationStep;
                isCollapsing = true;
                if (previousPanel.Height <= DefaultHeight)
                {
                    previousPanel.Height = DefaultHeight;
                    previousPanel = null; // Finished collapsing
                }
            }

            // Expand the active panel only after collapsing is finished
            if (activePanel != null && previousPanel == null && activePanel.Height < ExpandedHeight)
            {
                activePanel.Height += AnimationStep;
                isExpanding = true;
                if (activePanel.Height >= ExpandedHeight)
                {
                    activePanel.Height = ExpandedHeight; // Finished expanding
                }
            }

            // Stop the timer when both actions (expanding/collapsing) are finished
            if (!isExpanding && !isCollapsing)
            {
                isAnimating = false; // Reset animation state
                animationTimer.Stop();
            }
        }

        private void btn_Classic_Click(object sender, EventArgs e)
        {
            btn_Classic.BackgroundImage = Classic_Clicked;
            btn_HighRisk.BackgroundImage = HighRisk_Default;
        }

        private void btn_HighRisk_Click(object sender, EventArgs e)
        {
            btn_HighRisk.BackgroundImage = HighRisk_Clicked;
            btn_Classic.BackgroundImage = Classic_Default;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }
    }
}
