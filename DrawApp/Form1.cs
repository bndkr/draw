namespace DrawApp
{
    public partial class Form1 : Form
    {
        private int m_selectedTool = 0;
        private List<DrawObject> m_drawObjects= new List<DrawObject>();

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
            var cookie = Cookie.CreateCookie(e.Location.X, e.Location.Y, 1, c_canvasGroupBox);
            m_drawObjects.Add(cookie);
            this.Controls.Add(cookie);
            c_canvasGroupBox.SendToBack();
            c_statusLabel.Text = $"x: {e.Location.X}, y: {e.Location.Y}";
        }

        private void c_canvasGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}