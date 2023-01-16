using Xunit;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapies;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject1
{
    [TestClass]
    public class CircleDrawingTests
    {

        [TestMethod]
        public void TestDrawRedGreenCircle()
        {
            // Arrange
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int radius = 10;
            int xPos = 50;
            int yPos = 50;
            string color = "redgreen";
            bool fill = false;


            // Act
            drawCircle(radius, xPos, yPos, p, drawingSurface, g, color, fill);
            Thread.Sleep(1000); // wait for thread to complete

            // Assert
            Color pixelColor = drawingSurface.GetPixel(xPos, yPos);
            Assert.AreEqual(Color.Red, pixelColor);
        }

        [TestMethod]
        public void TestDrawBlueYellowCircle()
        {
            // Arrange
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int radius = 10;
            int xPos = 50;
            int yPos = 50;
            string color = "blueyellow";
            bool fill = false;

            Shapies.Circle ca = new Shapies.Circle();
            // Act
            drawCircle(radius, xPos, yPos, p, drawingSurface, g, color, fill);
            Thread.Sleep(1000); // wait for thread to complete

            // Assert
            Color pixelColor = drawingSurface.GetPixel(xPos, yPos);
            Assert.AreEqual(Color.Blue, pixelColor);
        }

        [TestMethod]
        public void TestDrawBlackWhiteCircle()
        {
            // Arrange
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int radius = 10;
            int xPos = 50;
            int yPos = 50;
            string color = "blackwhite";
            bool fill = false;

            // Act
            drawCircle(radius, xPos, yPos, p, drawingSurface, g, color, fill);
            Thread.Sleep(1000); // wait for thread to complete

            // Assert
            Color pixelColor = drawingSurface.GetPixel(xPos, yPos);
            Assert.AreEqual(Color.Black, pixelColor);
        }
    }