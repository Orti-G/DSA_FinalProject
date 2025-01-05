namespace DSA
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Restart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Home = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Start = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mechanicsVid = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicsVid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DSA.Properties.Resources.BG_Mechanics;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_Restart);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.mechanicsVid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 872);
            this.panel1.TabIndex = 0;
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(910, 737);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Restart.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Restart.Size = new System.Drawing.Size(80, 61);
            this.btn_Restart.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Restart.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Restart.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Restart.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btn_Restart.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Restart.StateCommon.Border.Rounding = 20;
            this.btn_Restart.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Restart.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Copperplate Std 31 AB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.btn_Restart.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_Restart.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.btn_Restart.TabIndex = 21;
            this.btn_Restart.Values.Text = "";
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(528, 737);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Home.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Home.Size = new System.Drawing.Size(74, 61);
            this.btn_Home.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Home.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Home.StateCommon.Back.Image = global::DSA.Properties.Resources.TRY_Icon;
            this.btn_Home.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_Home.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Home.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btn_Home.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Home.StateCommon.Border.Rounding = 20;
            this.btn_Home.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Home.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Copperplate Std 31 AB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.btn_Home.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_Home.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.btn_Home.TabIndex = 20;
            this.btn_Home.Values.Text = "";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(637, 726);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.OverrideDefault.Back.Color1 = System.Drawing.Color.Blue;
            this.btn_Start.OverrideDefault.Back.Color2 = System.Drawing.Color.Navy;
            this.btn_Start.Size = new System.Drawing.Size(247, 82);
            this.btn_Start.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.btn_Start.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_Start.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Start.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btn_Start.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Start.StateCommon.Border.Rounding = 20;
            this.btn_Start.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Start.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Copperplate Std 31 AB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.StatePressed.Back.Color1 = System.Drawing.Color.Yellow;
            this.btn_Start.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Start.StatePressed.Border.Color2 = System.Drawing.Color.Olive;
            this.btn_Start.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Start.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_Start.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.btn_Start.TabIndex = 19;
            this.btn_Start.Values.Text = "START";
            this.btn_Start.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mechanicsVid
            // 
            this.mechanicsVid.Enabled = true;
            this.mechanicsVid.Location = new System.Drawing.Point(-38, -7);
            this.mechanicsVid.Name = "mechanicsVid";
            this.mechanicsVid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mechanicsVid.OcxState")));
            this.mechanicsVid.Size = new System.Drawing.Size(1308, 787);
            this.mechanicsVid.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DSA.Properties.Resources.BG_studio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1524, 872);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mechanicsVid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer mechanicsVid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Restart;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Home;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Start;
    }
}