using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    internal class Circle : Form1
    {
        public void drawCircle(int radius, PictureBox p) {

            Bitmap drawingSurface = new Bitmap(780, 369);
            Graphics g = Graphics.FromImage(drawingSurface);

            Pen redPen = new Pen(Brushes.Red);

            g.DrawEllipse(redPen, 0, 0, radius * 2, radius * 2);

            p.Image = drawingSurface;

        }
    }
}
