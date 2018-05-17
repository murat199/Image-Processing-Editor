namespace Yazlab1_GoruntuIslemeEditoru
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioChannelRed = new MetroFramework.Controls.MetroRadioButton();
            this.RadioChannelBlue = new MetroFramework.Controls.MetroRadioButton();
            this.RadioChannelGreen = new MetroFramework.Controls.MetroRadioButton();
            this.BtnColorChannels = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.RadioHistogramR = new MetroFramework.Controls.MetroRadioButton();
            this.BtnHistogram = new System.Windows.Forms.Button();
            this.RadioHistogramGray = new MetroFramework.Controls.MetroRadioButton();
            this.RadioHistogramB = new MetroFramework.Controls.MetroRadioButton();
            this.RadioHistogramG = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.BtnRotateLeft = new System.Windows.Forms.Button();
            this.BtnRotateRight = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.BtnMirroringVer = new System.Windows.Forms.Button();
            this.BtnMirroringHor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnScale = new System.Windows.Forms.Button();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.TxtScalingY = new MetroFramework.Controls.MetroTextBox();
            this.TxtScalingX = new MetroFramework.Controls.MetroTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.BtnNegative = new System.Windows.Forms.Button();
            this.BtnGrayScale = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LabelMainImage = new System.Windows.Forms.Label();
            this.BtnReOpen = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDoRedo = new System.Windows.Forms.Button();
            this.BtnDoUndo = new System.Windows.Forms.Button();
            this.PictureBoxMainIco = new System.Windows.Forms.PictureBox();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FrMetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToggleTheme = new MetroFramework.Controls.MetroToggle();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStripMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMainIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrMetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.BackColor = System.Drawing.Color.Transparent;
            this.MenuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStripMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.MenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.MenuHelp,
            this.MenuAboutUs});
            this.MenuStripMain.Location = new System.Drawing.Point(2, 8);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Padding = new System.Windows.Forms.Padding(0);
            this.MenuStripMain.Size = new System.Drawing.Size(246, 24);
            this.MenuStripMain.TabIndex = 1;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.toolStripSeparator6,
            this.MenuSave,
            this.toolStripSeparator7,
            this.MenuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem1.Text = "Dosya";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Image = ((System.Drawing.Image)(resources.GetObject("MenuOpen.Image")));
            this.MenuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(160, 22);
            this.MenuOpen.Text = "&Aç (Ctrl + O)";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuSave
            // 
            this.MenuSave.Image = ((System.Drawing.Image)(resources.GetObject("MenuSave.Image")));
            this.MenuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(160, 22);
            this.MenuSave.Text = "&Kaydet (Ctrl + S)";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(160, 22);
            this.MenuExit.Text = "Çıkış (Ctrl + E)";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUndo,
            this.MenuRedo});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(56, 24);
            this.toolStripMenuItem6.Text = "&Araçlar";
            // 
            // MenuUndo
            // 
            this.MenuUndo.Enabled = false;
            this.MenuUndo.Name = "MenuUndo";
            this.MenuUndo.Size = new System.Drawing.Size(160, 22);
            this.MenuUndo.Text = "&Geri Al (Ctrl + Z)";
            this.MenuUndo.Click += new System.EventHandler(this.MenuUndo_Click);
            // 
            // MenuRedo
            // 
            this.MenuRedo.Enabled = false;
            this.MenuRedo.Name = "MenuRedo";
            this.MenuRedo.Size = new System.Drawing.Size(160, 22);
            this.MenuRedo.Text = "&İleri Al (Ctrl + Y)";
            this.MenuRedo.Click += new System.EventHandler(this.MenuRedo_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(56, 24);
            this.MenuHelp.Text = "Yardım";
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // MenuAboutUs
            // 
            this.MenuAboutUs.Name = "MenuAboutUs";
            this.MenuAboutUs.Size = new System.Drawing.Size(81, 24);
            this.MenuAboutUs.Text = "&Hakkımızda";
            this.MenuAboutUs.Click += new System.EventHandler(this.MenuAboutUs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RadioChannelRed);
            this.groupBox2.Controls.Add(this.RadioChannelBlue);
            this.groupBox2.Controls.Add(this.RadioChannelGreen);
            this.groupBox2.Controls.Add(this.BtnColorChannels);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(649, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(210, 135);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Kanalları";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RadioChannelRed
            // 
            this.RadioChannelRed.AutoSize = true;
            this.RadioChannelRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioChannelRed.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RadioChannelRed.Location = new System.Drawing.Point(19, 42);
            this.RadioChannelRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioChannelRed.Name = "RadioChannelRed";
            this.RadioChannelRed.Size = new System.Drawing.Size(65, 19);
            this.RadioChannelRed.TabIndex = 28;
            this.RadioChannelRed.TabStop = true;
            this.RadioChannelRed.Text = "Kırmızı";
            this.RadioChannelRed.UseVisualStyleBackColor = true;
            // 
            // RadioChannelBlue
            // 
            this.RadioChannelBlue.AutoSize = true;
            this.RadioChannelBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioChannelBlue.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RadioChannelBlue.Location = new System.Drawing.Point(18, 85);
            this.RadioChannelBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioChannelBlue.Name = "RadioChannelBlue";
            this.RadioChannelBlue.Size = new System.Drawing.Size(55, 19);
            this.RadioChannelBlue.TabIndex = 28;
            this.RadioChannelBlue.TabStop = true;
            this.RadioChannelBlue.Text = "Mavi";
            this.RadioChannelBlue.UseVisualStyleBackColor = true;
            // 
            // RadioChannelGreen
            // 
            this.RadioChannelGreen.AutoSize = true;
            this.RadioChannelGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioChannelGreen.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RadioChannelGreen.Location = new System.Drawing.Point(18, 63);
            this.RadioChannelGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioChannelGreen.Name = "RadioChannelGreen";
            this.RadioChannelGreen.Size = new System.Drawing.Size(51, 19);
            this.RadioChannelGreen.TabIndex = 27;
            this.RadioChannelGreen.TabStop = true;
            this.RadioChannelGreen.Text = "Yeşil";
            this.RadioChannelGreen.UseVisualStyleBackColor = true;
            // 
            // BtnColorChannels
            // 
            this.BtnColorChannels.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnColorChannels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnColorChannels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorChannels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColorChannels.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BtnColorChannels.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_ok;
            this.BtnColorChannels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnColorChannels.Location = new System.Drawing.Point(89, 51);
            this.BtnColorChannels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnColorChannels.Name = "BtnColorChannels";
            this.BtnColorChannels.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.BtnColorChannels.Size = new System.Drawing.Size(103, 48);
            this.BtnColorChannels.TabIndex = 25;
            this.BtnColorChannels.Text = "Uygula";
            this.BtnColorChannels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnColorChannels, "Renk kanalını uygula");
            this.BtnColorChannels.UseVisualStyleBackColor = false;
            this.BtnColorChannels.Click += new System.EventHandler(this.BtnColorChannels_Click);
            this.BtnColorChannels.MouseEnter += new System.EventHandler(this.BtnColorChannels_MouseEnter);
            this.BtnColorChannels.MouseLeave += new System.EventHandler(this.BtnColorChannels_MouseLeave);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.RadioHistogramR);
            this.groupBox7.Controls.Add(this.BtnHistogram);
            this.groupBox7.Controls.Add(this.RadioHistogramGray);
            this.groupBox7.Controls.Add(this.RadioHistogramB);
            this.groupBox7.Controls.Add(this.RadioHistogramG);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox7.Location = new System.Drawing.Point(878, 70);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(204, 135);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Histogram";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // RadioHistogramR
            // 
            this.RadioHistogramR.AutoSize = true;
            this.RadioHistogramR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioHistogramR.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RadioHistogramR.Location = new System.Drawing.Point(14, 32);
            this.RadioHistogramR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioHistogramR.Name = "RadioHistogramR";
            this.RadioHistogramR.Size = new System.Drawing.Size(65, 19);
            this.RadioHistogramR.TabIndex = 27;
            this.RadioHistogramR.TabStop = true;
            this.RadioHistogramR.Text = "Kırmızı";
            this.RadioHistogramR.UseVisualStyleBackColor = true;
            // 
            // BtnHistogram
            // 
            this.BtnHistogram.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnHistogram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnHistogram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistogram.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHistogram.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_ok;
            this.BtnHistogram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistogram.Location = new System.Drawing.Point(86, 51);
            this.BtnHistogram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnHistogram.Name = "BtnHistogram";
            this.BtnHistogram.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.BtnHistogram.Size = new System.Drawing.Size(106, 48);
            this.BtnHistogram.TabIndex = 26;
            this.BtnHistogram.Text = "Uygula";
            this.BtnHistogram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnHistogram, "Seçili rengin histogramını göster");
            this.BtnHistogram.UseVisualStyleBackColor = false;
            this.BtnHistogram.Click += new System.EventHandler(this.BtnHistogram_Click);
            this.BtnHistogram.MouseEnter += new System.EventHandler(this.BtnHistogram_MouseEnter);
            this.BtnHistogram.MouseLeave += new System.EventHandler(this.BtnHistogram_MouseLeave);
            // 
            // RadioHistogramGray
            // 
            this.RadioHistogramGray.AutoSize = true;
            this.RadioHistogramGray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioHistogramGray.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RadioHistogramGray.Location = new System.Drawing.Point(13, 97);
            this.RadioHistogramGray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioHistogramGray.Name = "RadioHistogramGray";
            this.RadioHistogramGray.Size = new System.Drawing.Size(43, 19);
            this.RadioHistogramGray.TabIndex = 3;
            this.RadioHistogramGray.TabStop = true;
            this.RadioHistogramGray.Text = "Gri";
            this.RadioHistogramGray.UseVisualStyleBackColor = true;
            // 
            // RadioHistogramB
            // 
            this.RadioHistogramB.AutoSize = true;
            this.RadioHistogramB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioHistogramB.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RadioHistogramB.Location = new System.Drawing.Point(13, 75);
            this.RadioHistogramB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioHistogramB.Name = "RadioHistogramB";
            this.RadioHistogramB.Size = new System.Drawing.Size(55, 19);
            this.RadioHistogramB.TabIndex = 2;
            this.RadioHistogramB.TabStop = true;
            this.RadioHistogramB.Text = "Mavi";
            this.RadioHistogramB.UseVisualStyleBackColor = true;
            // 
            // RadioHistogramG
            // 
            this.RadioHistogramG.AutoSize = true;
            this.RadioHistogramG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioHistogramG.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RadioHistogramG.Location = new System.Drawing.Point(13, 53);
            this.RadioHistogramG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioHistogramG.Name = "RadioHistogramG";
            this.RadioHistogramG.Size = new System.Drawing.Size(51, 19);
            this.RadioHistogramG.TabIndex = 1;
            this.RadioHistogramG.TabStop = true;
            this.RadioHistogramG.Text = "Yeşil";
            this.RadioHistogramG.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.BtnRotateLeft);
            this.groupBox11.Controls.Add(this.BtnRotateRight);
            this.groupBox11.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox11.Location = new System.Drawing.Point(649, 222);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox11.Size = new System.Drawing.Size(210, 124);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Döndürme";
            this.groupBox11.Enter += new System.EventHandler(this.groupBox11_Enter);
            // 
            // BtnRotateLeft
            // 
            this.BtnRotateLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRotateLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateLeft.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BtnRotateLeft.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_rotate_left;
            this.BtnRotateLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRotateLeft.Location = new System.Drawing.Point(26, 35);
            this.BtnRotateLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRotateLeft.Name = "BtnRotateLeft";
            this.BtnRotateLeft.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRotateLeft.Size = new System.Drawing.Size(74, 70);
            this.BtnRotateLeft.TabIndex = 21;
            this.BtnRotateLeft.Text = "Sol";
            this.BtnRotateLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnRotateLeft, "Sola döndür");
            this.BtnRotateLeft.UseVisualStyleBackColor = false;
            this.BtnRotateLeft.Click += new System.EventHandler(this.BtnRotateLeft_Click);
            this.BtnRotateLeft.MouseEnter += new System.EventHandler(this.BtnRotateLeft_MouseEnter);
            this.BtnRotateLeft.MouseLeave += new System.EventHandler(this.BtnRotateLeft_MouseLeave);
            // 
            // BtnRotateRight
            // 
            this.BtnRotateRight.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRotateRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateRight.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BtnRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("BtnRotateRight.Image")));
            this.BtnRotateRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRotateRight.Location = new System.Drawing.Point(113, 35);
            this.BtnRotateRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRotateRight.Name = "BtnRotateRight";
            this.BtnRotateRight.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRotateRight.Size = new System.Drawing.Size(74, 70);
            this.BtnRotateRight.TabIndex = 22;
            this.BtnRotateRight.Text = "Sağ";
            this.BtnRotateRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnRotateRight, "Sağa döndür");
            this.BtnRotateRight.UseVisualStyleBackColor = false;
            this.BtnRotateRight.Click += new System.EventHandler(this.BtnRotateRight_Click);
            this.BtnRotateRight.MouseEnter += new System.EventHandler(this.BtnRotateRight_MouseEnter);
            this.BtnRotateRight.MouseLeave += new System.EventHandler(this.BtnRotateRight_MouseLeave);
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.BtnMirroringVer);
            this.groupBox12.Controls.Add(this.BtnMirroringHor);
            this.groupBox12.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox12.Location = new System.Drawing.Point(878, 222);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox12.Size = new System.Drawing.Size(204, 124);
            this.groupBox12.TabIndex = 15;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Aynalama";
            // 
            // BtnMirroringVer
            // 
            this.BtnMirroringVer.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnMirroringVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMirroringVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMirroringVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMirroringVer.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BtnMirroringVer.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_mirror_horizontal;
            this.BtnMirroringVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMirroringVer.Location = new System.Drawing.Point(22, 33);
            this.BtnMirroringVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMirroringVer.Name = "BtnMirroringVer";
            this.BtnMirroringVer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMirroringVer.Size = new System.Drawing.Size(74, 70);
            this.BtnMirroringVer.TabIndex = 19;
            this.BtnMirroringVer.Text = "Düşey";
            this.BtnMirroringVer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnMirroringVer, "Düşey aynala");
            this.BtnMirroringVer.UseVisualStyleBackColor = false;
            this.BtnMirroringVer.Click += new System.EventHandler(this.BtnMirroringVer_Click);
            this.BtnMirroringVer.MouseEnter += new System.EventHandler(this.BtnMirroringVer_MouseEnter);
            this.BtnMirroringVer.MouseLeave += new System.EventHandler(this.BtnMirroringVer_MouseLeave);
            // 
            // BtnMirroringHor
            // 
            this.BtnMirroringHor.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnMirroringHor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMirroringHor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMirroringHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMirroringHor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMirroringHor.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_mirror_vertical;
            this.BtnMirroringHor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMirroringHor.Location = new System.Drawing.Point(110, 33);
            this.BtnMirroringHor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMirroringHor.Name = "BtnMirroringHor";
            this.BtnMirroringHor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMirroringHor.Size = new System.Drawing.Size(74, 70);
            this.BtnMirroringHor.TabIndex = 20;
            this.BtnMirroringHor.Text = "Yatay";
            this.BtnMirroringHor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnMirroringHor, "Yatay aynala");
            this.BtnMirroringHor.UseVisualStyleBackColor = false;
            this.BtnMirroringHor.Click += new System.EventHandler(this.BtnMirroringHor_Click);
            this.BtnMirroringHor.MouseEnter += new System.EventHandler(this.BtnMirroringHor_MouseEnter);
            this.BtnMirroringHor.MouseLeave += new System.EventHandler(this.BtnMirroringHor_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnScale);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.TxtScalingY);
            this.groupBox1.Controls.Add(this.TxtScalingX);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(649, 361);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(210, 141);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ölçeklendirme";
            // 
            // BtnScale
            // 
            this.BtnScale.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScale.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BtnScale.ForeColor = System.Drawing.Color.Black;
            this.BtnScale.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_ok;
            this.BtnScale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScale.Location = new System.Drawing.Point(24, 84);
            this.BtnScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnScale.Name = "BtnScale";
            this.BtnScale.Padding = new System.Windows.Forms.Padding(22, 4, 22, 4);
            this.BtnScale.Size = new System.Drawing.Size(166, 39);
            this.BtnScale.TabIndex = 29;
            this.BtnScale.Text = "Ölçeklendir";
            this.BtnScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnScale, "Resmi ölçeklendir");
            this.BtnScale.UseVisualStyleBackColor = false;
            this.BtnScale.Click += new System.EventHandler(this.BtnScale_Click);
            this.BtnScale.MouseEnter += new System.EventHandler(this.BtnScale_MouseEnter);
            this.BtnScale.MouseLeave += new System.EventHandler(this.BtnScale_MouseLeave);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(18, 51);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(67, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Yükseklik :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(18, 25);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(67, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Genişlik   :";
            // 
            // TxtScalingY
            // 
            this.TxtScalingY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtScalingY.Location = new System.Drawing.Point(92, 51);
            this.TxtScalingY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtScalingY.Name = "TxtScalingY";
            this.TxtScalingY.Size = new System.Drawing.Size(98, 19);
            this.TxtScalingY.TabIndex = 4;
            this.TxtScalingY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtScalingY_KeyPress);
            // 
            // TxtScalingX
            // 
            this.TxtScalingX.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtScalingX.Location = new System.Drawing.Point(92, 25);
            this.TxtScalingX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtScalingX.Name = "TxtScalingX";
            this.TxtScalingX.Size = new System.Drawing.Size(98, 19);
            this.TxtScalingX.TabIndex = 3;
            this.TxtScalingX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtScalingX_KeyPress);
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.BtnNegative);
            this.groupBox9.Controls.Add(this.BtnGrayScale);
            this.groupBox9.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox9.Location = new System.Drawing.Point(878, 361);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox9.Size = new System.Drawing.Size(204, 141);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Resim İşlemleri";
            // 
            // BtnNegative
            // 
            this.BtnNegative.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnNegative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNegative.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BtnNegative.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNegative.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_negative;
            this.BtnNegative.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNegative.Location = new System.Drawing.Point(20, 84);
            this.BtnNegative.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNegative.Name = "BtnNegative";
            this.BtnNegative.Padding = new System.Windows.Forms.Padding(19, 4, 45, 4);
            this.BtnNegative.Size = new System.Drawing.Size(166, 41);
            this.BtnNegative.TabIndex = 31;
            this.BtnNegative.Text = "Negatif";
            this.BtnNegative.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnNegative, "Resmi negatif yap");
            this.BtnNegative.UseVisualStyleBackColor = false;
            this.BtnNegative.Click += new System.EventHandler(this.BtnNegative_Click);
            this.BtnNegative.MouseEnter += new System.EventHandler(this.BtnNegative_MouseEnter);
            this.BtnNegative.MouseLeave += new System.EventHandler(this.BtnNegative_MouseLeave);
            // 
            // BtnGrayScale
            // 
            this.BtnGrayScale.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnGrayScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGrayScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrayScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrayScale.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BtnGrayScale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGrayScale.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_grayscale;
            this.BtnGrayScale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGrayScale.Location = new System.Drawing.Point(20, 31);
            this.BtnGrayScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGrayScale.Name = "BtnGrayScale";
            this.BtnGrayScale.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.BtnGrayScale.Size = new System.Drawing.Size(166, 39);
            this.BtnGrayScale.TabIndex = 30;
            this.BtnGrayScale.Text = "Gri Tonlama";
            this.BtnGrayScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnGrayScale, "Gri tonlamayı uygula");
            this.BtnGrayScale.UseVisualStyleBackColor = false;
            this.BtnGrayScale.Click += new System.EventHandler(this.BtnGrayScale_Click);
            this.BtnGrayScale.MouseEnter += new System.EventHandler(this.BtnGrayScale_MouseEnter);
            this.BtnGrayScale.MouseLeave += new System.EventHandler(this.BtnGrayScale_MouseLeave);
            // 
            // LabelMainImage
            // 
            this.LabelMainImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMainImage.BackColor = System.Drawing.Color.Transparent;
            this.LabelMainImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMainImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelMainImage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelMainImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelMainImage.Location = new System.Drawing.Point(158, 419);
            this.LabelMainImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMainImage.Name = "LabelMainImage";
            this.LabelMainImage.Size = new System.Drawing.Size(335, 34);
            this.LabelMainImage.TabIndex = 36;
            this.LabelMainImage.Text = "Bu Alana Resim Sürükleyip Bırakabilirsiniz \r\nveya Tıklayarak Resim Seçebilirsiniz" +
    "";
            this.LabelMainImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LabelMainImage, "Resim seç");
            this.LabelMainImage.Click += new System.EventHandler(this.LabelMainImage_Click_1);
            this.LabelMainImage.MouseEnter += new System.EventHandler(this.LabelMainImage_MouseEnter);
            this.LabelMainImage.MouseLeave += new System.EventHandler(this.LabelMainImage_MouseLeave);
            // 
            // BtnReOpen
            // 
            this.BtnReOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReOpen.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnReOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReOpen.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.BtnReOpen.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_reopen;
            this.BtnReOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReOpen.Location = new System.Drawing.Point(17, 522);
            this.BtnReOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReOpen.Name = "BtnReOpen";
            this.BtnReOpen.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnReOpen.Size = new System.Drawing.Size(89, 68);
            this.BtnReOpen.TabIndex = 34;
            this.BtnReOpen.Text = "Tekrar Aç";
            this.BtnReOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnReOpen, "İlk resmi tekrar aç");
            this.BtnReOpen.UseVisualStyleBackColor = false;
            this.BtnReOpen.Click += new System.EventHandler(this.BtnReOpen_Click);
            this.BtnReOpen.MouseEnter += new System.EventHandler(this.BtnReOpen_MouseEnter);
            this.BtnReOpen.MouseLeave += new System.EventHandler(this.BtnReOpen_MouseLeave);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.BtnSave.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_save;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSave.Location = new System.Drawing.Point(548, 521);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnSave.Size = new System.Drawing.Size(85, 70);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnSave, "Kaydet");
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.BtnSave.MouseEnter += new System.EventHandler(this.BtnSave_MouseEnter);
            this.BtnSave.MouseLeave += new System.EventHandler(this.BtnSave_MouseLeave);
            // 
            // BtnDoRedo
            // 
            this.BtnDoRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDoRedo.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnDoRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDoRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoRedo.Enabled = false;
            this.BtnDoRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoRedo.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_redo;
            this.BtnDoRedo.Location = new System.Drawing.Point(330, 521);
            this.BtnDoRedo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDoRedo.Name = "BtnDoRedo";
            this.BtnDoRedo.Size = new System.Drawing.Size(55, 58);
            this.BtnDoRedo.TabIndex = 20;
            this.toolTip1.SetToolTip(this.BtnDoRedo, "İleri Al");
            this.BtnDoRedo.UseVisualStyleBackColor = false;
            this.BtnDoRedo.Click += new System.EventHandler(this.BtnDoRedo_Click);
            this.BtnDoRedo.MouseEnter += new System.EventHandler(this.BtnDoRedo_MouseEnter);
            this.BtnDoRedo.MouseLeave += new System.EventHandler(this.BtnDoRedo_MouseLeave);
            // 
            // BtnDoUndo
            // 
            this.BtnDoUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDoUndo.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnDoUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDoUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoUndo.Enabled = false;
            this.BtnDoUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoUndo.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_undo;
            this.BtnDoUndo.Location = new System.Drawing.Point(260, 521);
            this.BtnDoUndo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDoUndo.Name = "BtnDoUndo";
            this.BtnDoUndo.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.BtnDoUndo.Size = new System.Drawing.Size(55, 58);
            this.BtnDoUndo.TabIndex = 19;
            this.toolTip1.SetToolTip(this.BtnDoUndo, "Geri Al");
            this.BtnDoUndo.UseVisualStyleBackColor = false;
            this.BtnDoUndo.Click += new System.EventHandler(this.BtnDoUndo_Click);
            this.BtnDoUndo.MouseEnter += new System.EventHandler(this.BtnDoUndo_MouseEnter);
            this.BtnDoUndo.MouseLeave += new System.EventHandler(this.BtnDoUndo_MouseLeave);
            // 
            // PictureBoxMainIco
            // 
            this.PictureBoxMainIco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxMainIco.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxMainIco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxMainIco.Image = global::Yazlab1_GoruntuIslemeEditoru.Properties.Resources.ico_main;
            this.PictureBoxMainIco.Location = new System.Drawing.Point(158, 94);
            this.PictureBoxMainIco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBoxMainIco.Name = "PictureBoxMainIco";
            this.PictureBoxMainIco.Size = new System.Drawing.Size(335, 252);
            this.PictureBoxMainIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMainIco.TabIndex = 11;
            this.PictureBoxMainIco.TabStop = false;
            this.toolTip1.SetToolTip(this.PictureBoxMainIco, "Resim seç");
            this.PictureBoxMainIco.Click += new System.EventHandler(this.PictureBoxMainIco_Click);
            this.PictureBoxMainIco.MouseEnter += new System.EventHandler(this.PictureBoxMainIco_MouseEnter);
            this.PictureBoxMainIco.MouseLeave += new System.EventHandler(this.PictureBoxMainIco_MouseLeave);
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxMain.ImageLocation = "";
            this.PictureBoxMain.Location = new System.Drawing.Point(17, 70);
            this.PictureBoxMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(616, 439);
            this.PictureBoxMain.TabIndex = 2;
            this.PictureBoxMain.TabStop = false;
            this.toolTip1.SetToolTip(this.PictureBoxMain, "Resim seç");
            this.PictureBoxMain.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PictureBoxMain_LoadCompleted);
            this.PictureBoxMain.BackgroundImageChanged += new System.EventHandler(this.PictureBoxMain_BackgroundImageChanged);
            this.PictureBoxMain.Click += new System.EventHandler(this.PictureBoxMain_Click);
            this.PictureBoxMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBoxMain_DragDrop);
            this.PictureBoxMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBoxMain_DragEnter);
            this.PictureBoxMain.MouseEnter += new System.EventHandler(this.PictureBoxMain_MouseEnter);
            this.PictureBoxMain.MouseLeave += new System.EventHandler(this.PictureBoxMain_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(190, 534);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 38);
            this.label2.TabIndex = 37;
            this.label2.Text = " Geri Al \r\n(Ctrl+Z)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(394, 534);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 38);
            this.label3.TabIndex = 38;
            this.label3.Text = "  İleri Al \r\n(Ctrl + Y)";
            // 
            // FrMetroStyleManager
            // 
            this.FrMetroStyleManager.Owner = this;
            // 
            // ToggleTheme
            // 
            this.ToggleTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleTheme.AutoSize = true;
            this.ToggleTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleTheme.Location = new System.Drawing.Point(978, 551);
            this.ToggleTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToggleTheme.Name = "ToggleTheme";
            this.ToggleTheme.Size = new System.Drawing.Size(80, 17);
            this.ToggleTheme.TabIndex = 39;
            this.ToggleTheme.Text = "Off";
            this.ToggleTheme.UseVisualStyleBackColor = true;
            this.ToggleTheme.CheckedChanged += new System.EventHandler(this.ToggleTheme_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(903, 548);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Koyu Tema :";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1103, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToggleTheme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelMainImage);
            this.Controls.Add(this.BtnReOpen);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDoRedo);
            this.Controls.Add(this.BtnDoUndo);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PictureBoxMainIco);
            this.Controls.Add(this.PictureBoxMain);
            this.Controls.Add(this.MenuStripMain);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1103, 634);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "GÖRÜNTÜ İŞLEME EDİTÖRÜ";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMainIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrMetroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem MenuUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuRedo;
        private System.Windows.Forms.ToolStripMenuItem MenuAboutUs;
        private System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.PictureBox PictureBoxMainIco;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton RadioChannelRed;
        private MetroFramework.Controls.MetroRadioButton RadioChannelBlue;
        private MetroFramework.Controls.MetroRadioButton RadioChannelGreen;
        private System.Windows.Forms.Button BtnColorChannels;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroRadioButton RadioHistogramR;
        private System.Windows.Forms.Button BtnHistogram;
        private MetroFramework.Controls.MetroRadioButton RadioHistogramGray;
        private MetroFramework.Controls.MetroRadioButton RadioHistogramB;
        private MetroFramework.Controls.MetroRadioButton RadioHistogramG;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button BtnRotateLeft;
        private System.Windows.Forms.Button BtnRotateRight;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button BtnMirroringVer;
        private System.Windows.Forms.Button BtnMirroringHor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnScale;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox TxtScalingY;
        private MetroFramework.Controls.MetroTextBox TxtScalingX;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button BtnNegative;
        private System.Windows.Forms.Button BtnGrayScale;
        private System.Windows.Forms.Button BtnDoRedo;
        private System.Windows.Forms.Button BtnDoUndo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnReOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LabelMainImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroStyleManager FrMetroStyleManager;
        private MetroFramework.Controls.MetroToggle ToggleTheme;
        private System.Windows.Forms.Label label1;
    }
}