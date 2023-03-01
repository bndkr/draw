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
            m_drawable = null;
            m_xpos = xpos;
            m_ypos = ypos;
            m_scale = scale;
            m_parent = parent;
            m_type = type;
        }

        public bool Execute()
        {
            switch (m_type)
            {
                case "cookie":
                    m_drawable = Cookie.CreateCookie(m_xpos, m_ypos, m_scale, m_parent); break;
                case "fishsticks":
                    m_drawable = FishSticks.CreateFishSticks(m_xpos, m_ypos, m_scale, m_parent); break;
                case "cup":
                    m_drawable = Cup.CreateCup(m_xpos, m_ypos, m_scale, m_parent); break;
                case "cat":
                    m_drawable = Cat.CreateCat(m_xpos, m_ypos, m_scale, m_parent); break;
                case "strawberry":
                    m_drawable = Strawberry.CreateStrawberry(m_xpos, m_ypos, m_scale, m_parent); break;
                case "sigma":
                    m_drawable = Sigma.CreateSigma(m_xpos, m_ypos, m_scale, m_parent); break;
                case "": return false;
            }
            return true;
        }

        public bool Undo()
        {
            DrawObject.DeleteDrawable(m_drawable, m_parent);
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
