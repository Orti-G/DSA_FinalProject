namespace DSA
{
    partial class Winning
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
            this.currentMoneyGif = new System.Windows.Forms.PictureBox();
            this.backgroundGif = new System.Windows.Forms.PictureBox();
            this.btn_takeMoney = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Continue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.currentMoneyGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGif)).BeginInit();
            this.SuspendLayout();
            // 
            // currentMoneyGif
            // 
            this.currentMoneyGif.BackColor = System.Drawing.Color.Transparent;
            this.currentMoneyGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentMoneyGif.Image = global::DSA.Properties.Resources.GIF_NewCashPrize_600K;
            this.currentMoneyGif.Location = new System.Drawing.Point(1, 580);
            this.currentMoneyGif.Margin = new System.Windows.Forms.Padding(2);
            this.currentMoneyGif.Name = "currentMoneyGif";
            this.currentMoneyGif.Size = new System.Drawing.Size(1143, 129);
            this.currentMoneyGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentMoneyGif.TabIndex = 44;
            this.currentMoneyGif.TabStop = false;
            // 
            // backgroundGif
            // 
            this.backgroundGif.BackColor = System.Drawing.Color.Transparent;
            this.backgroundGif.BackgroundImage = global::DSA.Properties.Resources.GIF_Contestant1_Answering;
            this.backgroundGif.Image = global::DSA.Properties.Resources.GIF_Contestant1_Answering;
            this.backgroundGif.Location = new System.Drawing.Point(1, 1);
            this.backgroundGif.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundGif.Name = "backgroundGif";
            this.backgroundGif.Size = new System.Drawing.Size(1143, 708);
            this.backgroundGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundGif.TabIndex = 45;
            this.backgroundGif.TabStop = false;
            // 
            // btn_takeMoney
            // 
            this.btn_takeMoney.Location = new System.Drawing.Point(25, 526);
            this.btn_takeMoney.Margin = new System.Windows.Forms.Padding(2);
            this.btn_takeMoney.Name = "btn_takeMoney";
            this.btn_takeMoney.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_takeMoney.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_takeMoney.Size = new System.Drawing.Size(170, 49);
            this.btn_takeMoney.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_takeMoney.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_takeMoney.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.btn_takeMoney.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btn_takeMoney.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_takeMoney.StateCommon.Border.Rounding = 20;
            this.btn_takeMoney.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_takeMoney.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_takeMoney.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.btn_takeMoney.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_takeMoney.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.btn_takeMoney.TabIndex = 48;
            this.btn_takeMoney.Values.Text = "TAKE THE MONEY";
            this.btn_takeMoney.Click += new System.EventHandler(this.btn_takeMoney_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(990, 526);
            this.btn_Continue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Continue.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Continue.Size = new System.Drawing.Size(144, 47);
            this.btn_Continue.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Continue.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Continue.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Continue.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btn_Continue.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Continue.StateCommon.Border.Rounding = 20;
            this.btn_Continue.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Continue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.btn_Continue.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_Continue.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.btn_Continue.TabIndex = 49;
            this.btn_Continue.Values.Text = "CONTINUE";
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // Winning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSA.Properties.Resources.GIF_Contestant1_Answering;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 708);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_takeMoney);
            this.Controls.Add(this.currentMoneyGif);
            this.Controls.Add(this.backgroundGif);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Winning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Winning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentMoneyGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox currentMoneyGif;
        private System.Windows.Forms.PictureBox backgroundGif;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_takeMoney;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Continue;
    }
}