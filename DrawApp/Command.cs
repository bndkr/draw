using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
  interface ICommand
  {
    bool Execute(); // returns true on success, false on failure

    bool Undo();
  }

  class DrawCommand : ICommand
  {
    public DrawCommand(int xpos, int ypos, float scale, Control parent, string type, Form1 form)
    {
      m_drawable = null;
      m_xpos = xpos;
      m_ypos = ypos;
      m_scale = scale;
      m_parent = parent;
      m_type = type;
      m_form = form;
    }

    public bool Execute()
    {
      m_drawable = DrawObject.CreateDrawableFromName(m_type, m_xpos, m_ypos, m_scale, m_parent, m_form);
      return true;
    }

    public bool Undo()
    {
      m_drawable.DeleteDrawable();
      return true;
    }

    private DrawObject? m_drawable;
    private int m_xpos;
    private int m_ypos;
    private float m_scale;
    private Control m_parent;
    private string m_type;
    private Form1 m_form;
  }

  class DeleteCommand : ICommand
  {

    public DeleteCommand(DrawObject objectToDelete)
    {
      m_objectToDelete = objectToDelete;
    }
    public bool Execute()
    {
      m_objectToDelete.DeleteDrawable();
      m_deleted = true;
      return true;
    }

    public bool Undo()
    {
      if (m_deleted)
      {
        return m_objectToDelete.RecreateObject();
      }
      return false;
    }
    private bool m_deleted = false;
    private DrawObject m_objectToDelete;
  }

  class MoveCommand : ICommand
  {
    public MoveCommand(DrawObject objectToMove, int xoff, int yoff)
    {
      this.m_xoff = xoff;
      this.m_yoff = yoff;
      this.m_toMove = objectToMove;
    }
    public bool Execute()
    {
      m_toMove.MoveDrawable(m_xoff, m_yoff);
      return true;
    }

    public bool Undo()
    {
      m_toMove.MoveDrawable(-m_xoff, -m_yoff);
      return true;
    }
    private DrawObject m_toMove;
    private int m_xoff = 0;
    private int m_yoff = 0;
  }

  class ScaleCommand : ICommand
  {
    public ScaleCommand(DrawObject toScale, float factor)
    {
      m_toScale = toScale;
      m_factor = factor;
    }
    public bool Execute()
    {
      m_toScale.ScaleDrawable(m_factor);
      return true;
    }

    public bool Undo()
    {
      m_toScale.ScaleDrawable(1 / m_factor);
      return true;
    }
    private DrawObject m_toScale;
    private float m_factor;
  }

  class DuplicateCommand : ICommand
  {
    public DuplicateCommand(DrawObject toDuplicate)
    {
      this.m_toDuplicate = toDuplicate;
      this.m_dupliacate = null;
    }

    private DrawObject m_toDuplicate;
    private DrawObject? m_dupliacate;

    public bool Execute()
    {
      var m_dupliacate = m_toDuplicate.DuplicateDrawable();
      return true;
    }

    public bool Undo()
    {
      if (m_dupliacate != null) 
      { 
        m_dupliacate.DeleteDrawable();
        return true;
      }
      return false;
    }
  }

}
