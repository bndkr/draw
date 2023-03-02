namespace DrawApp
{
  public partial class Form1 : Form
  {
    private string m_selectedTool = "";
    public Form1()
    {
      InitializeComponent();
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }

    private void c_menuQuit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void c_cookieButton_Click(object sender, EventArgs e)
    {
      m_selectedTool = "cookie";
      c_statusLabel.Text = "Selected Cookie tool";
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void c_canvasGroupBox_Click(object sender, MouseEventArgs e)
    {
      if (m_selectedTool != "")
      {
        CommandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, m_selectedTool));
      }
      label3.Text = $"number of commands: {CommandStack.getNumCommands()}";
    }

    private void c_canvasGroupBox_Enter(object sender, EventArgs e)
    {

    }

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CommandStack.UndoLastCommand();
      label3.Text = $"number of commands: {CommandStack.getNumCommands()}";
    }

    private void c_fishSticksButton_Click(object sender, EventArgs e)
    {
      m_selectedTool = "fishsticks";
      c_statusLabel.Text = "Selected Fish Sticks tool";
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      m_selectedTool = "cup";
      c_statusLabel.Text = "Selected Cup tool";
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      m_selectedTool = "cat";
      c_statusLabel.Text = "Selected Old Cat tool";
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      m_selectedTool = "strawberry";
      c_statusLabel.Text = "Selected Strawberry tool";
    }

    private void c_sigma_Click(object sender, EventArgs e)
    {
      m_selectedTool = "sigma";
      c_statusLabel.Text = "Selected Sigma tool";
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {
      label3.Text = $"number of commands: {CommandStack.getNumCommands()}";
    }
  }
}