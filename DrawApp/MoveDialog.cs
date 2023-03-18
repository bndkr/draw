using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
  public partial class MoveDialog : Form
  {
    public MoveDialog()
    {
      InitializeComponent();
    }
    private Tuple<int, int> m_coords { get; set; }
    private void button1_Click(object sender, EventArgs e)
    {
      m_coords = new Tuple<int, int>((int)numericX.Value, (int)numericY.Value);
      Close();
    }
    public Tuple<int, int> GetMoveResult()
    {
      return m_coords;
    }
  }
}
