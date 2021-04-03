namespace AlexPaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LabelCurColor = new System.Windows.Forms.Label();
            this.buttonPalette = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonPink = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelWidth = new System.Windows.Forms.Label();
            this.trackBarLineWidth = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelBrush = new System.Windows.Forms.Label();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.panelForFigures = new System.Windows.Forms.Panel();
            this.buttonPolyline = new System.Windows.Forms.Button();
            this.buttonPolygon = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipNumDeg = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCurColor = new System.Windows.Forms.ToolTip(this.components);
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineWidth)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelForFigures.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.buttonRedo);
            this.panel2.Controls.Add(this.buttonUndo);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelForFigures);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 98);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(325, 7);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 29);
            this.numericUpDown1.TabIndex = 0;
            this.toolTipNumDeg.SetToolTip(this.numericUpDown1, "количество углов в многоугольнике");
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonRedo
            // 
            this.buttonRedo.AllowDrop = true;
            this.buttonRedo.BackColor = System.Drawing.Color.White;
            this.buttonRedo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRedo.BackgroundImage")));
            this.buttonRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedo.Location = new System.Drawing.Point(91, 3);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(36, 33);
            this.buttonRedo.TabIndex = 14;
            this.buttonRedo.UseVisualStyleBackColor = false;
            // 
            // buttonUndo
            // 
            this.buttonUndo.AllowDrop = true;
            this.buttonUndo.BackColor = System.Drawing.Color.White;
            this.buttonUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUndo.BackgroundImage")));
            this.buttonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo.Location = new System.Drawing.Point(49, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(36, 33);
            this.buttonUndo.TabIndex = 11;
            this.buttonUndo.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LabelCurColor);
            this.panel5.Controls.Add(this.buttonPalette);
            this.panel5.Controls.Add(this.buttonBlack);
            this.panel5.Controls.Add(this.buttonBlue);
            this.panel5.Controls.Add(this.buttonYellow);
            this.panel5.Controls.Add(this.buttonRed);
            this.panel5.Controls.Add(this.buttonGreen);
            this.panel5.Controls.Add(this.buttonPink);
            this.panel5.Location = new System.Drawing.Point(613, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 72);
            this.panel5.TabIndex = 13;
            // 
            // LabelCurColor
            // 
            this.LabelCurColor.BackColor = System.Drawing.Color.Black;
            this.LabelCurColor.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurColor.Location = new System.Drawing.Point(122, 19);
            this.LabelCurColor.Name = "LabelCurColor";
            this.LabelCurColor.Size = new System.Drawing.Size(36, 36);
            this.LabelCurColor.TabIndex = 12;
            this.toolTipCurColor.SetToolTip(this.LabelCurColor, "Ваш цвет");
            // 
            // buttonPalette
            // 
            this.buttonPalette.AllowDrop = true;
            this.buttonPalette.BackColor = System.Drawing.Color.Snow;
            this.buttonPalette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPalette.BackgroundImage")));
            this.buttonPalette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPalette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPalette.Location = new System.Drawing.Point(164, 3);
            this.buttonPalette.Name = "buttonPalette";
            this.buttonPalette.Size = new System.Drawing.Size(68, 66);
            this.buttonPalette.TabIndex = 19;
            this.buttonPalette.UseVisualStyleBackColor = false;
            this.buttonPalette.Click += new System.EventHandler(this.buttonPalette_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.AllowDrop = true;
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlack.Location = new System.Drawing.Point(80, 37);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(36, 32);
            this.buttonBlack.TabIndex = 18;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.AllowDrop = true;
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.Location = new System.Drawing.Point(3, 3);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(36, 32);
            this.buttonBlue.TabIndex = 15;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.AllowDrop = true;
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYellow.Location = new System.Drawing.Point(80, 3);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(36, 32);
            this.buttonYellow.TabIndex = 14;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.AllowDrop = true;
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(41, 3);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(36, 32);
            this.buttonRed.TabIndex = 16;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.AllowDrop = true;
            this.buttonGreen.BackColor = System.Drawing.Color.Lime;
            this.buttonGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.Location = new System.Drawing.Point(3, 37);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(36, 32);
            this.buttonGreen.TabIndex = 13;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonPink
            // 
            this.buttonPink.AllowDrop = true;
            this.buttonPink.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPink.Location = new System.Drawing.Point(41, 37);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(36, 32);
            this.buttonPink.TabIndex = 11;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelWidth);
            this.panel4.Controls.Add(this.trackBarLineWidth);
            this.panel4.Location = new System.Drawing.Point(408, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 72);
            this.panel4.TabIndex = 1;
            // 
            // labelWidth
            // 
            this.labelWidth.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(0, 48);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(199, 24);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "выбор толщины";
            // 
            // trackBarLineWidth
            // 
            this.trackBarLineWidth.AutoSize = false;
            this.trackBarLineWidth.Location = new System.Drawing.Point(0, 9);
            this.trackBarLineWidth.Maximum = 20;
            this.trackBarLineWidth.Minimum = 1;
            this.trackBarLineWidth.Name = "trackBarLineWidth";
            this.trackBarLineWidth.Size = new System.Drawing.Size(199, 36);
            this.trackBarLineWidth.TabIndex = 0;
            this.trackBarLineWidth.Value = 1;
            this.trackBarLineWidth.Scroll += new System.EventHandler(this.trackBarLineWidth_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelBrush);
            this.panel3.Controls.Add(this.buttonBrush);
            this.panel3.Location = new System.Drawing.Point(138, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 76);
            this.panel3.TabIndex = 0;
            // 
            // labelBrush
            // 
            this.labelBrush.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrush.Location = new System.Drawing.Point(0, 52);
            this.labelBrush.Name = "labelBrush";
            this.labelBrush.Size = new System.Drawing.Size(57, 24);
            this.labelBrush.TabIndex = 1;
            this.labelBrush.Text = "кисть";
            // 
            // buttonBrush
            // 
            this.buttonBrush.AllowDrop = true;
            this.buttonBrush.BackColor = System.Drawing.Color.White;
            this.buttonBrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBrush.BackgroundImage")));
            this.buttonBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrush.Location = new System.Drawing.Point(0, 0);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(57, 49);
            this.buttonBrush.TabIndex = 11;
            this.buttonBrush.UseVisualStyleBackColor = false;
            this.buttonBrush.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonBrush_MouseClick);
            // 
            // panelForFigures
            // 
            this.panelForFigures.BackColor = System.Drawing.Color.White;
            this.panelForFigures.Controls.Add(this.buttonPolyline);
            this.panelForFigures.Controls.Add(this.buttonPolygon);
            this.panelForFigures.Controls.Add(this.buttonEllipse);
            this.panelForFigures.Controls.Add(this.buttonTriangle);
            this.panelForFigures.Controls.Add(this.buttonLine);
            this.panelForFigures.Controls.Add(this.buttonRectangle);
            this.panelForFigures.Location = new System.Drawing.Point(198, 3);
            this.panelForFigures.Name = "panelForFigures";
            this.panelForFigures.Padding = new System.Windows.Forms.Padding(9);
            this.panelForFigures.Size = new System.Drawing.Size(121, 75);
            this.panelForFigures.TabIndex = 0;
            // 
            // buttonPolyline
            // 
            this.buttonPolyline.AllowDrop = true;
            this.buttonPolyline.BackColor = System.Drawing.Color.White;
            this.buttonPolyline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPolyline.BackgroundImage")));
            this.buttonPolyline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPolyline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPolyline.Location = new System.Drawing.Point(80, 39);
            this.buttonPolyline.Name = "buttonPolyline";
            this.buttonPolyline.Size = new System.Drawing.Size(36, 33);
            this.buttonPolyline.TabIndex = 9;
            this.buttonPolyline.UseVisualStyleBackColor = false;
            this.buttonPolyline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPolyline_MouseClick);
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.AllowDrop = true;
            this.buttonPolygon.BackColor = System.Drawing.Color.White;
            this.buttonPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPolygon.BackgroundImage")));
            this.buttonPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPolygon.Location = new System.Drawing.Point(80, 3);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(36, 33);
            this.buttonPolygon.TabIndex = 8;
            this.buttonPolygon.UseVisualStyleBackColor = false;
            this.buttonPolygon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPolygon_MouseClick);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.AllowDrop = true;
            this.buttonEllipse.BackColor = System.Drawing.Color.White;
            this.buttonEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.BackgroundImage")));
            this.buttonEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse.Location = new System.Drawing.Point(3, 39);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(36, 33);
            this.buttonEllipse.TabIndex = 7;
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonEllipse_MouseClick);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.AllowDrop = true;
            this.buttonTriangle.BackColor = System.Drawing.Color.White;
            this.buttonTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTriangle.BackgroundImage")));
            this.buttonTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTriangle.Location = new System.Drawing.Point(41, 39);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(36, 33);
            this.buttonTriangle.TabIndex = 10;
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTriangle_MouseClick);
            // 
            // buttonLine
            // 
            this.buttonLine.AllowDrop = true;
            this.buttonLine.BackColor = System.Drawing.Color.White;
            this.buttonLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLine.BackgroundImage")));
            this.buttonLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Location = new System.Drawing.Point(41, 3);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(36, 33);
            this.buttonLine.TabIndex = 1;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLine_MouseClick);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.AllowDrop = true;
            this.buttonRectangle.BackColor = System.Drawing.Color.White;
            this.buttonRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.BackgroundImage")));
            this.buttonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRectangle.Location = new System.Drawing.Point(3, 3);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(36, 33);
            this.buttonRectangle.TabIndex = 6;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRectangle_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolTipNumDeg
            // 
            this.toolTipNumDeg.BackColor = System.Drawing.Color.White;
            this.toolTipNumDeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // toolTipCurColor
            // 
            this.toolTipCurColor.BackColor = System.Drawing.Color.White;
            this.toolTipCurColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(0, 126);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(1076, 637);
            this.DrawPanel.TabIndex = 4;
            this.DrawPanel.TabStop = false;
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // colorDialog
            // 
            this.colorDialog.SolidColorOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1076, 763);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineWidth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelForFigures.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox DrawPanel;

        private System.Windows.Forms.Label LabelCurColor;

        private System.Windows.Forms.ToolTip toolTipCurColor;

        private System.Windows.Forms.ToolTip toolTipNumDeg;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.Button buttonUndo;

        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonPalette;

        private System.Windows.Forms.Button buttonRed;

        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBlue;

        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar trackBarLineWidth;

        private System.Windows.Forms.Label labelBrush;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Button buttonBrush;

        private System.Windows.Forms.Button buttonPolygon;
        private System.Windows.Forms.Button buttonPolyline;
        private System.Windows.Forms.Button buttonTriangle;

        private System.Windows.Forms.Button buttonEllipse;

        private System.Windows.Forms.Button buttonRectangle;

        private System.Windows.Forms.Button buttonLine;

        private System.Windows.Forms.Panel panelForFigures;

        private System.Windows.Forms.Panel panel2;

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
    }
}