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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StartBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TaskBar = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RandomGenerateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ManualGenerateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NumberOfElementTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3.SuspendLayout();
            this.TaskBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel3.Controls.Add(this.StartBtn);
            this.panel3.Location = new System.Drawing.Point(206, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 62);
            this.panel3.TabIndex = 1;
            // 
            // StartBtn
            // 
            this.StartBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.BorderRadius = 0;
            this.StartBtn.ButtonText = "Start";
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.DisabledColor = System.Drawing.Color.Gray;
            this.StartBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.StartBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("StartBtn.Iconimage")));
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
            this.StartBtn.Location = new System.Drawing.Point(246, 11);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StartBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.StartBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.StartBtn.selected = false;
            this.StartBtn.Size = new System.Drawing.Size(121, 48);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBtn.Textcolor = System.Drawing.Color.White;
            this.StartBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // TaskBar
            // 
            this.TaskBar.BackColor = System.Drawing.Color.Gray;
            this.TaskBar.Controls.Add(this.bunifuFlatButton4);
            this.TaskBar.Location = new System.Drawing.Point(206, 0);
            this.TaskBar.Name = "TaskBar";
            this.TaskBar.Size = new System.Drawing.Size(792, 27);
            this.TaskBar.TabIndex = 1;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Random Generate";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(752, 0);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(43, 27);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "Random Generate";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Location = new System.Drawing.Point(206, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 303);
            this.panel4.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 13);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Simulation Algorithm";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 682);
            this.Controls.Add(this.NumberOfElementTxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ManualGenerateBtn);
            this.Controls.Add(this.RandomGenerateBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TaskBar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.TaskBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton RandomGenerateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ManualGenerateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox NumberOfElementTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}

