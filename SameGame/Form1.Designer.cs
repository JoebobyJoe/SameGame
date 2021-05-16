namespace SameGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boarderSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x20ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x30ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNumColor3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNumColor4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNumColor5 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNumColor6 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNumColor7 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeItTakes = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.boarderSizeToolStripMenuItem,
            this.imageSizeToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.reToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.reToolStripMenuItem.Text = "&Reset";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // boarderSizeToolStripMenuItem
            // 
            this.boarderSizeToolStripMenuItem.Checked = true;
            this.boarderSizeToolStripMenuItem.CheckOnClick = true;
            this.boarderSizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boarderSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x10ToolStripMenuItem,
            this.x20ToolStripMenuItem,
            this.x30ToolStripMenuItem});
            this.boarderSizeToolStripMenuItem.Name = "boarderSizeToolStripMenuItem";
            this.boarderSizeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.boarderSizeToolStripMenuItem.Text = "&Board Size";
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Checked = true;
            this.x10ToolStripMenuItem.CheckOnClick = true;
            this.x10ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.x10ToolStripMenuItem.Text = "10 X 10";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolStripMenuItem_Click);
            // 
            // x20ToolStripMenuItem
            // 
            this.x20ToolStripMenuItem.CheckOnClick = true;
            this.x20ToolStripMenuItem.Name = "x20ToolStripMenuItem";
            this.x20ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.x20ToolStripMenuItem.Text = "20 X 20";
            this.x20ToolStripMenuItem.Click += new System.EventHandler(this.x20ToolStripMenuItem_Click_1);
            // 
            // x30ToolStripMenuItem
            // 
            this.x30ToolStripMenuItem.CheckOnClick = true;
            this.x30ToolStripMenuItem.Name = "x30ToolStripMenuItem";
            this.x30ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.x30ToolStripMenuItem.Text = "30 X 30";
            this.x30ToolStripMenuItem.Click += new System.EventHandler(this.x30ToolStripMenuItem_Click);
            // 
            // imageSizeToolStripMenuItem
            // 
            this.imageSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x10ToolStripMenuItem1,
            this.x20ToolStripMenuItem1,
            this.x30ToolStripMenuItem1});
            this.imageSizeToolStripMenuItem.Name = "imageSizeToolStripMenuItem";
            this.imageSizeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.imageSizeToolStripMenuItem.Text = "&Image Size";
            // 
            // x10ToolStripMenuItem1
            // 
            this.x10ToolStripMenuItem1.CheckOnClick = true;
            this.x10ToolStripMenuItem1.Name = "x10ToolStripMenuItem1";
            this.x10ToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.x10ToolStripMenuItem1.Text = "10 X 10";
            this.x10ToolStripMenuItem1.Click += new System.EventHandler(this.x10ToolStripMenuItem1_Click);
            // 
            // x20ToolStripMenuItem1
            // 
            this.x20ToolStripMenuItem1.CheckOnClick = true;
            this.x20ToolStripMenuItem1.Name = "x20ToolStripMenuItem1";
            this.x20ToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.x20ToolStripMenuItem1.Text = "20 X 20";
            this.x20ToolStripMenuItem1.Click += new System.EventHandler(this.x20ToolStripMenuItem1_Click_1);
            // 
            // x30ToolStripMenuItem1
            // 
            this.x30ToolStripMenuItem1.Checked = true;
            this.x30ToolStripMenuItem1.CheckOnClick = true;
            this.x30ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.x30ToolStripMenuItem1.Name = "x30ToolStripMenuItem1";
            this.x30ToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.x30ToolStripMenuItem1.Text = "30 X 30";
            this.x30ToolStripMenuItem1.Click += new System.EventHandler(this.x30ToolStripMenuItem1_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMNumColor3,
            this.TSMNumColor4,
            this.TSMNumColor5,
            this.TSMNumColor6,
            this.TSMNumColor7});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "&Colors";
            // 
            // TSMNumColor3
            // 
            this.TSMNumColor3.Checked = true;
            this.TSMNumColor3.CheckOnClick = true;
            this.TSMNumColor3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMNumColor3.Name = "TSMNumColor3";
            this.TSMNumColor3.Size = new System.Drawing.Size(80, 22);
            this.TSMNumColor3.Text = "3";
            this.TSMNumColor3.Click += new System.EventHandler(this.TSMNumColor3_Click);
            // 
            // TSMNumColor4
            // 
            this.TSMNumColor4.CheckOnClick = true;
            this.TSMNumColor4.Name = "TSMNumColor4";
            this.TSMNumColor4.Size = new System.Drawing.Size(80, 22);
            this.TSMNumColor4.Text = "4";
            this.TSMNumColor4.Click += new System.EventHandler(this.TSMNumColor4_Click);
            // 
            // TSMNumColor5
            // 
            this.TSMNumColor5.CheckOnClick = true;
            this.TSMNumColor5.Name = "TSMNumColor5";
            this.TSMNumColor5.Size = new System.Drawing.Size(80, 22);
            this.TSMNumColor5.Text = "5";
            this.TSMNumColor5.Click += new System.EventHandler(this.TSMNumColor5_Click);
            // 
            // TSMNumColor6
            // 
            this.TSMNumColor6.CheckOnClick = true;
            this.TSMNumColor6.Name = "TSMNumColor6";
            this.TSMNumColor6.Size = new System.Drawing.Size(80, 22);
            this.TSMNumColor6.Text = "6";
            this.TSMNumColor6.Click += new System.EventHandler(this.TSMNumColor6_Click);
            // 
            // TSMNumColor7
            // 
            this.TSMNumColor7.CheckOnClick = true;
            this.TSMNumColor7.Name = "TSMNumColor7";
            this.TSMNumColor7.Size = new System.Drawing.Size(80, 22);
            this.TSMNumColor7.Text = "7";
            this.TSMNumColor7.Click += new System.EventHandler(this.TSMNumColor7_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rulesToolStripMenuItem.Text = "Ru&les";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Your Score: 0";
            // 
            // TimeItTakes
            // 
            this.TimeItTakes.Tick += new System.EventHandler(this.TimeItTakes_Tick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel2.Text = "Time Taken: 0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(364, 287);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Same Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boarderSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMNumColor3;
        private System.Windows.Forms.ToolStripMenuItem TSMNumColor4;
        private System.Windows.Forms.ToolStripMenuItem TSMNumColor5;
        private System.Windows.Forms.ToolStripMenuItem TSMNumColor6;
        private System.Windows.Forms.ToolStripMenuItem TSMNumColor7;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x20ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x30ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer TimeItTakes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

