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

        /// <summary>
        /// This event handler for the "Run Program" button calls the parser method with the input from the textbox.
        /// </summary>
        /// <param name="sender">The button object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void run_program_Click(object sender, EventArgs e)
        {
           // Graphics g = Graphics.FromImage(drawingSurface);

           parse.parser(textBox1.Text, pictureBox1 , textBox1);
        }

        /// <summary>
        /// This event handler for the "Save" button calls the save method of the saveAndLoad class with the input from the textbox.
        /// </summary>
        /// <param name="sender">The button object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void button1_Click(object sender, EventArgs e)
        {
            saveAndLoad sal = new saveAndLoad();
            sal.save(textBox2.Text);
        }

        /// <summary>
        /// This event handler for the "Load" button calls the load method of the saveAndLoad class with the input from the textbox.
        /// </summary>
        /// <param name="sender">The button object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void button2_Click(object sender, EventArgs e)
        {
            saveAndLoad sal = new saveAndLoad();
            sal.load(textBox2);
        }

        /// <summary>
        /// This event handler for the "Multi-Line" button calls the parse.SyntaxCheck method and parse.parser method with the input from the textbox.
        /// </summary>
        /// <param name="sender">The button object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void multiBtn_Click(object sender, EventArgs e)
{
            string[] multilines = textBox2.Text.Split(Environment.NewLine);
          
            if(parse.SyntaxCheck(multilines))
            {
                 foreach (string prog in multilines)
                {
                    parse.parser(prog, pictureBox1, textBox2);
                 }
            } 
        }

        
    }
    }
