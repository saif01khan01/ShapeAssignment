

using System.Text.RegularExpressions;

namespace Shapies
{
    internal class Parser 
    {

        public int xPos;
        public int yPos;

        string variableName;

        List<string> listVn = new List<string>();

        List<int> listV = new List<int>();


        int value;

        public string color = "red";


        Bitmap drawingSurface = new Bitmap(780, 443);

        bool fill = false;

        public void multiLineParse(string[] program, PictureBox p, TextBox textBox)
        {
            for (int i = 0; i < program.Length; i++) {
                program[i].ToLower();

                string[] splitprogram = program[i].Split(" ");

                Graphics g = Graphics.FromImage(drawingSurface);

                switch (splitprogram[0])
                {
                    case "circle" when Regex.IsMatch(program[i], @"^(?<command>circle) (?<name>\w+)$") || Regex.IsMatch(program[i], @"^\bcircle\s+(\d+)\b$"):

                        for (int b = 0; b < listVn.Count; b++)
                        {
                            if (listV[b] > 0 && listVn[b].Equals(splitprogram[1]))
                            {
                                Circle ca = new Circle();

                                int value = listV[b];

                                ca.drawCircle(value, xPos, yPos, p, drawingSurface, g, color, fill);

                            }
                            else if (listV[b] == 0)
                            {
                                MessageBox.Show("error initialise variable first");
                            }
                        }
                        if (Regex.IsMatch(program[i], @"^\bcircle\s+(\d+)\b$"))
                        {
                            //circle command takes < 3 'parameters' this validates that
                            if (splitprogram.Count() < 3)
                            {

                                //tries to parse string to int catches exceptions if not
                                try
                                {

                                    string[] splittxt = program[i].Split(" ");


                                    int radius = Int32.Parse(splittxt[1]);

                                    Circle ca = new Circle();

                                    ca.drawCircle(radius, xPos, yPos, p, drawingSurface, g, color, fill);

                                }
                                catch (FormatException)
                                {
                                    MessageBox.Show("Must enter a numerical radius");


                                }
                                catch (IndexOutOfRangeException)
                                {
                                    MessageBox.Show("Missing radius parameter");
                                }

                            }
                            else
                            {
                                MessageBox.Show("too many parameters for a circle");
                            }
                        }

                        break;

                    case "rectangle":

                        if (splitprogram.Count() < 4)
                        {

                            string[] splittxt3 = program[i].Split(" ");

                            //tries to parse string to int catches exceptions if not
                            try
                            {

                                int width = Int32.Parse(splittxt3[1]);
                                int height = Int32.Parse(splittxt3[2]);

                                rectangle rect = new rectangle();

                                rect.drawRect(xPos, yPos, width, height, p, drawingSurface, g, color, fill);
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("must enter numerical width and height");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("missing height and/or weight parameter");
                            }
                        }
                        else
                        {
                            MessageBox.Show("too many parameters for a rectangle");
                        }
                        break;

                    case "triangle":

                        triangle tri = new triangle();

                        tri.drawTri(p, drawingSurface, g, color, fill, xPos, yPos);
                        break;

                    case "position":

                        string[] splittxt1 = program[i].Split(" ");

                        if (splitprogram.Count() < 5 && splitprogram[1].Equals("pen"))
                        {

                            int index1 = splittxt1.Length;

                            try
                            {

                                xPos = Int32.Parse(splittxt1[2]);
                                yPos = Int32.Parse(splittxt1[3]);

                                Console.WriteLine(xPos + yPos);

                                pen pen = new pen();

                                pen.positionPen(xPos, yPos, p, drawingSurface, g);

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("must enter numerical value");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("missing x and y position numerical values");
                            }
                        }
                        else if (splitprogram.Count() > 5)
                        {
                            MessageBox.Show("too many parameters for a positioning of a pen");

                        }
                        else
                        {
                            MessageBox.Show("incorrect parameters did you mean 'position pen 'xPos' 'yPos' '");
                        }

                        break;

                    case "pen":

                        string[] splittxt2 = program[i].Split(" ");

                        if (splitprogram.Count() < 5 && splitprogram[1].Equals("draw"))
                        {
                            int index2 = splittxt2.Length;
                            int hPoint = 0;

                            try
                            {
                                hPoint = Int32.Parse(splittxt2[2]);
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("enter a numerical value for drawing points");
                                break;
                            }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("Error you are missing the numerical points to draw to");
                                break;
                            }
                            int vPoint = 0;
                            try
                            {
                                vPoint = Int32.Parse(splittxt2[3]);
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("enter a numerical value for drawing points");
                                break;
                            }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("Error you are missing the numerical points to draw to");
                                break;
                            }

                            pen pen1 = new pen();

                            pen1.penDraw(xPos, yPos, hPoint, vPoint, p, drawingSurface, g, color);
                            break;


                        }
                        else if (splitprogram.Count() > 5)
                        {
                            MessageBox.Show("too many parameters for a pen draw did you mean 'pen draw 'xPos' 'yPos'");
                        }
                        else
                        {
                            MessageBox.Show("error try 'pen draw 'x''y'");
                        }
                        break;


                    case "reset":

                        pen pen2 = new pen();

                        xPos = 0;

                        yPos = 0;

                        pen2.positionPen(xPos, yPos, p, drawingSurface, g);

                        break;


                    case "clear":

                        p.Image = null;

                        drawingSurface.Dispose();

                        drawingSurface = new Bitmap(780, 443);

                        break;

                    case "color":

                        if (color.Equals("red") || color.Equals("green") || color.Equals("blue"))
                        {
                            color = splitprogram[1];
                            break;
                        }
                        else
                        {
                            MessageBox.Show("choose color between red green and blue please");
                            break;
                        }


                    case "fill":

                        if (splitprogram[1].Equals("on"))
                        {
                            fill = true;
                            break;
                        }
                        else if (splitprogram[1].Equals("off"))
                        {
                            fill = false;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Enter fill 'on/off' only");
                            break;
                        }

                    case "run":

                        int x = variables.ConvertToInt("x = 11;");

                        string a = x.ToString();

                        MessageBox.Show(a);

                        break;

                    case string when Regex.IsMatch(program[i], @"^(?<name>\w+) = (?<value>\d+)$"):

                        listV.Add(variables.ConvertToInt(program[i]));

                        listVn.Add(variables.getVariableName(program[i]));

                        int count = listV.Count;

                        MessageBox.Show("it works" + listV[count - 1] + listVn[count - 1]);

                        break;

                    case string when Regex.IsMatch(program[i], @"^(?<command>circle|triangle|square) (?<name>\w+)$"):

                        MessageBox.Show("yo it works ahahah");

                        break;

                    default:
                        MessageBox.Show("Error in your program enter valid input please");
                        break;
                }
            }
        }

        /**
       * <summary> this method validates the users entries the main bulk of it is a switch statment that will execute the code related to each case if it matches what the user has entered. 
       * To match up the variables and to use the variables the user has declared in the final few cases,
       * we have used regular expressions and then some additional validation </summary>
       * 
       * <param name="p"> picture box where bitmap is drawn to, i have used it here as unable to locally access picturebox </param>
       * <param name="program"> this is the 'program' the user enters to draw </param>
       * <param name="textBox"> textbox where user enters multiline commands </param>
       * 
       * 
       * */

        public void parser(string program, PictureBox p)
        {
           

            program.ToLower();

            string[] splitprogram = program.Split(" ");

            Graphics g = Graphics.FromImage(drawingSurface);

            switch (splitprogram[0])
            {
                case "circle" when Regex.IsMatch(program, @"^(?<command>circle|triangle|square) (?<name>\w+)$") || Regex.IsMatch(program, @"^\bcircle\s+(\d+)\b$"):

                    for (int i = 0; i < listVn.Count; i++)
                    {
                        if (listV[i] > 0 && listVn[i].Equals(splitprogram[1]))
                        {
                            Circle ca = new Circle();

                            ca.drawCircle(listV[i], xPos, yPos, p, drawingSurface, g, color, fill);

                        }
                        else if (listV[i] == 0)
                        {
                            MessageBox.Show("error initialise variable first");
                        }
                    }
                        if (Regex.IsMatch(program, @"^\bcircle\s+(\d+)\b$"))
                        {

                            //circle command takes < 3 'parameters' this validates that
                            if (splitprogram.Count() < 3)
                            {

                                //tries to parse string to int catches exceptions if not
                                try
                                {

                                    string[] splittxt = program.Split(" ");


                                    int radius = Int32.Parse(splittxt[1]);

                                    Circle ca = new Circle();

                                    ca.drawCircle(radius, xPos, yPos, p, drawingSurface, g, color, fill);

                                }
                                catch (FormatException)
                                {
                                    MessageBox.Show("Must enter a numerical radius");


                                }
                                catch (IndexOutOfRangeException)
                                {
                                    MessageBox.Show("Missing radius parameter");
                                }

                            }
                            else
                            {
                                MessageBox.Show("too many parameters for a circle");
                            }
                        }
                    
                    break;

                case "rectangle":

                    if(splitprogram.Count()<4) {

                        string[] splittxt3 = program.Split(" ");

                        //tries to parse string to int catches exceptions if not
                        try
                        { 

                        int width = Int32.Parse(splittxt3[1]);
                        int height = Int32.Parse(splittxt3[2]);

                    rectangle rect = new rectangle();

                    rect.drawRect(xPos, yPos, width, height, p, drawingSurface , g , color , fill);
                        }
                        catch (FormatException )
                        {
                            MessageBox.Show("must enter numerical width and height");
                        }
                        catch (IndexOutOfRangeException )
                        {
                            MessageBox.Show("missing height and/or weight parameter");
                        }
                    }
                    else
                    {
                        MessageBox.Show("too many parameters for a rectangle");
                    }
                    break;

                case "triangle" : 

                    triangle tri = new triangle();

                    tri.drawTri(p, drawingSurface, g, color, fill, xPos, yPos);
                    break;

                case "position":

                    string[] splittxt1 = program.Split(" ");

                    if(splitprogram.Count()<5 && splitprogram[1].Equals("pen")) { 

                    int index1 = splittxt1.Length;

                        try { 

                    xPos = Int32.Parse(splittxt1[2]);
                    yPos = Int32.Parse(splittxt1[3]);

                    Console.WriteLine(xPos + yPos);

                    pen pen = new pen();

                    pen.positionPen(xPos, yPos, p, drawingSurface, g);

                        }
                        catch (FormatException )
                        {
                            Console.WriteLine("must enter numerical value");
                        }
                        catch (IndexOutOfRangeException )
                        {
                            Console.WriteLine("missing x and y position numerical values");
                        }
                    } else if(splitprogram.Count() > 5)
                    {
                        MessageBox.Show("too many parameters for a positioning of a pen");

                    } else
                    {
                        MessageBox.Show("incorrect parameters did you mean 'position pen 'xPos' 'yPos' '");
                    }
         
                    break;

                case "pen":
                   
                    string[] splittxt2 = program.Split(" ");

                    if (splitprogram.Count() < 5 && splitprogram[1].Equals("draw"))
                    {
                        int index2 = splittxt2.Length;
                        int hPoint = 0;

                        try
                        {
                            hPoint = Int32.Parse(splittxt2[2]);
                        }
                        catch (FormatException )
                        {
                            MessageBox.Show("enter a numerical value for drawing points");
                            break;
                        }
                        catch (IndexOutOfRangeException )
                        {
                            MessageBox.Show("Error you are missing the numerical points to draw to");
                            break;
                        }
                        int vPoint = 0;
                        try
                        {
                           vPoint = Int32.Parse(splittxt2[3]);
                        }
                        catch (FormatException )
                        {
                            MessageBox.Show("enter a numerical value for drawing points");
                            break;
                        }
                        catch (IndexOutOfRangeException )
                        {
                            MessageBox.Show("Error you are missing the numerical points to draw to");
                            break;
                        }

                        pen pen1 = new pen();

                        pen1.penDraw(xPos, yPos, hPoint, vPoint, p, drawingSurface, g , color);
                        break;


                    } else if(splitprogram.Count() > 5)
                    {
                        MessageBox.Show("too many parameters for a pen draw did you mean 'pen draw 'xPos' 'yPos'");
                    } else
                    {
                        MessageBox.Show("error try 'pen draw 'x''y'");
                    }
                     break;


                case "reset":

                    pen pen2 = new pen();

                    xPos = 0;

                    yPos = 0;

                    pen2.positionPen(xPos, yPos, p, drawingSurface, g);

                    break;


                case "clear":

                    p.Image = null;

                    drawingSurface.Dispose();

                    drawingSurface = new Bitmap(780, 443);
                   
                    break;

                case "color":

                    if(color.Equals("red") || color.Equals("green") || color.Equals("blue"))
                    {

                        color = splitprogram[1];
                        break;
                    } else
                    {
                        MessageBox.Show("choose color between red green and blue please");
                        break;
                    }
                   

                case "fill":

                    if (splitprogram[1].Equals("on"))
                    {
                        fill = true;
                        break;
                    } else if(splitprogram[1].Equals("off"))
                    {
                        fill = false;
                        break;
                    } else
                    {
                        MessageBox.Show("Enter fill 'on/off' only");
                        break;
                    }

                case "run":

                    int x = variables.ConvertToInt("x = 11;");

                    string a = x.ToString();

                    MessageBox.Show(a);

                    break;

                case string when Regex.IsMatch(program, @"^(?<name>\w+) = (?<value>\d+)$"):

                    listV.Add(variables.ConvertToInt(program));

                    listVn.Add(variables.getVariableName(program));

                    int count = listV.Count;

                    MessageBox.Show("it works" + listV[count-1] + listVn[count-1]);

                    break;

                case string when Regex.IsMatch(program, @"^(?<command>circle|triangle|square) (?<name>\w+)$"):

                    MessageBox.Show("yo it works ahahah");
                    
                    break;

                default: MessageBox.Show("Error in your program enter valid input please");
                    break;
            }



         
         

        }
            
       
            }

        }

        
