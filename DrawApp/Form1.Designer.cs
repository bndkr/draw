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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.c_cookieButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.c_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.c_canvasGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.c_canvasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_fileMenuStrip});
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_cookieButton});
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // c_canvasGroupBox
            // 
            this.c_canvasGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c_canvasGroupBox.Controls.Add(this.pictureBox1);
            this.c_canvasGroupBox.Location = new System.Drawing.Point(23, 52);
            this.c_canvasGroupBox.Name = "c_canvasGroupBox";
            this.c_canvasGroupBox.Size = new System.Drawing.Size(711, 366);
            this.c_canvasGroupBox.TabIndex = 4;
            this.c_canvasGroupBox.TabStop = false;
            this.c_canvasGroupBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.c_canvasGroupBox_Click);
            this.c_canvasGroupBox.Enter += new System.EventHandler(this.c_canvasGroupBox_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 443);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.c_canvasGroupBox.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private GroupBox c_canvasGroupBox;
    }
}