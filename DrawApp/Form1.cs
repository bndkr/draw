namespace DrawApp
{
    public partial class Form1 : Form
    {
        private int m_selectedTool = 0;
        private CommandStack m_commandStack = new CommandStack();
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
            m_selectedTool = 1; // change to enum, means cookie
            c_statusLabel.Text = "Selected Cookie tool";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void c_canvasGroupBox_Click(object sender, MouseEventArgs e)
        {
            switch (m_selectedTool)
            {
                case 0: break; // 'none' tool
                case 1: m_commandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, "cookie")); break;
            }
        }

        private void c_canvasGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_commandStack.UndoLastCommand();
        }
    }
}