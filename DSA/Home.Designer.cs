﻿namespace DSA
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.startButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DSA.Properties.Resources.GIF_New_HomeScreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1524, 872);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(672, 724);
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
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.Values.Text = "MECHANICS";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(643, 636);
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
            this.startButton.TabIndex = 15;
            this.startButton.Values.Text = "START";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::DSA.Properties.Resources.BG_Studio_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1524, 872);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton startButton;
    }
}

