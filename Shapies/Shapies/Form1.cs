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

        private void button1_Click(object sender, EventArgs e)
        {
            saveAndLoad sal = new saveAndLoad();
            sal.save(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveAndLoad sal = new saveAndLoad();
            sal.load(textBox2);
        }
    }
    }
