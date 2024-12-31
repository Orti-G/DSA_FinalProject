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
        private Panel panelToResize;
        private Size targetSize;
        private Panel[] panels;
        private Point[] targetLocations;
        private int animationSpeed = 10; // Controls animation speed

        public Category()
        {
            InitializeComponent();

            /*// Initialize panels and their default properties
            panel_Math.Location = new Point(441, 123);
            panel_Math.Size = new Size(639, 103);

            panel_Science.Location = new Point(441, 232);
            panel_Science.Size = new Size(639, 103);

            panel_History.Location = new Point(441, 341);
            panel_History.Size = new Size(639, 103);

            panels = new Panel[] { panel_Math, panel_Science, panel_History };

            // Initialize timer for animations
            animationTimer = new Timer();
            animationTimer.Interval = 15; // Smoothness of animation
            animationTimer.Tick += AnimatePanels;*/
        }

        private void btn_Math_Click(object sender, EventArgs e)
        {
           /* SetAnimation(panel_Math, new Size(639, 179), new Point[]
            {
            new Point(441, 302),
            new Point(441, 411)
            });*/

            btn_Math.BackgroundImage = Math_Clicked;
            btn_Science.BackgroundImage = Science_Default;
            btn_History.BackgroundImage = History_Default;
        }

        private void btn_Science_Click(object sender, EventArgs e)
        {
           /* SetAnimation(panel_Science, new Size(639, 179), new Point[]
            {
            new Point(441, 123),
            new Point(440, 416)
            });*/

            btn_Science.BackgroundImage = Science_Clicked;
            btn_Math.BackgroundImage = Math_Default;
            btn_History.BackgroundImage = History_Default;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
           /* if (btn_Math.BackgroundImage == Math_Clicked)
            {
                SetAnimation(panel_Math, new Size(639, 103), null); // Reset panel_Math to its default size
            }

            // Move panel_Science to its new location (if it was previously clicked)
            if (btn_Science.BackgroundImage == Science_Clicked)
            {
                SetAnimation(panel_Science, new Size(639, 103), new Point[]
                {
            new Point(441, 233) // Move panel_Science to (441, 233)
                });
            }

            // Move panel_History to (441, 342) and resize to (639, 179)
            SetAnimation(panel_History, new Size(639, 179), new Point[]
            {
        new Point(440, 342) // Move panel_History to (441, 342)
            });
*/
            // Update button background images
            btn_History.BackgroundImage = History_Clicked;
            btn_Math.BackgroundImage = Math_Default;
            btn_Science.BackgroundImage = Science_Default;
        }

        private void SetAnimation(Panel resizePanel, Size newSize, Point[] newLocations)
        {
            panelToResize = resizePanel;
            targetSize = newSize;

            // Check if newLocations has valid data
            if (newLocations != null)
            {
                targetLocations = new Point[panels.Length - 1];
                int index = 0;

                foreach (Panel panel in panels)
                {
                    if (panel != resizePanel && index < newLocations.Length)
                    {
                        targetLocations[index] = newLocations[index];
                        index++;
                    }
                }
            }
            else
            {
                targetLocations = Array.Empty<Point>(); // No animation for other panels
            }

            animationTimer.Start();
        }

        private void AnimatePanels(object sender, EventArgs e)
        {
            bool resizingDone = true, movingDone = true;

            // Resize the active panel
            if (panelToResize.Size != targetSize)
            {
                resizingDone = false;
                int widthStep = (targetSize.Width - panelToResize.Width) / animationSpeed;
                int heightStep = (targetSize.Height - panelToResize.Height) / animationSpeed;

                panelToResize.Size = new Size(
                    panelToResize.Width + widthStep,
                    panelToResize.Height + heightStep
                );

                // Correct final size
                if (Math.Abs(targetSize.Width - panelToResize.Width) < Math.Abs(widthStep))
                    panelToResize.Width = targetSize.Width;
                if (Math.Abs(targetSize.Height - panelToResize.Height) < Math.Abs(heightStep))
                    panelToResize.Height = targetSize.Height;
            }

            // Move other panels
            int index = 0;
            foreach (Panel panel in panels)
            {
                if (panel != panelToResize && index < targetLocations.Length)
                {
                    if (panel.Location != targetLocations[index])
                    {
                        movingDone = false;
                        int xStep = (targetLocations[index].X - panel.Location.X) / animationSpeed;
                        int yStep = (targetLocations[index].Y - panel.Location.Y) / animationSpeed;

                        panel.Location = new Point(
                            panel.Location.X + xStep,
                            panel.Location.Y + yStep
                        );

                        // Correct final position
                        if (Math.Abs(targetLocations[index].X - panel.Location.X) < Math.Abs(xStep))
                            panel.Location = new Point(targetLocations[index].X, panel.Location.Y);
                        if (Math.Abs(targetLocations[index].Y - panel.Location.Y) < Math.Abs(yStep))
                            panel.Location = new Point(panel.Location.X, targetLocations[index].Y);
                    }
                    index++;
                }
            }

            // Stop timer when animation is complete
            if (resizingDone && movingDone)
            {
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
