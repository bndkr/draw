using System.Runtime.InteropServices;

namespace DrawApp
{
  public partial class Form1 : Form
  {
    private string m_selectedTool = "";
    public Form1()
    {
      InitializeComponent();
    }

    private DrawObject m_selectedObject = null;
    public void SelectObject (DrawObject obj)
    {
      if (m_selectedObject != null)
      {
        m_selectedObject.BorderStyle = BorderStyle.None;
      }
      m_selectedObject = obj;
      obj.BorderStyle = BorderStyle.Fixed3D;
    }



    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}

    private void toolStripMenuItem1_Click(object sender, EventArgs e) {}

    private void c_menuQuit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Form1_Load(object sender, EventArgs e) {}

    private void c_cookieButton_Click(object sender, EventArgs e)
    {
      m_selectedTool = "cookie";
      c_statusLabel.Text = "Selected Cookie tool";
    }

    private void pictureBox1_Click(object sender, EventArgs e) {}

    private void c_canvasGroupBox_Click(object sender, MouseEventArgs e)
    {
      if (m_selectedTool != "")
      {
        CommandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, m_selectedTool, this));
      }
    }

    private void c_canvasGroupBox_Enter(object sender, EventArgs e) {}

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CommandStack.UndoLastCommand();
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

    private void label2_Click(object sender, EventArgs e) {}

    private void moveStripButton_Click(object sender, EventArgs e) {}

    private void moveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var dialog = new MoveDialog();
      dialog.ShowDialog();
      var result = dialog.GetMoveResult();
      if (result != null && m_selectedObject != null)
      {
        CommandStack.DoCommand(new MoveCommand(m_selectedObject, result.Item1, result.Item2));
      }
    }

    private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var dialog = new ScaleDialog();
      dialog.ShowDialog();
      var result = dialog.GetScale();
      if (m_selectedObject != null)
      {
        CommandStack.DoCommand(new ScaleCommand(m_selectedObject, result));
      }
    }

    private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (m_selectedObject != null)
      {
        CommandStack.DoCommand(new DuplicateCommand(m_selectedObject));
      }
    }

    private void c_menuSave_Click(object sender, EventArgs e)
    {
      saveFileDialog1.ShowDialog();
      FileOperations.SaveFile(c_canvasGroupBox.Controls, saveFileDialog1.FileName);
    }

    private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void c_menuLoad_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
      var objects = FileOperations.LoadFile(openFileDialog1.FileName);
      if (objects != null)
      {
        foreach (var obj in objects)
        {
          if (obj.name != null)
          {
            DrawObject.CreateDrawableFromName(obj.name, obj.x, obj.y, 1.0f, c_canvasGroupBox, this);
          }
        }
      }
    }
  }
}