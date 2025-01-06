namespace DSA
{
    partial class GrandPrize
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
            this.cashPrize_Panel = new System.Windows.Forms.PictureBox();
            this.pictureBoX_2MilGIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cashPrize_Panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoX_2MilGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // cashPrize_Panel
            // 
            this.cashPrize_Panel.BackColor = System.Drawing.Color.Transparent;
            this.cashPrize_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cashPrize_Panel.Image = global::DSA.Properties.Resources.GIF_NewCashPrize_2M;
            this.cashPrize_Panel.Location = new System.Drawing.Point(119, 653);
            this.cashPrize_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.cashPrize_Panel.Name = "cashPrize_Panel";
            this.cashPrize_Panel.Size = new System.Drawing.Size(1196, 146);
            this.cashPrize_Panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cashPrize_Panel.TabIndex = 20;
            this.cashPrize_Panel.TabStop = false;
            this.cashPrize_Panel.Click += new System.EventHandler(this.userWinnings_Click);
            // 
            // pictureBoX_2MilGIF
            // 
            this.pictureBoX_2MilGIF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoX_2MilGIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoX_2MilGIF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoX_2MilGIF.Image = global::DSA.Properties.Resources.GIF_GranPrize_p3;
            this.pictureBoX_2MilGIF.Location = new System.Drawing.Point(0, 0);
            this.pictureBoX_2MilGIF.Name = "pictureBoX_2MilGIF";
            this.pictureBoX_2MilGIF.Size = new System.Drawing.Size(1524, 871);
            this.pictureBoX_2MilGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoX_2MilGIF.TabIndex = 0;
            this.pictureBoX_2MilGIF.TabStop = false;
            // 
            // GrandPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 871);
            this.Controls.Add(this.cashPrize_Panel);
            this.Controls.Add(this.pictureBoX_2MilGIF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrandPrize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_2MillionCashPrize";
            ((System.ComponentModel.ISupportInitialize)(this.cashPrize_Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoX_2MilGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoX_2MilGIF;
        private System.Windows.Forms.PictureBox cashPrize_Panel;
    }
}