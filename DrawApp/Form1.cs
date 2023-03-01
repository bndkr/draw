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
                case 2: m_commandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, "fishsticks")); break;
                case 3: m_commandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, "cup")); break;
                case 4: m_commandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, "cat")); break;
                case 5: m_commandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, "strawberry")); break;
                case 6: m_commandStack.DoCommand(new DrawCommand(e.Location.X, e.Location.Y, 1.0f, c_canvasGroupBox, "sigma")); break;
            }
        }

        private void c_canvasGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_commandStack.UndoLastCommand();
        }

        private void c_fishSticksButton_Click(object sender, EventArgs e)
        {
            m_selectedTool = 2; // change to enum, means fish sticks
            c_statusLabel.Text = "Selected Fish Sticks tool";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            m_selectedTool = 3; // change to enum, means cup
            c_statusLabel.Text = "Selected Cup tool";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            m_selectedTool = 4; // change to enum, means cat
            c_statusLabel.Text = "Selected Old Cat tool";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            m_selectedTool = 5; // change to enum, means strawberry
            c_statusLabel.Text = "Selected Strawberry tool";
        }

        private void c_sigma_Click(object sender, EventArgs e)
        {
            m_selectedTool = 6; // change to enum, means sigma
            c_statusLabel.Text = "Selected Sigma tool";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}