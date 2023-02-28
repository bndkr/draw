using DrawApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    public class DrawObject : PictureBox
    {
        protected DrawObject() { }
    }

    public class Cookie : DrawObject
    {
        protected Cookie() { }
        public static Cookie CreateCookie(int xpos, int ypos, int scale, Control parent)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            var cookie = new Cookie();
            ((System.ComponentModel.ISupportInitialize)(cookie)).BeginInit();

            parent.Controls.Add(cookie);
            cookie.Location = new System.Drawing.Point(xpos, ypos);
            cookie.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            cookie.Size = new System.Drawing.Size(40, 40);
            ((System.ComponentModel.ISupportInitialize)(cookie)).EndInit();
            // configure cookie
            return cookie;
        }
    }
}
