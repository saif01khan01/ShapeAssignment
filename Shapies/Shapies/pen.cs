using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    internal class pen
    {

        public void positionPen(int xPos, int yPos, PictureBox p , Bitmap drawingSurface)
        {
            Graphics g = Graphics.FromImage(drawingSurface);

            g.FillRectangle(Brushes.Red, xPos, yPos , 3,3);

            p.Image = drawingSurface;

        }
    }
}
