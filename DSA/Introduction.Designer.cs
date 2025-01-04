namespace DSA
{
    partial class Introduction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.startButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.IntroVid = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntroVid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::DSA.Properties.Resources.BG_Studio_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.IntroVid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1055);
            this.panel1.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(707, 759);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton1.Size = new System.Drawing.Size(192, 41);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Copperplate Std 31 AB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonButton1.TabIndex = 18;
            this.kryptonButton1.Values.Text = "MECHANICS";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(678, 671);
            this.startButton.Name = "startButton";
            this.startButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Blue;
            this.startButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Navy;
            this.startButton.Size = new System.Drawing.Size(247, 82);
            this.startButton.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.startButton.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.startButton.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.startButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startButton.StateCommon.Border.Rounding = 20;
            this.startButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.startButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Copperplate Std 31 AB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.startButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.StatePressed.Border.Color2 = System.Drawing.Color.Olive;
            this.startButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startButton.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.startButton.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.startButton.TabIndex = 17;
            this.startButton.Values.Text = "START";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // IntroVid
            // 
            this.IntroVid.Enabled = true;
            this.IntroVid.Location = new System.Drawing.Point(-38, -7);
            this.IntroVid.Name = "IntroVid";
            this.IntroVid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("IntroVid.OcxState")));
            this.IntroVid.Size = new System.Drawing.Size(1351, 806);
            this.IntroVid.TabIndex = 0;
            this.IntroVid.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.Introduction_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntroVid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer IntroVid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton startButton;
    }
}