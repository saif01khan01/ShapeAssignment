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
            Pen pen = new Pen(Brushes.Red);
            Brush brush = new SolidBrush(Color.Red);
            Point[] points = { new Point(xPos, yPos), new Point(100, 10), new Point(50, 100) };
            Thread thread;

            switch (color)
            {
                case "red":
                    pen = new Pen(Brushes.Red);
                    brush = new SolidBrush(Color.Red);
                    break;
                case "green":
                    pen = new Pen(Brushes.Green);
                    brush = new SolidBrush(Color.Green);
                    break;
                case "blue":
                    pen = new Pen(Brushes.Blue);
                    brush = new SolidBrush(Color.Blue);
                    break;
                case "redgreen":
                    // Create a new thread for flashing red and green
                    thread = new Thread(() =>
                    {
                        while (true)
                        {
                            pen = new Pen(Brushes.Red);
                            brush = new SolidBrush(Color.Red);
                            if (fill)
                                g.FillPolygon(brush, points);
                            else
                                g.DrawPolygon(pen, points);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);

                            pen = new Pen(Brushes.Green);
                            brush = new SolidBrush(Color.Green);
                            if (fill)
                                g.FillPolygon(brush, points);
                            else
                                g.DrawPolygon(pen, points);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);
                        }
                    });
                    thread.Start();
                    return;
                case "blueyellow":
                    // Create a new thread for flashing blue and yellow
                    thread = new Thread(() =>
                    {
                        while (true)
                        {
                            pen = new Pen(Brushes.Blue);
                            brush = new SolidBrush(Color.Blue);
                            if (fill)
                                g.FillPolygon(brush, points);
                            else
                                g.DrawPolygon(pen, points);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);

                            pen = new Pen(Brushes.Yellow);
                            brush = new SolidBrush(Color.Yellow);
                            if (fill)
                                g.FillPolygon(brush, points);
                            else
                                g.DrawPolygon(pen, points);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);
                        }
                    });
                    thread.Start();
                    return;
                case "blackwhite":
                    // Create a new thread for flashing black and white
                    thread = new Thread(() =>
                    {
                        while (true)
                        {
                            pen = new Pen(Brushes.Black);
                            brush = new SolidBrush(Color.Black);
                            if (fill)
                                g.FillPolygon(brush, points);
                            else
                                g.DrawPolygon(pen, points);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);

                            pen = new Pen(Brushes.White);
                            brush = new SolidBrush(Color.White);
                            if (fill)
                                g.FillPolygon(brush, points);
                            else
                                g.DrawPolygon(pen, points);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);
                        }
                    });
                    thread.Start();
                    return;
                default:
                    break;
            }

            if (fill)
                g.FillPolygon(brush, points);
            else
                g.DrawPolygon(pen, points);
            p.Image = drawingSurface;
            g.Dispose();
        }
    }
}
                       