namespace Shapies
{
    public partial class Form1 : Form
    {
        int xPos = 0;
        int yPos = 0;

        bool fill = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void run_program_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;

       
            if (a == "")
            {
                MessageBox.Show("Error fam no program entered");
            }
            else if (a.Contains("circle"))
            {
                string[] splittxt = a.Split(" ");
                int radius = Int32.Parse(splittxt[1]);
        
                Circle ca = new Circle();
                Bitmap drawingSurface = new Bitmap(780, 443);
                ca.drawCircle(radius, xPos, yPos, pictureBox1, drawingSurface);
            }
            else if (a.Contains("position pen"))
            {
                string[] splittxt = a.Split(" ");

                xPos = Int32.Parse(splittxt[2]);
                yPos = Int32.Parse(splittxt[3]);

                pen pen = new pen();

                Bitmap drawingSurface = new Bitmap(780, 443);
              
                pen.positionPen(xPos, yPos, pictureBox1, drawingSurface);
            }

        }
    }
}