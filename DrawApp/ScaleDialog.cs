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
  public partial class ScaleDialog : Form
  {
    public ScaleDialog()
    {
      InitializeComponent();
    }

    private float scale = 1;
    public float GetScale()
    {
      return scale;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      scale = (int)numericUpDown1.Value;
      Close();
    }
  }
}
