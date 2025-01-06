namespace DSA
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel_GameHistory = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DSA.Properties.Resources.Label_GameHistory;
            this.pictureBox5.Location = new System.Drawing.Point(276, 5);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(962, 98);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(32, 761);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton3.Size = new System.Drawing.Size(138, 52);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonButton3.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonButton3.TabIndex = 33;
            this.kryptonButton3.Values.Text = "BACK";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // flowLayoutPanel_GameHistory
            // 
            this.flowLayoutPanel_GameHistory.AutoScroll = true;
            this.flowLayoutPanel_GameHistory.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_GameHistory.Location = new System.Drawing.Point(292, 109);
            this.flowLayoutPanel_GameHistory.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_GameHistory.Name = "flowLayoutPanel_GameHistory";
            this.flowLayoutPanel_GameHistory.Size = new System.Drawing.Size(970, 682);
            this.flowLayoutPanel_GameHistory.TabIndex = 37;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1506, 825);
            this.Controls.Add(this.flowLayoutPanel_GameHistory);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.pictureBox5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_GameHistory;
    }
}