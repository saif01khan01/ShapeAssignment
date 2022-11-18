using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    internal class rectangle
    {
        public void drawRect(int xPos, int yPos, int width, int height, PictureBox p, Bitmap drawingSurface) {
            Graphics g = Graphics.FromImage(drawingSurface);

            Pen redPen = new Pen(Brushes.Red);

            Rectangle rect = new Rectangle(xPos, yPos, width, height);

            g.DrawRectangle(redPen, rect);

        }  
    }
}
