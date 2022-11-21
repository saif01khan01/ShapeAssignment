using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    internal class Circle
    {
        

        /**
         * <summary> this method draws a circle at a specified radius</summary>
         * 
         * <param name="color"> color of the shape, currently a string which is validated within the method </param>
         * <param name="fill"> passed by the user to say if shape is to be filled or not </param>
         * <param name="drawingSurface"> bitmap which is drawn on </param>
         * <param name="g"> graphics class whichs drawing methods are used to draw a circle </param>
         * <param name="p"> picture box which is used to display bitmap </param>
         * <param name="radius"> radius of the circle </param>
         * <param name="xPos"> x position to which circle will be drawn </param>
         * <param name="yPos"> y position to which circle will be drawn </param>
         * 
         * 
         * */

        public void drawCircle(int radius, int xPos, int yPos, PictureBox p , Bitmap drawingSurface, Graphics g , string color , bool fill) {

            //validates colours
            if (color.Equals("red"))
            {
                Pen redPen = new Pen(Brushes.Red);

                Parser parse = new Parser();

                //checks fill if false unfilled shape drawn if true filled shape drawn
                if(fill == false) { 

                g.DrawEllipse(redPen, xPos, yPos, radius * 2, radius * 2);

                } else
                {
                    g.FillEllipse(Brushes.Red, xPos, yPos, radius * 2, radius * 2);
                }
                p.Image = drawingSurface;

                g.Dispose();
               
            } else if (color.Equals("green"))
            {
                Pen greenPen = new Pen(Brushes.Green);

                Parser parse = new Parser();

                if (fill == false)
                {
                    g.DrawEllipse(greenPen, xPos, yPos, radius * 2, radius * 2);

                } else
                {
                    g.FillEllipse(Brushes.Green, xPos, yPos, radius * 2, radius * 2);
                }

                p.Image = drawingSurface;

                g.Dispose();
            }
            else if (color.Equals("blue"))
            {
                Pen bluePen = new Pen(Brushes.Blue);

                Parser parse = new Parser();

                if (fill == false)
                {
                    g.DrawEllipse(bluePen, xPos, yPos, radius * 2, radius * 2);

                }
                else
                {
                    g.FillEllipse(Brushes.Blue, xPos, yPos, radius * 2, radius * 2);
                }
                
                p.Image = drawingSurface;

                g.Dispose();
            } else
            {
                Pen redPen = new Pen(Brushes.Red);

                Parser parse = new Parser();

                if (fill == false)
                {

                    g.DrawEllipse(redPen, xPos, yPos, radius * 2, radius * 2);

                }
                else
                {
                    g.FillEllipse(Brushes.Red, xPos, yPos, radius * 2, radius * 2);
                }
                p.Image = drawingSurface;

                g.Dispose();
            }




        }
    }
}
