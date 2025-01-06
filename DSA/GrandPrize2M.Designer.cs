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
            this.userWinnings2M = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BGM = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.userWinnings2M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BGM)).BeginInit();
            this.SuspendLayout();
            // 
            // userWinnings2M
            // 
            this.userWinnings2M.BackColor = System.Drawing.Color.Transparent;
            this.userWinnings2M.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userWinnings2M.Image = global::DSA.Properties.Resources.GIF_NewCashPrize_2M;
            this.userWinnings2M.Location = new System.Drawing.Point(235, 672);
            this.userWinnings2M.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userWinnings2M.Name = "userWinnings2M";
            this.userWinnings2M.Size = new System.Drawing.Size(1023, 134);
            this.userWinnings2M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userWinnings2M.TabIndex = 20;
            this.userWinnings2M.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1524, 871);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BGM);
            this.panel1.Location = new System.Drawing.Point(78, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 215);
            this.panel1.TabIndex = 48;
            this.panel1.Visible = false;
            // 
            // BGM
            // 
            this.BGM.Enabled = true;
            this.BGM.Location = new System.Drawing.Point(57, 33);
            this.BGM.Name = "BGM";
            this.BGM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BGM.OcxState")));
            this.BGM.Size = new System.Drawing.Size(75, 134);
            this.BGM.TabIndex = 0;
            // 
            // GrandPrize2M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 871);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userWinnings2M);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GrandPrize2M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrandPrize2M";
            this.Load += new System.EventHandler(this.GrandPrize2M_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userWinnings2M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BGM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox userWinnings2M;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer BGM;
    }
}