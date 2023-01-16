using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    public class rectangle
    {


        /// <summary>
        /// Converts a string representation of a declaration to an integer.
        /// </summary>
        /// <param name="declaration">The string representation of the declaration, in the format "name = value".</param>
        /// <returns>The integer value of the declaration.</returns>
        /// <exception cref="FormatException">Thrown when the declaration is not in the correct format.</exception>
        public void drawRect(int xPos, int yPos, int width, int height, PictureBox p, Bitmap drawingSurface, Graphics g, string color, bool fill)
        {
            try
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
            }
            catch (FormatException e)
            {
                // show an error message or log the exception, as appropriate
                MessageBox.Show("width and height must be integers");
            }
        }
    }
}