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
        public void drawRect(int xPos, int yPos, int width, int height, PictureBox p, Bitmap drawingSurface, Graphics g, string color, bool fill)
        {
            Pen pen;
            Brush brush;
            Rectangle rect = new Rectangle(xPos, yPos, width, height);

            switch (color)
            {
                case "red":
                    pen = new Pen(Brushes.Red);
                    brush = Brushes.Red;
                    break;
                case "green":
                    pen = new Pen(Brushes.Green);
                    brush = Brushes.Green;
                    break;
                case "blue":
                    pen = new Pen(Brushes.Blue);
                    brush = Brushes.Blue;
                    break;
                case "redgreen":
                    // Create a new thread for flashing red and green
                    Thread thread = new Thread(() =>
                    {
                        while (true)
                        {
                            pen = new Pen(Brushes.Red);
                            brush = Brushes.Red;
                            if (fill)
                                g.FillRectangle(brush, rect);
                            else
                                g.DrawRectangle(pen, rect);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);

                            pen = new Pen(Brushes.Green);
                            brush = Brushes.Green;
                            if (fill)
                                g.FillRectangle(brush, rect);
                            else
                                g.DrawRectangle(pen, rect);
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
                            brush = Brushes.Blue;
                            if (fill)
                                g.FillRectangle(brush, rect);
                            else
                                g.DrawRectangle(pen, rect);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);

                            pen = new Pen(Brushes.Yellow);
                            brush = Brushes.Yellow;
                            if (fill)
                                g.FillRectangle(brush, rect);
                            else
                                g.DrawRectangle(pen, rect);
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
                            brush = Brushes.Black;
                            if (fill)
                                g.FillRectangle(brush, rect);
                            else
                                g.DrawRectangle(pen, rect);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);

                            pen = new Pen(Brushes.White);
                            brush = Brushes.White;
                            if (fill)
                                g.FillRectangle(brush, rect);
                            else
                                g.DrawRectangle(pen, rect);
                            p.Image = drawingSurface;
                            Thread.Sleep(500);
                        }
                    });
                    thread.Start();
                    return;
                default:
                    pen = new Pen(Brushes.Red);
                    brush = Brushes.Red;
                    break;
            }

            if (fill)
                g.FillRectangle(brush, rect);
            else
                g.DrawRectangle(pen, rect);
            p.Image = drawingSurface;
            g.Dispose();
        }
    }
}