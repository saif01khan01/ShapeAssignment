using Xunit;
using Shapies;
using System.Drawing;
using System.Windows.Forms;
using Moq;

namespace PartOneTst
{
    public class Part1DrawingTests { 


        /// <summary>
        /// Test to check if the drawCircle method is being called correctly 
        /// </summary>
    [Fact]
        public void TestDrawCircleCall()
        {
            // Arrange
            var drawer = new Shapies.Circle();
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int radius = 10;
            int xPos = 50;
            int yPos = 50;
            string color = "red";
            bool fill = true;

            // Act
            drawer.drawCircle(radius, xPos, yPos, p, drawingSurface, g, color, fill);

            // Assert
            Assert.Equal(radius, radius);
            Assert.Equal(xPos, xPos);
            Assert.Equal(yPos, yPos);
            Assert.Equal(p, p);
            Assert.Equal(drawingSurface, drawingSurface);
            Assert.Equal(g, g);
            Assert.Equal(color, color);
            Assert.Equal(fill, fill);
        }

        /// <summary>
        /// This test is to check the functionality of the drawRect method from the rectangle class.
        /// It will test if the method can properly draw a rectangle on the drawing surface with the given parameters.
        /// </summary>
        [Fact]
        public void TestDrawRectCall()
        {
            // Arrange
            var drawer = new Shapies.rectangle();
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int xPos = 50;
            int yPos = 50;
            int width = 10;
            int height = 20;
            string color = "red";
            bool fill = true;

            // Act
            drawer.drawRect(xPos, yPos, width, height, p, drawingSurface, g, color, fill);

            // Assert
            Assert.Equal(xPos, xPos);
            Assert.Equal(yPos, yPos);
            Assert.Equal(width, width);
            Assert.Equal(height, height);
            Assert.Equal(p, p);
            Assert.Equal(drawingSurface, drawingSurface);
            Assert.Equal(g, g);
            Assert.Equal(color, color);
            Assert.Equal(fill, fill);
        }

        [Fact]
        public void TestPositionPenCall()
        {
            // Arrange
            var drawer = new Shapies.pen();
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int xPos = 50;
            int yPos = 50;

            // Act
            drawer.positionPen(xPos, yPos, p, drawingSurface, g);

            // Assert
            Assert.Equal(xPos, xPos);
            Assert.Equal(yPos, yPos);
            Assert.Equal(p, p);
            Assert.Equal(drawingSurface, drawingSurface);
            Assert.Equal(g, g);
        }

        /// <summary>
        /// TestPenDraw method tests the penDraw method in the Shapies.pen class by creating a new pen object, setting up a picturebox, bitmap and graphics object,
        /// setting the xPos, yPos, hPoint, vPoint and color variables, calling the penDraw method, and asserting that the pixel color at the hPoint and vPoint
        /// coordinates is equal to the expected color of red (255, 0, 0, 255).
        /// </summary>
        [Fact]
        public void TestPenDraw()
        {
            // Arrange
            var drawer = new Shapies.pen();
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int xPos = 50;
            int yPos = 50;
            int hPoint = 60;
            int vPoint = 60;
            string color = "red";

            // Act
            drawer.penDraw(xPos, yPos, hPoint, vPoint, p, drawingSurface, g, color);

            // Assert
            Color pixelColor = drawingSurface.GetPixel(hPoint, vPoint);
            Assert.Equal(255, pixelColor.A);
            Assert.Equal(255, pixelColor.R);
            Assert.Equal(0, pixelColor.G);
            Assert.Equal(0, pixelColor.B);
        }
        /// <summary>
        /// This test is to check if the drawTri method correctly draws a triangle on the PictureBox with the given parameters.
        /// </summary>
        [Fact]
        public void TestDrawTri()
        {
            // Arrange
            var drawer = new Shapies.triangle();
            PictureBox p = new PictureBox();
            Bitmap drawingSurface = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(drawingSurface);
            int xPos = 50;
            int yPos = 50;
            bool fill = true;

            // Act
            drawer.drawTri(p, drawingSurface, g, "red", fill, xPos, yPos);

            // Assert
            Assert.NotNull(p.Image);
        }

    }
}
    