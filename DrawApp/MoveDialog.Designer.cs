namespace DrawApp
{
  partial class MoveDialog
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
      this.button1 = new System.Windows.Forms.Button();
      this.numericX = new System.Windows.Forms.NumericUpDown();
      this.numericY = new System.Windows.Forms.NumericUpDown();
      this.labelX = new System.Windows.Forms.Label();
      this.labelY = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(80, 128);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Confirm";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // numericX
      // 
      this.numericX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericX.Location = new System.Drawing.Point(52, 32);
      this.numericX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.numericX.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
      this.numericX.Name = "numericX";
      this.numericX.Size = new System.Drawing.Size(120, 23);
      this.numericX.TabIndex = 1;
      // 
      // numericY
      // 
      this.numericY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericY.Location = new System.Drawing.Point(52, 61);
      this.numericY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.numericY.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
      this.numericY.Name = "numericY";
      this.numericY.Size = new System.Drawing.Size(120, 23);
      this.numericY.TabIndex = 2;
      // 
      // labelX
      // 
      this.labelX.AutoSize = true;
      this.labelX.Location = new System.Drawing.Point(32, 34);
      this.labelX.Name = "labelX";
      this.labelX.Size = new System.Drawing.Size(14, 15);
      this.labelX.TabIndex = 3;
      this.labelX.Text = "X";
      // 
      // labelY
      // 
      this.labelY.AutoSize = true;
      this.labelY.Location = new System.Drawing.Point(32, 63);
      this.labelY.Name = "labelY";
      this.labelY.Size = new System.Drawing.Size(14, 15);
      this.labelY.TabIndex = 4;
      this.labelY.Text = "Y";
      // 
      // MoveDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(241, 163);
      this.Controls.Add(this.labelY);
      this.Controls.Add(this.labelX);
      this.Controls.Add(this.numericY);
      this.Controls.Add(this.numericX);
      this.Controls.Add(this.button1);
      this.Name = "MoveDialog";
      this.Text = "Move";
      ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button button1;
    private NumericUpDown numericX;
    private NumericUpDown numericY;
    private Label labelX;
    private Label labelY;
  }
}