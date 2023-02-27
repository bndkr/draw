namespace DrawApp
{
    public partial class Form1 : Form
    {
        private int m_selectedTool = 0;

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

        private void c_canvasGroupBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}