using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    class Circle
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

        public void drawCircle(int radius, int xPos, int yPos, PictureBox p, Bitmap drawingSurface, Graphics g, string color, bool fill)
        {
            if (color.Equals("redgreen"))
            {
                Thread redGreenThread = new Thread(() => {
                    while (true)
                    {
                        if (fill == false)
                        {
                            Pen redPen = new Pen(Brushes.Red);
                            g.DrawEllipse(redPen, xPos, yPos, radius * 2, radius * 2);
                        }
                        else
                        {
                            g.FillEllipse(Brushes.Red, xPos, yPos, radius * 2, radius * 2);
                        }
                        p.Image = drawingSurface;
                        Thread.Sleep(500);
                        if (fill == false)
                        {
                            Pen greenPen = new Pen(Brushes.Green);
                            g.DrawEllipse(greenPen, xPos, yPos, radius * 2, radius * 2);
                        }
                        else
                        {
                            g.FillEllipse(Brushes.Green, xPos, yPos, radius * 2, radius * 2);
                        }
                        p.Image = drawingSurface;
                        Thread.Sleep(500);
                    }
                });
                redGreenThread.Start();
            }
            else if (color.Equals("blueyellow"))
            {
                Thread blueYellowThread = new Thread(() => {
                    while (true)
                    {
                        if (fill == false)
                        {
                            Pen bluePen = new Pen(Brushes.Blue);
                            g.DrawEllipse(bluePen, xPos, yPos, radius * 2, radius * 2);
                        }
                        else
                        {
                            g.FillEllipse(Brushes.Blue, xPos, yPos, radius * 2, radius * 2);
                        }
                        p.Image = drawingSurface;
                        Thread.Sleep(500);
                        if (fill == false)
                        {
                            Pen yellowPen = new Pen(Brushes.Yellow);
                            g.DrawEllipse(yellowPen, xPos, yPos, radius * 2, radius * 2);
                        }
                        else
                        {
                            g.FillEllipse(Brushes.Yellow, xPos, yPos, radius * 2, radius * 2);
                        }
                        p.Image = drawingSurface;
                        Thread.Sleep(500);
                    }
                });
                blueYellowThread.Start();
            }
            else if (color.Equals("blackwhite"))
            {
                Thread blackWhiteThread = new Thread(() => {
                    while (true)
                    {
                        if (fill == false)
                        {
                            Pen blackPen = new Pen(Brushes.Black);
                            g.DrawEllipse(blackPen, xPos, yPos, radius * 2, radius * 2);
                        }
                        else
                        {
                            g.FillEllipse(Brushes.Black, xPos, yPos, radius * 2, radius * 2);
                        }
                        p.Image = drawingSurface;
                        Thread.Sleep(500);
                        if (fill == false)
                        {
                            Pen whitePen = new Pen(Brushes.White);
                            g.DrawEllipse(whitePen, xPos, yPos, radius * 2, radius * 2);
                        }
                        else
                        {
                            g.FillEllipse(Brushes.White, xPos, yPos, radius * 2, radius * 2);
                        }
                        p.Image = drawingSurface;
                        Thread.Sleep(500);
                    }
                });
                blackWhiteThread.Start();
            }
            else if (color.Equals("red"))
            {
                if (fill == false)
                {
                    Pen redPen = new Pen(Brushes.Red);
                    g.DrawEllipse(redPen, xPos, yPos, radius * 2, radius * 2);
                }
                else
                {
                    g.FillEllipse(Brushes.Red, xPos, yPos, radius * 2, radius * 2);
                }
                p.Image = drawingSurface;
            }
            else if (color.Equals("green"))
            {
                if (fill == false)
                {
                    Pen greenPen = new Pen(Brushes.Green);
                    g.DrawEllipse(greenPen, xPos, yPos, radius * 2, radius * 2);
                }
                else
                {
                    g.FillEllipse(Brushes.Green, xPos, yPos, radius * 2, radius * 2);
                }
                p.Image = drawingSurface;
            }
            else if (color.Equals("blue"))
            {
                if (fill == false)
                {
                    Pen bluePen = new Pen(Brushes.Blue);
                    g.DrawEllipse(bluePen, xPos, yPos, radius * 2, radius * 2);
                }
                else
                {
                    g.FillEllipse(Brushes.Blue, xPos, yPos, radius * 2, radius * 2);
                }
                p.Image = drawingSurface;
            }
            else
            {
                if (fill == false)
                {
                    Pen redPen = new Pen(Brushes.Red);
                    g.DrawEllipse(redPen, xPos, yPos, radius * 2, radius * 2);
                }
                else
                {
                    g.FillEllipse(Brushes.Red, xPos, yPos, radius * 2, radius * 2);
                }
                p.Image = drawingSurface;
            }
        }




    }
    }

