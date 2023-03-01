using System;
using System.Collections.Generic;
using System.Linq;
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
        public DrawCommand(int xpos, int ypos, float scale, Control parent, string type)
        {
            this.m_drawable = null;
            this.m_xpos = xpos;
            this.m_ypos = ypos;
            this.m_scale = scale;
            this.m_parent = parent;
            this.m_type = type;
        }

        public bool Execute()
        {
            switch (m_type)
            {
                case "cookie":
                    m_drawable = Cookie.CreateCookie(m_xpos, m_ypos, m_scale, m_parent); break;
            }
            return true;
        }

        public bool Undo()
        {
            switch (m_type)
            {
                case "cookie":
                    DrawObject.DeleteDrawable(m_drawable, m_parent); break;
            }
            return true;
        }

        private DrawObject? m_drawable;
        private int m_xpos;
        private int m_ypos;
        private float m_scale;
        private Control m_parent;
        private string m_type;
    }
}
