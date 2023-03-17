using DrawApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DrawApp
{
  public class DrawObject : PictureBox
  {
    protected DrawObject() { }
    protected DrawObject(int xpos, int ypos, float scale, string name, Control parent)
    {
      m_xpos = xpos;
      m_ypos = ypos;
      m_scale = scale;
      m_name = name;
      m_parent = parent;

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.Location = new System.Drawing.Point(m_xpos, m_ypos);
      this.Image = (System.Drawing.Image)resources.GetObject(name + ".Image");
      this.Size = new System.Drawing.Size(40, 40);
      // add the 'delete' functionality
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(onMouseClick);
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
    }

    public bool RecreateObject()
    {
      string baseType = this.GetType().Name;
      switch (baseType)
      {
        case "Cookie":
          Cookie.CreateCookie(m_xpos, m_ypos, m_scale, m_parent);
          return true;
        case "FishSticks":
          FishSticks.CreateFishSticks(m_xpos, m_ypos, m_scale, m_parent);
          return true;
        case "Cup":
          Cup.CreateCup(m_xpos, m_ypos, m_scale, m_parent);
          return true;
        case "Cat":
          Cat.CreateCat(m_xpos, m_ypos, m_scale, m_parent);
          return true;
        case "Strawberry":
          Strawberry.CreateStrawberry(m_xpos, m_ypos, m_scale, m_parent);
          return true;
        case "Sigma":
          Sigma.CreateSigma(m_xpos, m_ypos, m_scale, m_parent);
          return true;
      }
      return false;
    }

    private void onMouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        CommandStack.DoCommand(new DeleteCommand(this));
      }
      
    }

    public void DeleteDrawable()
    {
      if (m_parent != null)
      {
        m_parent.Controls.Remove(this);
      }
    }
    public int m_xpos { get; set; }
    public int m_ypos { get; set; }
    public float m_scale { get; set; }
    public string m_name = string.Empty;
    public Control? m_parent { get; set; }
  }

  public class Cookie : DrawObject
  {
    protected Cookie() : base() { }
    protected Cookie(int xpos, int ypos, float scale, string name, Control parent) : base(xpos, ypos, scale, name, parent)
    {
    }

    // Factory pattern
    public static Cookie CreateCookie(int xpos, int ypos, float scale, Control parent)
    {
      var cookie = new Cookie(xpos, ypos, scale, "cookie", parent);

      parent.Controls.Add(cookie);
      parent.SendToBack();

      return cookie;
    }

  }

  public class FishSticks : DrawObject
  {
    protected FishSticks() : base() { }
    protected FishSticks(int xpos, int ypos, float scale, string name, Control parent) : base(xpos, ypos, scale, name, parent)
    {
    }

    // Factory pattern
    public static FishSticks CreateFishSticks(int xpos, int ypos, float scale, Control parent)
    {
      var fishsticks = new FishSticks(xpos, ypos, scale, "fishsticks", parent);

      parent.Controls.Add(fishsticks);
      parent.SendToBack();

      return fishsticks;
    }
  }

  public class Cup : DrawObject
  {
    protected Cup() : base() { }
    protected Cup(int xpos, int ypos, float scale, string name, Control parent) : base(xpos, ypos, scale, name, parent)
    {
    }

    // Factory pattern
    public static Cup CreateCup(int xpos, int ypos, float scale, Control parent)
    {
      var cup = new Cup(xpos, ypos, scale, "cup", parent);

      parent.Controls.Add(cup);
      parent.SendToBack();

      return cup;
    }
  }
  public class Cat : DrawObject
  {
    protected Cat() : base() { }
    protected Cat(int xpos, int ypos, float scale, string name, Control parent) : base(xpos, ypos, scale, name, parent)
    {
    }

    // Factory pattern
    public static Cat CreateCat(int xpos, int ypos, float scale, Control parent)
    {
      var cat = new Cat(xpos, ypos, scale, "cat", parent);

      parent.Controls.Add(cat);
      parent.SendToBack();

      return cat;
    }
  }

  public class Strawberry : DrawObject
  {
    protected Strawberry() : base() { }
    protected Strawberry(int xpos, int ypos, float scale, string name, Control parent) : base(xpos, ypos, scale, name, parent)
    {
    }

    // Factory pattern
    public static Strawberry CreateStrawberry(int xpos, int ypos, float scale, Control parent)
    {
      var strawberry = new Strawberry(xpos, ypos, scale, "strawberry", parent);

      parent.Controls.Add(strawberry);
      parent.SendToBack();

      return strawberry;
    }
  }

  public class Sigma : DrawObject
  {
    protected Sigma() : base() { }
    protected Sigma(int xpos, int ypos, float scale, string name, Control parent) : base(xpos, ypos, scale, name, parent)
    {
    }

    // Factory pattern
    public static Sigma CreateSigma(int xpos, int ypos, float scale, Control parent)
    {
      var sigma = new Sigma(xpos, ypos, scale, "sigma", parent);

      parent.Controls.Add(sigma);
      parent.SendToBack();

      return sigma;
    }
  }
}
