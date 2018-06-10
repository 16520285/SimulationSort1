namespace SimulationSortApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PauseBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.StartBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TaskBar = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NumberOfElementTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ManualGenerateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RandomGenerateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.TaskBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 684);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Choose Sort Algorithm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.bunifuFlatButton2);
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.PauseBtn);
            this.panel3.Controls.Add(this.StartBtn);
            this.panel3.Location = new System.Drawing.Point(206, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 62);
            this.panel3.TabIndex = 1;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Delete   Array";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::SimulationSortApp.Properties.Resources.trash_bin;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(488, 7);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(50, 48);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "Delete   Array";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.DeleteArrayBtn_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Debug";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::SimulationSortApp.Properties.Resources.play_and_pause_button__1_;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(407, 7);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(52, 48);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "   Debug";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Descending";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(59, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ascending";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 11);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Sort By: ";
            // 
            // PauseBtn
            // 
            this.PauseBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PauseBtn.BackColor = System.Drawing.Color.Gray;
            this.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseBtn.BorderRadius = 0;
            this.PauseBtn.ButtonText = "  Pause";
            this.PauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseBtn.DisabledColor = System.Drawing.Color.Gray;
            this.PauseBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.PauseBtn.Iconimage = global::SimulationSortApp.Properties.Resources.pause_button;
            this.PauseBtn.Iconimage_right = null;
            this.PauseBtn.Iconimage_right_Selected = null;
            this.PauseBtn.Iconimage_Selected = null;
            this.PauseBtn.IconMarginLeft = 0;
            this.PauseBtn.IconMarginRight = 0;
            this.PauseBtn.IconRightVisible = true;
            this.PauseBtn.IconRightZoom = 0D;
            this.PauseBtn.IconVisible = true;
            this.PauseBtn.IconZoom = 90D;
            this.PauseBtn.IsTab = false;
            this.PauseBtn.Location = new System.Drawing.Point(338, 7);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Normalcolor = System.Drawing.Color.Gray;
            this.PauseBtn.OnHovercolor = System.Drawing.Color.DimGray;
            this.PauseBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PauseBtn.selected = false;
            this.PauseBtn.Size = new System.Drawing.Size(51, 48);
            this.PauseBtn.TabIndex = 1;
            this.PauseBtn.Text = "  Pause";
            this.PauseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PauseBtn.Textcolor = System.Drawing.Color.White;
            this.PauseBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StartBtn.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.StartBtn.BackColor = System.Drawing.Color.Gray;
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.BorderRadius = 0;
            this.StartBtn.ButtonText = "    Start";
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.DisabledColor = System.Drawing.Color.Gray;
            this.StartBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.StartBtn.Iconimage = global::SimulationSortApp.Properties.Resources.play_button__2_;
            this.StartBtn.Iconimage_right = null;
            this.StartBtn.Iconimage_right_Selected = null;
            this.StartBtn.Iconimage_Selected = null;
            this.StartBtn.IconMarginLeft = 0;
            this.StartBtn.IconMarginRight = 0;
            this.StartBtn.IconRightVisible = true;
            this.StartBtn.IconRightZoom = 0D;
            this.StartBtn.IconVisible = true;
            this.StartBtn.IconZoom = 90D;
            this.StartBtn.IsTab = false;
            this.StartBtn.Location = new System.Drawing.Point(256, 7);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Normalcolor = System.Drawing.Color.Gray;
            this.StartBtn.OnHovercolor = System.Drawing.Color.DimGray;
            this.StartBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.StartBtn.selected = false;
            this.StartBtn.Size = new System.Drawing.Size(49, 48);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "    Start";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBtn.Textcolor = System.Drawing.Color.White;
            this.StartBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TaskBar
            // 
            this.TaskBar.BackColor = System.Drawing.Color.Gray;
            this.TaskBar.Controls.Add(this.bunifuFlatButton3);
            this.TaskBar.Controls.Add(this.bunifuFlatButton4);
            this.TaskBar.Location = new System.Drawing.Point(206, 0);
            this.TaskBar.Name = "TaskBar";
            this.TaskBar.Size = new System.Drawing.Size(792, 27);
            this.TaskBar.TabIndex = 1;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.BackgroundImage = global::SimulationSortApp.Properties.Resources.minus_circular_button;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.DarkGray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(715, 0);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(37, 27);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.TabStop = false;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click_1);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.BackgroundImage = global::SimulationSortApp.Properties.Resources.cancel_button;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.DarkGray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(758, 0);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(37, 27);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.TabStop = false;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 684);
            this.panel2.TabIndex = 1;
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ViewPanel.Controls.Add(this.bunifuCustomLabel2);
            this.ViewPanel.Location = new System.Drawing.Point(207, 150);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(792, 303);
            this.ViewPanel.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 6);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 13);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Simulation Algorithm";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(212, 43);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 13);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Number of Element: ";
            // 
            // NumberOfElementTxt
            // 
            this.NumberOfElementTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.NumberOfElementTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumberOfElementTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.NumberOfElementTxt.BorderThickness = 3;
            this.NumberOfElementTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberOfElementTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberOfElementTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumberOfElementTxt.isPassword = false;
            this.NumberOfElementTxt.Location = new System.Drawing.Point(322, 34);
            this.NumberOfElementTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfElementTxt.Name = "NumberOfElementTxt";
            this.NumberOfElementTxt.Size = new System.Drawing.Size(38, 31);
            this.NumberOfElementTxt.TabIndex = 4;
            this.NumberOfElementTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(207, 453);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(407, 229);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(613, 453);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 229);
            this.panel4.TabIndex = 7;
            // 
            // ManualGenerateBtn
            // 
            this.ManualGenerateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ManualGenerateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ManualGenerateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualGenerateBtn.BorderRadius = 0;
            this.ManualGenerateBtn.ButtonText = "Manual Generate";
            this.ManualGenerateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManualGenerateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ManualGenerateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ManualGenerateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ManualGenerateBtn.Iconimage")));
            this.ManualGenerateBtn.Iconimage_right = null;
            this.ManualGenerateBtn.Iconimage_right_Selected = null;
            this.ManualGenerateBtn.Iconimage_Selected = null;
            this.ManualGenerateBtn.IconMarginLeft = 0;
            this.ManualGenerateBtn.IconMarginRight = 0;
            this.ManualGenerateBtn.IconRightVisible = true;
            this.ManualGenerateBtn.IconRightZoom = 0D;
            this.ManualGenerateBtn.IconVisible = true;
            this.ManualGenerateBtn.IconZoom = 90D;
            this.ManualGenerateBtn.IsTab = false;
            this.ManualGenerateBtn.Location = new System.Drawing.Point(596, 58);
            this.ManualGenerateBtn.Name = "ManualGenerateBtn";
            this.ManualGenerateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ManualGenerateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ManualGenerateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ManualGenerateBtn.selected = false;
            this.ManualGenerateBtn.Size = new System.Drawing.Size(159, 30);
            this.ManualGenerateBtn.TabIndex = 2;
            this.ManualGenerateBtn.Text = "Manual Generate";
            this.ManualGenerateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualGenerateBtn.Textcolor = System.Drawing.Color.White;
            this.ManualGenerateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualGenerateBtn.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // RandomGenerateBtn
            // 
            this.RandomGenerateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.RandomGenerateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.RandomGenerateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RandomGenerateBtn.BorderRadius = 0;
            this.RandomGenerateBtn.ButtonText = "Random Generate";
            this.RandomGenerateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomGenerateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.RandomGenerateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.RandomGenerateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("RandomGenerateBtn.Iconimage")));
            this.RandomGenerateBtn.Iconimage_right = null;
            this.RandomGenerateBtn.Iconimage_right_Selected = null;
            this.RandomGenerateBtn.Iconimage_Selected = null;
            this.RandomGenerateBtn.IconMarginLeft = 0;
            this.RandomGenerateBtn.IconMarginRight = 0;
            this.RandomGenerateBtn.IconRightVisible = true;
            this.RandomGenerateBtn.IconRightZoom = 0D;
            this.RandomGenerateBtn.IconVisible = true;
            this.RandomGenerateBtn.IconZoom = 90D;
            this.RandomGenerateBtn.IsTab = false;
            this.RandomGenerateBtn.Location = new System.Drawing.Point(411, 58);
            this.RandomGenerateBtn.Name = "RandomGenerateBtn";
            this.RandomGenerateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.RandomGenerateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.RandomGenerateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.RandomGenerateBtn.selected = false;
            this.RandomGenerateBtn.Size = new System.Drawing.Size(159, 30);
            this.RandomGenerateBtn.TabIndex = 1;
            this.RandomGenerateBtn.Text = "Random Generate";
            this.RandomGenerateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RandomGenerateBtn.Textcolor = System.Drawing.Color.White;
            this.RandomGenerateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomGenerateBtn.Click += new System.EventHandler(this.RandomGenerateButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 682);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.NumberOfElementTxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ManualGenerateBtn);
            this.Controls.Add(this.RandomGenerateBtn);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.TaskBar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TaskBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ViewPanel.ResumeLayout(false);
            this.ViewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton StartBtn;
        private System.Windows.Forms.Panel TaskBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ViewPanel;
        private Bunifu.Framework.UI.BunifuFlatButton RandomGenerateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ManualGenerateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox NumberOfElementTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton PauseBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

