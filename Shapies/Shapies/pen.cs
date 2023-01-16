using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    public class pen
    {

        /// <summary>
        ///  This method positions the pen at the specified x and y coordinates on the drawing surface.
        /// It uses the Graphics class to fill a small rectangle at the specified position with the color red to represent the pen's location.
        /// The resulting image is then set as the Image property of the provided PictureBox.
        /// </summary>
        ///
        /// <param name="xPos">The x-coordinate of the desired pen position</param>
        /// <param name="yPos">The y-coordinate of the desired pen position</param>
        /// <param name="p">The PictureBox where the resulting image will be displayed</param>
        /// <param name="drawingSurface">The Bitmap object where the pen position will be drawn</param>
        /// <param name="g">The Graphics object used to draw the pen position on the drawing surface</param>
        public void positionPen(int xPos, int yPos, PictureBox p, Bitmap drawingSurface, Graphics g)
        {
            if (xPos < 0 || yPos < 0)
            {
                throw new Exception("Invalid x or y position passed");
            }
            pen pen = new pen();

            g.FillRectangle(Brushes.Red, xPos, yPos, 3, 3);

            p.Image = drawingSurface;



        }

        
             /// <summary> this method draws a line to points specified by the user </summary>
             /// 
             /// <param name="p"> picture box where bitmap is drawn to </param>
             /// <param name="drawingSurface"> bitmap where drawing is done to </param>
             /// <param name="g"> graphics class which is used to draw </param>
             /// <param name="xPos"> xPosition specified by user </param>
             /// <param name="yPos"> yPosition specified by user </param>
             /// <param name="hPoint"> horizontal point of line </param>
             /// <param name="vPoint"> vertical point of line </param>
             /// <param name="textBox"> textbox where user enters multiline commands </param>
        public void penDraw(int xPos, int yPos, int hPoint, int vPoint, PictureBox p, Bitmap drawingSurface, Graphics g, string color)
        {
             
            //validates colours 
            if (color.Equals("red")) {
                Pen pen = new Pen(Brushes.Red);

                g.DrawLine(pen, xPos, yPos, hPoint, vPoint);

                p.Image = drawingSurface;

            } else if(color.Equals("green"))
            {
                Pen pen = new Pen(Brushes.Green);

                g.DrawLine(pen, xPos, yPos, hPoint, vPoint);

                p.Image = drawingSurface;

            } else if (color.Equals("blue"))
            {
                Pen pen = new Pen(Brushes.Blue);

                g.DrawLine(pen, xPos, yPos, hPoint, vPoint);

                p.Image = drawingSurface;

            } else
            {
                throw new ArgumentException("Invalid color provided, expected 'red', 'green' or 'blue'");
            }
            
            
        }
    }
}
