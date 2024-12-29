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
            this.IntroPlayer.Location = new System.Drawing.Point(-1, -2);
            this.IntroPlayer.Name = "IntroPlayer";
            this.IntroPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("IntroPlayer.OcxState")));
            this.IntroPlayer.Size = new System.Drawing.Size(1394, 792);
            this.IntroPlayer.TabIndex = 18;
            this.IntroPlayer.Enter += new System.EventHandler(this.IntroPlayer_Enter);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 745);
            this.Controls.Add(this.IntroPlayer);
            this.Name = "Introduction";
            this.Text = "Introduction";
            ((System.ComponentModel.ISupportInitialize)(this.IntroPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer IntroPlayer;
    }
}