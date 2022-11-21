namespace Shapies
{
    public partial class Form1 : Form
    {
       

        //Bitmap drawingSurface = new Bitmap(780, 443);
        
        Parser parse = new Parser();

        public Form1()
        {
            InitializeComponent();
        }

        private void run_program_Click(object sender, EventArgs e)
        {
           // Graphics g = Graphics.FromImage(drawingSurface);

            parse.parser(textBox1.Text, pictureBox1, textBox2);
        }

       
    }
    }
