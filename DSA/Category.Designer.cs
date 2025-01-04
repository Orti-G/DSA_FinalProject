namespace DSA
{
    partial class Category
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
            this.btn_Classic = new System.Windows.Forms.PictureBox();
            this.btn_Math = new System.Windows.Forms.PictureBox();
            this.panel_Math = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Next = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_HighRisk = new System.Windows.Forms.PictureBox();
            this.panel_Science = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Science = new System.Windows.Forms.PictureBox();
            this.panel_History = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_History = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Space2 = new System.Windows.Forms.Panel();
            this.panel_Space1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Classic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Math)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Math)).BeginInit();
            this.panel_Math.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_HighRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Science)).BeginInit();
            this.panel_Science.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Science)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_History)).BeginInit();
            this.panel_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_History)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Classic
            // 
            this.btn_Classic.BackgroundImage = global::DSA.Properties.Resources.Format_ClassicMT;
            this.btn_Classic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Classic.Location = new System.Drawing.Point(356, 666);
            this.btn_Classic.Name = "btn_Classic";
            this.btn_Classic.Size = new System.Drawing.Size(322, 98);
            this.btn_Classic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Classic.TabIndex = 11;
            this.btn_Classic.TabStop = false;
            this.btn_Classic.Click += new System.EventHandler(this.btn_Classic_Click);
            // 
            // btn_Math
            // 
            this.btn_Math.BackgroundImage = global::DSA.Properties.Resources.Category_Math;
            this.btn_Math.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Math.Location = new System.Drawing.Point(0, 0);
            this.btn_Math.Name = "btn_Math";
            this.btn_Math.Size = new System.Drawing.Size(662, 177);
            this.btn_Math.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Math.TabIndex = 6;
            this.btn_Math.TabStop = false;
            this.btn_Math.Click += new System.EventHandler(this.btn_Math_Click);
            // 
            // panel_Math
            // 
            this.panel_Math.Controls.Add(this.btn_Math);
            this.panel_Math.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Math.Location = new System.Drawing.Point(0, 0);
            this.panel_Math.Name = "panel_Math";
            this.panel_Math.Size = new System.Drawing.Size(662, 104);
            this.panel_Math.TabIndex = 16;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(29, 792);
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
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Values.Text = "BACK";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(1355, 792);
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
            this.btn_Next.TabIndex = 17;
            this.btn_Next.Values.Text = "NEXT";
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::DSA.Properties.Resources.Labels_SelectFormat;
            this.pictureBox4.Location = new System.Drawing.Point(470, 588);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(577, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::DSA.Properties.Resources.Labels_SelectCategory;
            this.pictureBox7.Location = new System.Drawing.Point(356, 31);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(815, 86);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            // 
            // btn_HighRisk
            // 
            this.btn_HighRisk.BackgroundImage = global::DSA.Properties.Resources.Format_HighRiskMT;
            this.btn_HighRisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HighRisk.Location = new System.Drawing.Point(816, 666);
            this.btn_HighRisk.Name = "btn_HighRisk";
            this.btn_HighRisk.Size = new System.Drawing.Size(322, 98);
            this.btn_HighRisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_HighRisk.TabIndex = 24;
            this.btn_HighRisk.TabStop = false;
            this.btn_HighRisk.Click += new System.EventHandler(this.btn_HighRisk_Click);
            // 
            // panel_Science
            // 
            this.panel_Science.Controls.Add(this.btn_Science);
            this.panel_Science.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Science.Location = new System.Drawing.Point(0, 120);
            this.panel_Science.Name = "panel_Science";
            this.panel_Science.Size = new System.Drawing.Size(662, 103);
            this.panel_Science.TabIndex = 17;
            // 
            // btn_Science
            // 
            this.btn_Science.BackgroundImage = global::DSA.Properties.Resources.Category_Science;
            this.btn_Science.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Science.Location = new System.Drawing.Point(0, 0);
            this.btn_Science.Name = "btn_Science";
            this.btn_Science.Size = new System.Drawing.Size(662, 177);
            this.btn_Science.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Science.TabIndex = 6;
            this.btn_Science.TabStop = false;
            this.btn_Science.Click += new System.EventHandler(this.btn_Science_Click);
            // 
            // panel_History
            // 
            this.panel_History.AllowDrop = true;
            this.panel_History.Controls.Add(this.btn_History);
            this.panel_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_History.Location = new System.Drawing.Point(0, 239);
            this.panel_History.Name = "panel_History";
            this.panel_History.Size = new System.Drawing.Size(662, 104);
            this.panel_History.TabIndex = 17;
            // 
            // btn_History
            // 
            this.btn_History.BackgroundImage = global::DSA.Properties.Resources.Category_History;
            this.btn_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_History.Location = new System.Drawing.Point(0, 0);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(665, 177);
            this.btn_History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_History.TabIndex = 6;
            this.btn_History.TabStop = false;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel_History);
            this.panel1.Controls.Add(this.panel_Space2);
            this.panel1.Controls.Add(this.panel_Science);
            this.panel1.Controls.Add(this.panel_Space1);
            this.panel1.Controls.Add(this.panel_Math);
            this.panel1.Location = new System.Drawing.Point(419, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 458);
            this.panel1.TabIndex = 25;
            // 
            // panel_Space2
            // 
            this.panel_Space2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Space2.Location = new System.Drawing.Point(0, 223);
            this.panel_Space2.Name = "panel_Space2";
            this.panel_Space2.Size = new System.Drawing.Size(662, 16);
            this.panel_Space2.TabIndex = 18;
            // 
            // panel_Space1
            // 
            this.panel_Space1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Space1.Location = new System.Drawing.Point(0, 104);
            this.panel_Space1.Name = "panel_Space1";
            this.panel_Space1.Size = new System.Drawing.Size(662, 16);
            this.panel_Space1.TabIndex = 17;
            // 
            // Category
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::DSA.Properties.Resources.BG_studio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1524, 872);
            this.Controls.Add(this.btn_Classic);
            this.Controls.Add(this.btn_HighRisk);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Classic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Math)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Math)).EndInit();
            this.panel_Math.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_HighRisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Science)).EndInit();
            this.panel_Science.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Science)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_History)).EndInit();
            this.panel_History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_History)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_Math;
        private System.Windows.Forms.PictureBox btn_Classic;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_Math;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Back;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Next;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox btn_HighRisk;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_Science;
        private System.Windows.Forms.PictureBox btn_Science;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_History;
        private System.Windows.Forms.PictureBox btn_History;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Space1;
        private System.Windows.Forms.Panel panel_Space2;
    }
}