using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    internal class triangle
    {
        /**
      * <summary> this method positions the pen </summary>
      * 
      * <param name="p"> picture box where bitmap is drawn to </param>
      * <param name="drawingSurface"> bitmap where drawing is done to </param>
      * <param name="g"> graphics class which is used to draw </param>
      * <param name="color"> color of the shape, currently a string which is validated within the method </param>
      * <param name="fill"> checks to fill shape or not, user passes it and method validates this </param>
      * <param name="xPos"> x position, this is used as a point for the triangle </param>
      * <param name="yPos"> y position this is used as a point for the triangle s</param>
      * 
      * 
      * */
        public void drawTri(PictureBox p, Bitmap drawingSurface, Graphics g, string color, bool fill, int xPos, int yPos)
        {
            if(color.Equals("red"))
            {
                SolidBrush brush = new SolidBrush(Color.Red);

                Point[] points = { new Point(10, 10), new Point(100, 10), new Point(50, 100) };
                if(fill == true) { 
                g.FillPolygon(brush, points);
                } else
                {
                    Pen pens = new Pen(Brushes.Red);
                    g.DrawPolygon(pens, points);
                }

                p.Image = drawingSurface;

                g.Dispose(); 
            } else if (color.Equals("green"))
            {
                SolidBrush brush = new SolidBrush(Color.Green);

                Point[] points = { new Point(xPos, yPos), new Point(100, 10), new Point(50, 100) };

                if (fill == true)
                {
                    g.FillPolygon(brush, points);
                }
                else
                {
                    Pen pens = new Pen(Brushes.Green);
                    g.DrawPolygon(pens, points);
                }

                p.Image = drawingSurface;

                g.Dispose();
            } else if (color.Equals("blue"))
            {
                SolidBrush brush = new SolidBrush(Color.Blue);

                Point[] points = { new Point(10, 10), new Point(100, 10), new Point(50, 100) };

                if (fill == true)
                {
                    g.FillPolygon(brush, points);
                }
                else
                {
                    Pen pens = new Pen(Brushes.Blue);
                    g.DrawPolygon(pens, points);
                }

                p.Image = drawingSurface;

                g.Dispose();
            } else
            {
                SolidBrush brush = new SolidBrush(Color.Red);

                Point[] points = { new Point(10, 10), new Point(100, 10), new Point(50, 100) };

                if (fill == true)
                {
                    g.FillPolygon(brush, points);
                }
                else
                {
                    Pen pens = new Pen(Brushes.Red);
                    g.DrawPolygon(pens, points);
                }

                p.Image = drawingSurface;

                g.Dispose();
            }
            

        }
        

        }
    }
