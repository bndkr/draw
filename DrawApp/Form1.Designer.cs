namespace DrawApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.c_fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
      this.c_menuNew = new System.Windows.Forms.ToolStripMenuItem();
      this.c_menuSave = new System.Windows.Forms.ToolStripMenuItem();
      this.c_menuLoad = new System.Windows.Forms.ToolStripMenuItem();
      this.c_menuQuit = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.c_cookieButton = new System.Windows.Forms.ToolStripButton();
      this.c_fishSticksButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.c_strawberry = new System.Windows.Forms.ToolStripButton();
      this.c_sigma = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.c_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.cookie = new System.Windows.Forms.PictureBox();
      this.c_canvasGroupBox = new System.Windows.Forms.GroupBox();
      this.fishsticks = new System.Windows.Forms.PictureBox();
      this.cup = new System.Windows.Forms.PictureBox();
      this.cat = new System.Windows.Forms.PictureBox();
      this.strawberry = new System.Windows.Forms.PictureBox();
      this.sigma = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cookie)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fishsticks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cup)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.strawberry)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sigma)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_fileMenuStrip,
            this.editToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(785, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
      // 
      // c_fileMenuStrip
      // 
      this.c_fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_menuNew,
            this.c_menuSave,
            this.c_menuLoad,
            this.c_menuQuit});
      this.c_fileMenuStrip.Name = "c_fileMenuStrip";
      this.c_fileMenuStrip.Size = new System.Drawing.Size(37, 20);
      this.c_fileMenuStrip.Text = "File";
      // 
      // c_menuNew
      // 
      this.c_menuNew.Name = "c_menuNew";
      this.c_menuNew.ShortcutKeyDisplayString = "";
      this.c_menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.c_menuNew.Size = new System.Drawing.Size(141, 22);
      this.c_menuNew.Text = "New";
      this.c_menuNew.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // c_menuSave
      // 
      this.c_menuSave.Name = "c_menuSave";
      this.c_menuSave.Size = new System.Drawing.Size(141, 22);
      this.c_menuSave.Text = "Save";
      // 
      // c_menuLoad
      // 
      this.c_menuLoad.Name = "c_menuLoad";
      this.c_menuLoad.Size = new System.Drawing.Size(141, 22);
      this.c_menuLoad.Text = "Load";
      // 
      // c_menuQuit
      // 
      this.c_menuQuit.Name = "c_menuQuit";
      this.c_menuQuit.Size = new System.Drawing.Size(141, 22);
      this.c_menuQuit.Text = "Quit";
      this.c_menuQuit.Click += new System.EventHandler(this.c_menuQuit_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // undoToolStripMenuItem
      // 
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.undoToolStripMenuItem.Text = "Undo";
      this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_cookieButton,
            this.c_fishSticksButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.c_strawberry,
            this.c_sigma});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(785, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // c_cookieButton
      // 
      this.c_cookieButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.c_cookieButton.Image = ((System.Drawing.Image)(resources.GetObject("c_cookieButton.Image")));
      this.c_cookieButton.ImageTransparentColor = System.Drawing.Color.White;
      this.c_cookieButton.Name = "c_cookieButton";
      this.c_cookieButton.Size = new System.Drawing.Size(23, 22);
      this.c_cookieButton.Text = "Cookie";
      this.c_cookieButton.Click += new System.EventHandler(this.c_cookieButton_Click);
      // 
      // c_fishSticksButton
      // 
      this.c_fishSticksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.c_fishSticksButton.Image = ((System.Drawing.Image)(resources.GetObject("c_fishSticksButton.Image")));
      this.c_fishSticksButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.c_fishSticksButton.Name = "c_fishSticksButton";
      this.c_fishSticksButton.Size = new System.Drawing.Size(23, 22);
      this.c_fishSticksButton.Text = "Fish Sticks";
      this.c_fishSticksButton.Click += new System.EventHandler(this.c_fishSticksButton_Click);
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "Metal Cup";
      this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton2.Text = "Old Cat";
      this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
      // 
      // c_strawberry
      // 
      this.c_strawberry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.c_strawberry.Image = ((System.Drawing.Image)(resources.GetObject("c_strawberry.Image")));
      this.c_strawberry.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.c_strawberry.Name = "c_strawberry";
      this.c_strawberry.Size = new System.Drawing.Size(23, 22);
      this.c_strawberry.Text = "Strawberry";
      this.c_strawberry.Click += new System.EventHandler(this.toolStripButton3_Click);
      // 
      // c_sigma
      // 
      this.c_sigma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.c_sigma.Image = ((System.Drawing.Image)(resources.GetObject("c_sigma.Image")));
      this.c_sigma.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.c_sigma.Name = "c_sigma";
      this.c_sigma.Size = new System.Drawing.Size(23, 22);
      this.c_sigma.Text = "Sigma";
      this.c_sigma.Click += new System.EventHandler(this.c_sigma_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_statusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 467);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(785, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // c_statusLabel
      // 
      this.c_statusLabel.Name = "c_statusLabel";
      this.c_statusLabel.Size = new System.Drawing.Size(93, 17);
      this.c_statusLabel.Text = "No selected tool";
      // 
      // cookie
      // 
      this.cookie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.cookie.Image = ((System.Drawing.Image)(resources.GetObject("cookie.Image")));
      this.cookie.ImageLocation = "";
      this.cookie.InitialImage = ((System.Drawing.Image)(resources.GetObject("cookie.InitialImage")));
      this.cookie.Location = new System.Drawing.Point(733, 62);
      this.cookie.Name = "cookie";
      this.cookie.Size = new System.Drawing.Size(40, 40);
      this.cookie.TabIndex = 3;
      this.cookie.TabStop = false;
      this.cookie.Visible = false;
      this.cookie.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // c_canvasGroupBox
      // 
      this.c_canvasGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.c_canvasGroupBox.Location = new System.Drawing.Point(23, 75);
      this.c_canvasGroupBox.Name = "c_canvasGroupBox";
      this.c_canvasGroupBox.Size = new System.Drawing.Size(711, 339);
      this.c_canvasGroupBox.TabIndex = 4;
      this.c_canvasGroupBox.TabStop = false;
      this.c_canvasGroupBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.c_canvasGroupBox_Click);
      this.c_canvasGroupBox.Enter += new System.EventHandler(this.c_canvasGroupBox_Enter);
      // 
      // fishsticks
      // 
      this.fishsticks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.fishsticks.Image = ((System.Drawing.Image)(resources.GetObject("fishsticks.Image")));
      this.fishsticks.ImageLocation = "";
      this.fishsticks.InitialImage = ((System.Drawing.Image)(resources.GetObject("fishsticks.InitialImage")));
      this.fishsticks.Location = new System.Drawing.Point(733, 108);
      this.fishsticks.Name = "fishsticks";
      this.fishsticks.Size = new System.Drawing.Size(40, 40);
      this.fishsticks.TabIndex = 5;
      this.fishsticks.TabStop = false;
      this.fishsticks.Visible = false;
      // 
      // cup
      // 
      this.cup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.cup.Image = ((System.Drawing.Image)(resources.GetObject("cup.Image")));
      this.cup.ImageLocation = "";
      this.cup.InitialImage = ((System.Drawing.Image)(resources.GetObject("cup.InitialImage")));
      this.cup.Location = new System.Drawing.Point(733, 154);
      this.cup.Name = "cup";
      this.cup.Size = new System.Drawing.Size(40, 40);
      this.cup.TabIndex = 6;
      this.cup.TabStop = false;
      this.cup.Visible = false;
      // 
      // cat
      // 
      this.cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.cat.Image = ((System.Drawing.Image)(resources.GetObject("cat.Image")));
      this.cat.ImageLocation = "";
      this.cat.InitialImage = ((System.Drawing.Image)(resources.GetObject("cat.InitialImage")));
      this.cat.Location = new System.Drawing.Point(733, 200);
      this.cat.Name = "cat";
      this.cat.Size = new System.Drawing.Size(40, 40);
      this.cat.TabIndex = 7;
      this.cat.TabStop = false;
      this.cat.Visible = false;
      // 
      // strawberry
      // 
      this.strawberry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.strawberry.Image = ((System.Drawing.Image)(resources.GetObject("strawberry.Image")));
      this.strawberry.ImageLocation = "";
      this.strawberry.InitialImage = ((System.Drawing.Image)(resources.GetObject("strawberry.InitialImage")));
      this.strawberry.Location = new System.Drawing.Point(733, 246);
      this.strawberry.Name = "strawberry";
      this.strawberry.Size = new System.Drawing.Size(40, 40);
      this.strawberry.TabIndex = 8;
      this.strawberry.TabStop = false;
      this.strawberry.Visible = false;
      // 
      // sigma
      // 
      this.sigma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.sigma.Image = ((System.Drawing.Image)(resources.GetObject("sigma.Image")));
      this.sigma.ImageLocation = "";
      this.sigma.InitialImage = ((System.Drawing.Image)(resources.GetObject("sigma.InitialImage")));
      this.sigma.Location = new System.Drawing.Point(733, 292);
      this.sigma.Name = "sigma";
      this.sigma.Size = new System.Drawing.Size(40, 40);
      this.sigma.TabIndex = 9;
      this.sigma.TabStop = false;
      this.sigma.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 417);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(231, 15);
      this.label1.TabIndex = 10;
      this.label1.Text = "Select a tool and left click to create objects";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 432);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(163, 15);
      this.label2.TabIndex = 11;
      this.label2.Text = "Right click an object to delete";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(328, 417);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(131, 15);
      this.label3.TabIndex = 12;
      this.label3.Text = "Number of commands:";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(785, 489);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.sigma);
      this.Controls.Add(this.strawberry);
      this.Controls.Add(this.cat);
      this.Controls.Add(this.cup);
      this.Controls.Add(this.fishsticks);
      this.Controls.Add(this.cookie);
      this.Controls.Add(this.c_canvasGroupBox);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Name = "Form1";
      this.Text = "Draw App";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cookie)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fishsticks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cup)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.strawberry)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sigma)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem c_fileMenuStrip;
        private ToolStripMenuItem c_menuNew;
        private ToolStripMenuItem c_menuSave;
        private ToolStripMenuItem c_menuLoad;
        private ToolStripMenuItem c_menuQuit;
        private ToolStrip toolStrip1;
        private ToolStripButton c_cookieButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel c_statusLabel;
        private PictureBox cookie;
        private GroupBox c_canvasGroupBox;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private PictureBox fishsticks;
        private ToolStripButton c_fishSticksButton;
        private PictureBox cup;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private PictureBox cat;
        private ToolStripButton c_strawberry;
        private PictureBox strawberry;
        private ToolStripButton c_sigma;
        private PictureBox sigma;
        private Label label1;
        private Label label2;
    private Label label3;
  }
}