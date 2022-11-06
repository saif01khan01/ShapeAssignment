namespace Shapies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_program_Click(object sender, EventArgs e)
        {
            Circle ca = new Circle();
            ca.drawCircle(200, pictureBox1);
        }
    }
}