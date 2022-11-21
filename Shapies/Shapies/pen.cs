using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    class pen
    {
        /**
      * <summary> this method positions the pen </summary>
      * 
      * <param name="p"> picture box where bitmap is drawn to </param>
      * <param name="drawingSurface"> bitmap where drawing is done to </param>
      * <param name="g"> graphics class which is used to draw </param>
      * <param name="xPos"> xPosition specified by user </param>
      * <param name="yPos"> yPosition specified by user </param>
      * 
      * 
      * */

        public void positionPen(int xPos, int yPos, PictureBox p , Bitmap drawingSurface, Graphics g)
        {

           pen pen = new pen();

           g.FillRectangle(Brushes.Red, xPos, yPos , 3,3);

           p.Image = drawingSurface;

           

        }

        /**
             * <summary> this method draws a line to points specified by the user </summary>
             * 
             * <param name="p"> picture box where bitmap is drawn to </param>
             * <param name="drawingSurface"> bitmap where drawing is done to </param>
             * <param name="g"> graphics class which is used to draw </param>
             * <param name="xPos"> xPosition specified by user </param>
             * <param name="yPos"> yPosition specified by user </param>
             * <param name="hPoint"> horizontal point of line </param>
             * <param name="vPoint"> vertical point of line </param>
             * <param name="textBox"> textbox where user enters multiline commands </param>
             * 
             * */

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
                Pen pen = new Pen(Brushes.Red);

                g.DrawLine(pen, xPos, yPos, hPoint, vPoint);

                p.Image = drawingSurface;
            }
            
            
        }
    }
}
