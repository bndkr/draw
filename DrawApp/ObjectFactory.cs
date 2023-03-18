using DrawApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DrawApp
{
  public class DrawObject : PictureBox
  {
    protected DrawObject(int xpos, int ypos, float scale, string name, Control parent, Form1 form)
    {
      m_xpos = xpos;
      m_ypos = ypos;
      m_scale = scale;
      m_name = name;
      m_parent = parent;
      m_form = form;

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.Location = new System.Drawing.Point(m_xpos, m_ypos);
      this.Image = (System.Drawing.Image)resources.GetObject(name + ".Image");
      this.Size = new System.Drawing.Size(40, 40);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(onMouseClick);
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
    }

    public bool RecreateObject()
    {
      string baseType = this.GetType().Name;
      switch (baseType)
      {
        case "Cookie":
          Cookie.CreateCookie(m_xpos, m_ypos, m_scale, m_parent, m_form);
          return true;
        case "FishSticks":
          FishSticks.CreateFishSticks(m_xpos, m_ypos, m_scale, m_parent, m_form);
          return true;
        case "Cup":
          Cup.CreateCup(m_xpos, m_ypos, m_scale, m_parent, m_form);
          return true;
        case "Cat":
          Cat.CreateCat(m_xpos, m_ypos, m_scale, m_parent, m_form);
          return true;
        case "Strawberry":
          Strawberry.CreateStrawberry(m_xpos, m_ypos, m_scale, m_parent, m_form);
          return true;
        case "Sigma":
          Sigma.CreateSigma(m_xpos, m_ypos, m_scale, m_parent, m_form);
          return true;
      }
      return false;
    }

    public static DrawObject? CreateDrawableFromName(string name,
                                                    int x,
                                                    int y,
                                                    float scale,
                                                    Control? parent,
                                                    Form1 form)
    {
      switch (name)
      {
        case "cookie":
          return Cookie.CreateCookie(x, y, scale, parent, form);
        case "fishsticks":
          return FishSticks.CreateFishSticks(x, y, scale, parent, form);
        case "cup":
          return Cup.CreateCup(x, y, scale, parent, form);
        case "cat":
          return Cat.CreateCat(x, y, scale, parent, form);
        case "strawberry":
          return Strawberry.CreateStrawberry(x, y, scale, parent, form);
        case "sigma":
          return Sigma.CreateSigma(x, y, scale, parent, form);
      }
      return null;
    }




    private void onMouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        CommandStack.DoCommand(new DeleteCommand(this));
      }
      if (e.Button == MouseButtons.Left)
      {
        m_form.SelectObject(this);
      }
    }

    public void MoveDrawable(int x, int y)
    {
      this.Location = new Point(this.Location.X + x, this.Location.Y + y);
      this.m_xpos = x;
      this.m_ypos = y;
    }

    public void ScaleDrawable(float factor)
    {
      this.Size = new Size((int) (this.Size.Width * factor),
                           (int) (this.Size.Height * factor));
      this.m_scale = factor;
    }

    public DrawObject DuplicateDrawable()
    {
      const int OFFSET = 40;
      string baseType = this.GetType().Name;
      switch (baseType)
      {
        case "Cookie":
          return Cookie.CreateCookie(m_xpos + OFFSET, m_ypos, m_scale, m_parent, m_form);
        case "FishSticks":
          return FishSticks.CreateFishSticks(m_xpos + OFFSET, m_ypos, m_scale, m_parent, m_form);
        case "Cup":
          return Cup.CreateCup(m_xpos + OFFSET, m_ypos, m_scale, m_parent, m_form);
        case "Cat":
          return Cat.CreateCat(m_xpos + OFFSET, m_ypos, m_scale, m_parent, m_form);
        case "Strawberry":
          return Strawberry.CreateStrawberry(m_xpos + OFFSET, m_ypos, m_scale, m_parent, m_form);
        case "Sigma":
          return Sigma.CreateSigma(m_xpos + OFFSET, m_ypos, m_scale, m_parent, m_form);
      }
      return null;
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
    public Form1 m_form { get; set; }
  }

  public class Cookie : DrawObject
  {
    protected Cookie(int xpos, int ypos, float scale, string name, Control parent, Form1 form) 
      : base(xpos, ypos, scale, name, parent, form)
    {
    }

    // Factory pattern
    public static Cookie CreateCookie(int xpos, int ypos, float scale, Control parent, Form1 form)
    {
      var cookie = new Cookie(xpos, ypos, scale, "cookie", parent, form);

      parent.Controls.Add(cookie);
      parent.SendToBack();

      return cookie;
    }

  }

  public class FishSticks : DrawObject
  {
    protected FishSticks(int xpos, int ypos, float scale, string name, Control parent, Form1 form)
      : base(xpos, ypos, scale, name, parent, form)
    {
    }

    // Factory pattern
    public static FishSticks CreateFishSticks(int xpos, int ypos, float scale, Control parent, Form1 form)
    {
      var fishsticks = new FishSticks(xpos, ypos, scale, "fishsticks", parent, form);

      parent.Controls.Add(fishsticks);
      parent.SendToBack();

      return fishsticks;
    }
  }

  public class Cup : DrawObject
  {
    protected Cup(int xpos, int ypos, float scale, string name, Control parent, Form1 form)
      : base(xpos, ypos, scale, name, parent, form)
    {
    }

    // Factory pattern
    public static Cup CreateCup(int xpos, int ypos, float scale, Control parent, Form1 form)
    {
      var cup = new Cup(xpos, ypos, scale, "cup", parent, form);

      parent.Controls.Add(cup);
      parent.SendToBack();

      return cup;
    }
  }
  public class Cat : DrawObject
  {
    protected Cat(int xpos, int ypos, float scale, string name, Control parent, Form1 form)
      : base(xpos, ypos, scale, name, parent, form)
    {
    }

    // Factory pattern
    public static Cat CreateCat(int xpos, int ypos, float scale, Control parent, Form1 form)
    {
      var cat = new Cat(xpos, ypos, scale, "cat", parent, form);

      parent.Controls.Add(cat);
      parent.SendToBack();

      return cat;
    }
  }

  public class Strawberry : DrawObject
  {
    protected Strawberry(int xpos, int ypos, float scale, string name, Control parent, Form1 form)
      : base(xpos, ypos, scale, name, parent, form)
    {
    }

    // Factory pattern
    public static Strawberry CreateStrawberry(int xpos, int ypos, float scale, Control parent, Form1 form)
    {
      var strawberry = new Strawberry(xpos, ypos, scale, "strawberry", parent, form);

      parent.Controls.Add(strawberry);
      parent.SendToBack();

      return strawberry;
    }
  }

  public class Sigma : DrawObject
  {
    protected Sigma(int xpos, int ypos, float scale, string name, Control parent, Form1 form)
      : base(xpos, ypos, scale, name, parent, form)
    {
    }

    // Factory pattern
    public static Sigma CreateSigma(int xpos, int ypos, float scale, Control parent, Form1 form)
    {
      var sigma = new Sigma(xpos, ypos, scale, "sigma", parent, form);

      parent.Controls.Add(sigma);
      parent.SendToBack();

      return sigma;
    }
  }
}
