namespace DSA
{
    partial class GrandPrize2M
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrandPrize2M));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userWinnings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWinnings)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DSA.Properties.Resources.GIF_GranPrize_P1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1524, 871);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userWinnings
            // 
            this.userWinnings.BackColor = System.Drawing.Color.Transparent;
            this.userWinnings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userWinnings.Image = ((System.Drawing.Image)(resources.GetObject("userWinnings.Image")));
            this.userWinnings.Location = new System.Drawing.Point(234, 671);
            this.userWinnings.Margin = new System.Windows.Forms.Padding(2);
            this.userWinnings.Name = "userWinnings";
            this.userWinnings.Size = new System.Drawing.Size(1023, 135);
            this.userWinnings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userWinnings.TabIndex = 20;
            this.userWinnings.TabStop = false;
            this.userWinnings.Click += new System.EventHandler(this.userWinnings_Click);
            // 
            // GrandPrize2M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 871);
            this.Controls.Add(this.userWinnings);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrandPrize2M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrandPrize2M";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWinnings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox userWinnings;
    }
}