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
            this.IntroPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.IntroPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // IntroPlayer
            // 
            this.IntroPlayer.Enabled = true;
            this.IntroPlayer.Location = new System.Drawing.Point(-45, 0);
            this.IntroPlayer.Name = "IntroPlayer";
            this.IntroPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("IntroPlayer.OcxState")));
            this.IntroPlayer.Size = new System.Drawing.Size(1629, 919);
            this.IntroPlayer.TabIndex = 0;
            this.IntroPlayer.Enter += new System.EventHandler(this.IntroPlayer_Enter_2);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1536, 844);
            this.Controls.Add(this.IntroPlayer);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.Introduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IntroPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer IntroPlayer;
    }
}