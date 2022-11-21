using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    internal class rectangle
    {


        /**
      * <summary> this method positions the pen </summary>
      * 
      * <param name="p"> picture box where bitmap is drawn to </param>
      * <param name="drawingSurface"> bitmap where drawing is done to </param>
      * <param name="g"> graphics class which is used to draw </param>
      * <param name="xPos"> xPosition specified by user </param>
      * <param name="yPos"> yPosition specified by user </param>
      * <param name="height"> height of rectangle that is to be drawn </param>
      * <param name="width"> widht of rectangle that is to be drawn</param>
      * <param name="color"> string which contains the color of the rectangle</param>
      * <param name="fill"> boolean which depending on value will fill shape or leave empty</param>
      * 
      * 
      * */
        public void drawRect(int xPos, int yPos, int width, int height, PictureBox p, Bitmap drawingSurface, Graphics g, string color, bool fill) {
           
            if(color.Equals("red")) { 

             Pen redPen = new Pen(Brushes.Red);

             Rectangle rect = new Rectangle(xPos, yPos, width, height);

                if(fill == false) 
                { 

                 g.DrawRectangle(redPen, rect);
           
                } else
                {
                    g.FillRectangle(Brushes.Red, rect);
                }
                p.Image = drawingSurface;

                g.Dispose();
            }
            else if (color.Equals("blue"))
            {
                Pen bluePen = new Pen(Brushes.Blue);

                Rectangle rect = new Rectangle(xPos, yPos, width, height);

                if (fill == false)
                {

                    g.DrawRectangle(bluePen, rect);

                }
                else
                {
                    g.FillRectangle(Brushes.Blue, rect);
                }

                p.Image = drawingSurface;

                g.Dispose();
            } else if(color.Equals("green"))
            {
                Pen greenPen = new Pen(Brushes.Green);

                Rectangle rect = new Rectangle(xPos, yPos, width, height);

                if (fill == false)
                {

                    g.DrawRectangle(greenPen, rect);

                }
                else
                {

                    g.FillRectangle(Brushes.Green, rect);

                }

                p.Image = drawingSurface;

                g.Dispose();
            } else
            {
                Pen redPen = new Pen(Brushes.Red);

                Rectangle rect = new Rectangle(xPos, yPos, width, height);

                if (fill == false)
                {

                    g.DrawRectangle(redPen, rect);

                }
                else
                {
                    g.FillRectangle(Brushes.Red, rect);
                }
                p.Image = drawingSurface;

                g.Dispose();
            }
    }  
    }
}
