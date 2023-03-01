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
        protected DrawObject(int xpos, int ypos, float scale, string name) 
        {
            m_xpos = xpos;
            m_ypos = ypos;
            m_scale = scale;
            m_name = name;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.Location = new System.Drawing.Point(m_xpos, m_ypos);
            this.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            this.Size = new System.Drawing.Size(40, 40);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }

        public static void DeleteDrawable(DrawObject drawObject, Control parent)
        {
            parent.Controls.Remove(drawObject);
        }

        public int m_xpos { get; set; }
        public int m_ypos { get; set; }
        public float m_scale { get; set; }
        public string m_name = string.Empty;
    }

    public class Cookie : DrawObject
    {
        protected Cookie() : base() { }
        protected Cookie(int xpos, int ypos, float scale, string name) : base(xpos, ypos, scale, name)
        {
        }

        // Factory pattern
        public static Cookie CreateCookie(int xpos, int ypos, float scale, Control parent)
        {
            var cookie = new Cookie(xpos, ypos, scale, "cookie");

            parent.Controls.Add(cookie);
            parent.SendToBack();

            return cookie;
        }
        
    }
}
