namespace DSA
{
    partial class Character
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
            this.pictureBox_P1 = new System.Windows.Forms.PictureBox();
            this.btn_Back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Next = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel_userName = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtBox_userName = new System.Windows.Forms.TextBox();
            this.panel_P1 = new System.Windows.Forms.Panel();
            this.panel_P2 = new System.Windows.Forms.Panel();
            this.pictureBox_P2 = new System.Windows.Forms.PictureBox();
            this.panel_P3 = new System.Windows.Forms.Panel();
            this.pictureBox_P3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_userName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel_P1.SuspendLayout();
            this.panel_P2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P2)).BeginInit();
            this.panel_P3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_P1
            // 
            this.pictureBox_P1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_P1.Image = global::DSA.Properties.Resources.Character_still_P1;
            this.pictureBox_P1.Location = new System.Drawing.Point(-10, -73);
            this.pictureBox_P1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_P1.Name = "pictureBox_P1";
            this.pictureBox_P1.Size = new System.Drawing.Size(315, 474);
            this.pictureBox_P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_P1.TabIndex = 4;
            this.pictureBox_P1.TabStop = false;
            this.pictureBox_P1.Click += new System.EventHandler(this.selectCharacter1_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(49, 782);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Back.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Back.Size = new System.Drawing.Size(137, 52);
            this.btn_Back.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Back.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Back.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btn_Back.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Back.StateCommon.Border.Rounding = 20;
            this.btn_Back.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Back.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.btn_Back.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_Back.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Values.Text = "BACK";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(1347, 782);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Next.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Next.Size = new System.Drawing.Size(137, 52);
            this.btn_Next.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Next.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Next.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Next.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btn_Next.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Next.StateCommon.Border.Rounding = 20;
            this.btn_Next.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Next.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.btn_Next.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_Next.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Values.Text = "NEXT";
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // panel_userName
            // 
            this.panel_userName.BackColor = System.Drawing.Color.Transparent;
            this.panel_userName.Image = global::DSA.Properties.Resources.Panel_UserName;
            this.panel_userName.Location = new System.Drawing.Point(569, 697);
            this.panel_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_userName.Name = "panel_userName";
            this.panel_userName.Size = new System.Drawing.Size(379, 64);
            this.panel_userName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel_userName.TabIndex = 19;
            this.panel_userName.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DSA.Properties.Resources.Labels_SelectCharacter;
            this.pictureBox5.Location = new System.Drawing.Point(313, 28);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(885, 82);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::DSA.Properties.Resources.Labels_CharacterName;
            this.pictureBox6.Location = new System.Drawing.Point(456, 609);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(601, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // txtBox_userName
            // 
            this.txtBox_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.txtBox_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_userName.Font = new System.Drawing.Font("Footlight MT Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_userName.ForeColor = System.Drawing.Color.Yellow;
            this.txtBox_userName.Location = new System.Drawing.Point(602, 711);
            this.txtBox_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_userName.MaxLength = 17;
            this.txtBox_userName.Name = "txtBox_userName";
            this.txtBox_userName.Size = new System.Drawing.Size(313, 35);
            this.txtBox_userName.TabIndex = 22;
            this.txtBox_userName.Text = "Name Your Character";
            this.txtBox_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_userName.Click += new System.EventHandler(this.txtBox_userName_Click);
            // 
            // panel_P1
            // 
            this.panel_P1.BackColor = System.Drawing.Color.Transparent;
            this.panel_P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_P1.Controls.Add(this.pictureBox_P1);
            this.panel_P1.Location = new System.Drawing.Point(257, 130);
            this.panel_P1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_P1.Name = "panel_P1";
            this.panel_P1.Size = new System.Drawing.Size(313, 406);
            this.panel_P1.TabIndex = 23;
            // 
            // panel_P2
            // 
            this.panel_P2.BackColor = System.Drawing.Color.Transparent;
            this.panel_P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_P2.Controls.Add(this.pictureBox_P2);
            this.panel_P2.Location = new System.Drawing.Point(607, 127);
            this.panel_P2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_P2.Name = "panel_P2";
            this.panel_P2.Size = new System.Drawing.Size(313, 406);
            this.panel_P2.TabIndex = 24;
            // 
            // pictureBox_P2
            // 
            this.pictureBox_P2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_P2.Image = global::DSA.Properties.Resources.Character_still_P2;
            this.pictureBox_P2.Location = new System.Drawing.Point(-5, -70);
            this.pictureBox_P2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_P2.Name = "pictureBox_P2";
            this.pictureBox_P2.Size = new System.Drawing.Size(315, 474);
            this.pictureBox_P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_P2.TabIndex = 4;
            this.pictureBox_P2.TabStop = false;
            this.pictureBox_P2.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel_P3
            // 
            this.panel_P3.BackColor = System.Drawing.Color.Transparent;
            this.panel_P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_P3.Controls.Add(this.pictureBox_P3);
            this.panel_P3.Location = new System.Drawing.Point(958, 129);
            this.panel_P3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_P3.Name = "panel_P3";
            this.panel_P3.Size = new System.Drawing.Size(313, 406);
            this.panel_P3.TabIndex = 25;
            // 
            // pictureBox_P3
            // 
            this.pictureBox_P3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_P3.Image = global::DSA.Properties.Resources.Character_still_P3;
            this.pictureBox_P3.Location = new System.Drawing.Point(-10, -73);
            this.pictureBox_P3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_P3.Name = "pictureBox_P3";
            this.pictureBox_P3.Size = new System.Drawing.Size(315, 474);
            this.pictureBox_P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_P3.TabIndex = 4;
            this.pictureBox_P3.TabStop = false;
            this.pictureBox_P3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DSA.Properties.Resources.BG_studio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1524, 871);
            this.Controls.Add(this.panel_P3);
            this.Controls.Add(this.panel_P2);
            this.Controls.Add(this.panel_P1);
            this.Controls.Add(this.txtBox_userName);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.panel_userName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Character";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Character_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_userName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel_P1.ResumeLayout(false);
            this.panel_P2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P2)).EndInit();
            this.panel_P3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_P1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Back;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Next;
        private System.Windows.Forms.PictureBox panel_userName;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtBox_userName;
        private System.Windows.Forms.Panel panel_P1;
        private System.Windows.Forms.Panel panel_P2;
        private System.Windows.Forms.PictureBox pictureBox_P2;
        private System.Windows.Forms.Panel panel_P3;
        private System.Windows.Forms.PictureBox pictureBox_P3;
    }
}