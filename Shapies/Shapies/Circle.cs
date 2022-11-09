using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    internal class Circle : Form1
    {
        /**
         * The following method draws a circle using the DrawEllipse method of the graphics class. 
         * 
         * @param radius 
         * 
         * 
         * */

        public void drawCircle(int radius, int xPos, int yPos, PictureBox p , Bitmap drawingSurface) {

            Graphics g = Graphics.FromImage(drawingSurface);

            Pen redPen = new Pen(Brushes.Red);

            g.DrawEllipse(redPen, xPos, yPos, radius * 2, radius * 2);

            p.Image = drawingSurface;

        }
    }
}
