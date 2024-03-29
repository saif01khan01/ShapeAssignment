﻿

using System.Text.RegularExpressions;

namespace Shapies
{
    public class Parser 
    {

        public int xPos;
        public int yPos;

        public string color = "red";


        Bitmap drawingSurface = new Bitmap(780, 443);

        bool fill = false;

        List<string> listVn = new List<string>();

        List<int> listV = new List<int>();


        public bool SyntaxCheck(string[] commands)
        {
            bool syntaxCheckPassed = true;
            string errorMessage = "";

            // Iterate through each command in the array
            for (int i = 0; i < commands.Length; i++)
            {
                string cmd = commands[i];

                // Check the syntax of the command using regular expressions
                if (Regex.IsMatch(cmd, @"^position pen (\d+|\w+) (\d+|\w+)$"))
                {
                    // The command has the correct syntax for "position pen <int or string> <int or string>"
                }
                else if (Regex.IsMatch(cmd, @"^pen draw (\d+|\w+) (\d+|\w+)$"))
                {
                    // The command has the correct syntax for "pen draw <int or string> <int or string>"
                }
                else if (Regex.IsMatch(cmd, @"^triangle$"))
                {
                    // The command has the correct syntax for "triangle"
                }
                else if (Regex.IsMatch(cmd, @"^color (red|green|blue|redgreen|blueyellow|blackwhite)$"))
                {
                    // The command has the correct syntax for "pen <color>"
                }
                else if (Regex.IsMatch(cmd, @"^fill (on|off)$"))
                {
                    // The command has the correct syntax for "fill <on/off>"
                }
                else if (Regex.IsMatch(cmd, @"^loop (\d+|\w+)$"))
                {
                    // The command has the correct syntax for "loop <int or string>"
                }
                else if (cmd == "end")
                {
                    // The command has the correct syntax for "end"
                }
                else if (Regex.IsMatch(cmd, @"^circle (\d+|\w+)$"))
                {
                    // The command has the correct syntax for "circle <int or string>"
                }
                else if (Regex.IsMatch(cmd, @"^rectangle (\d+|\w+) (\d+|\w+)$"))
                {
                    // The command has the correct syntax for "rectangle <int or string> <int or string>"
                }
                else if (Regex.IsMatch(cmd, @"^(\w+) = (\d+|\w+)$"))
                {
                    // The command has the correct syntax for "<variable name> = <int or string>"
                    var variableName = Regex.Match(cmd, @"^(\w+) = (\d+|\w+)$").Groups[1].Value;
                    var value = Regex.Match(cmd, @"^(\w+) = (\d+|\w+)$").Groups[2].Value;
                }
                else
                {
                    // The command does not have the correct syntax
                    syntaxCheckPassed = false;
                    errorMessage += "Invalid command syntax at line " + (i + 1) + ": " + cmd + "\n";
                }
            }

            // Display the result of the syntax check
            if (syntaxCheckPassed)
            {
                MessageBox.Show("Syntax check passed!");
                return true;
            }
            else
            {
                MessageBox.Show("Syntax check failed!\n" + errorMessage);
                return false;
            }
        }



        /// <summary>
        /// This method validates the user's entries and performs the appropriate action based on the command entered. 
        /// It checks for 'circle' and 'rectangle' and much more commands and performs the corresponding action. 
        /// It also uses regular expressions to validate the user's input and check for any errors.
        /// </summary>
        /// <param name="program"> The 'program' the user enters to draw </param>
        /// <param name="p"> Picture box where bitmap is drawn to, used here as it is unable to locally access the picturebox </param>
        /// <param name="textBox"> Textbox where user enters multiline commands </param>

        public void parser(string program, PictureBox p, TextBox textBox)
        {


            program.ToLower();

            string[] splitprogram = program.Split(" ");

            Graphics g = Graphics.FromImage(drawingSurface);

            switch (splitprogram[0])
            {

                case "circle":

                    try
                    {
                        if (Regex.IsMatch(program, @"circle\s+(\d+)"))
                        {
                            //circle command takes < 3 'parameters' this validates that
                            if (splitprogram.Count() < 3)
                            {
                                string[] splittxt = program.Split(" ");
                                int radius = Int32.Parse(splittxt[1]);
                                Circle ca = new Circle();
                                ca.drawCircle(radius, xPos, yPos, p, drawingSurface, g, color, fill);
                                break;
                            }
                        }
                        else if (Regex.IsMatch(program, @"^(?<command>circle) (?<name>\w+)$"))
                        {
                            // Initialize a flag to track if the circle variable has been found
                            bool found = false;

                            for (int b = 0; b < listVn.Count; b++)
                            {
                                if (listV[b] > 0 && listVn[b].Equals(splitprogram[1]))
                                {
                                    Circle ca = new Circle();
                                    int value = listV[b]; ca.drawCircle(value, xPos, yPos, p, drawingSurface, g, color, fill);
                                    // Set the flag to true to indicate that the circle variable has been found
                                    found = true;
                                }
                            }
                            // If the flag is still false after the loop has completed, it means that the circle variable has not been found
                            if (!found)
                            {
                                MessageBox.Show("error initialise variabel first");
                            }
                        }
                        else
                        {
                            MessageBox.Show("too many parameters for a circle");
                        }
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show("Must enter a numerical radius");
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        MessageBox.Show("Missing radius parameter");
                    }
                    catch (ArgumentException e)
                    {
                        MessageBox.Show("Invalid color value. Accepted values are 'redgreen', 'blueyellow' and 'blackwhite'.");
                    }
                    break;

                case "rectangle":

                    try
                    {
                        if (splitprogram.Count() < 4)
                        {
                            // Check if the input string matches the regex pattern for numerical width and height
                            if (Regex.IsMatch(program, @"rectangle \d+ \d+"))
                            {
                                // Get the width and height from the input string
                                int width = Int32.Parse(splitprogram[1]);
                                int height = Int32.Parse(splitprogram[2]);
                                // Create a rectangle object and draw it
                                rectangle rect = new rectangle();
                                rect.drawRect(xPos, yPos, width, height, p, drawingSurface, g, color, fill);
                            }
                            // Check if the input string matches the regex pattern for string width and height
                            else if (Regex.IsMatch(program, @"rectangle \w+ \w+"))
                            {
                                // Get the width and height variables from the program string
                                string width = splitprogram[1];
                                string height = splitprogram[2];

                                // Check if the width and height variables are defined in the list of variables
                                if (listVn.Contains(width) && listVn.Contains(height))
                                {
                                    // Get the index of the width and height variables in the list of names
                                    int widthIndex = listVn.IndexOf(width);
                                    int heightIndex = listVn.IndexOf(height);

                                    // Get the width and height values from the list of values
                                    int widthValue = listV[widthIndex];
                                    int heightValue = listV[heightIndex];

                                    // Create a rectangle object and draw it using the values of the width and height variables
                                    rectangle rect = new rectangle();
                                    rect.drawRect(xPos, yPos, widthValue, heightValue, p, drawingSurface, g, color, fill);
                                }
                                else
                                {
                                    // Show an error message if the width and height variables are not defined
                                    MessageBox.Show("width and/or height variables not defined");
                                }
                            }
                            else
                            {
                                // Show an error message if the input string does not match either of the regex patterns
                                throw new Exception("Invalid rectangle parameters");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    break;



                case "triangle":
                    try
                    {
                        triangle tri = new triangle();
                        tri.drawTri(p, drawingSurface, g, color, fill, xPos, yPos);
                    }
                    catch (FormatException ex)
                    {
                        // Handles the exception here
                        // shows a message box 
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    break;

                case "position":


                    try { 
                    
                    // declare pen class
                    pen pen = new pen();
                   

                    // Check if the input string matches the regex pattern for numerical x and y position
                    if (Regex.IsMatch(program, @"position pen \d+ \d+"))
                    {
                        // Get the x and y position from the input string
                        xPos = Int32.Parse(splitprogram[2]);
                        yPos = Int32.Parse(splitprogram[3]);

                        // Set the pen position to the specified x and y coordinates
                        pen.positionPen(xPos, yPos, p, drawingSurface, g);
                    }
                    // Check if the input string matches the regex pattern for string x and y position
                    else if (Regex.IsMatch(program, @"position pen \w+ \w+"))
                    {
                        // Get the x and y position variables from the program string
                        string xPos = splitprogram[2];
                        string yPos = splitprogram[3];

                        // Check if the x and y position variables are defined in the list of variables
                        if (listVn.Contains(xPos) && listVn.Contains(yPos))
                        {
                            // Get the index of the x and y position variables in the list of names
                            int xPosIndex = listVn.IndexOf(xPos);
                            int yPosIndex = listVn.IndexOf(yPos);

                            // Get the x and y position values from the list of values
                            int xPosValue = listV[xPosIndex];
                            int yPosValue = listV[yPosIndex];

                            // Set the pen position to the values of the x and y position variables
                            pen.positionPen(xPosValue, yPosValue, p, drawingSurface, g);
                        }
                        else
                        {
                            // Show an error message if the x and y position variables are not defined
                            MessageBox.Show("x and/or y position variables not defined");
                        }
                    }
                    else
                    {
                        // Show an error message if the input string does not match either of the regex patterns
                        MessageBox.Show("invalid position pen parameters");
                    }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception here, for example by showing an error message to the user
                        MessageBox.Show("An error occured: " + ex.Message);
                    }
                    break;

                case "pen":
                  
                    try { 
                    // Check if the input string matches the regex pattern for numerical x and y position
                    if (Regex.IsMatch(program, @"pen draw \d+ \d+"))
                    {
                        // Get the x and y position from the input string
                        int hPoint = Int32.Parse(splitprogram[2]);
                        int vPoint = Int32.Parse(splitprogram[3]);

                        // Draw a line using the pen to the specified x and y coordinates
                        pen pen1 = new pen();
                        pen1.penDraw(xPos, yPos, hPoint, vPoint, p, drawingSurface, g, color);
                    }
                    // Check if the input string matches the regex pattern for string x and y position
                    else if (Regex.IsMatch(program, @"pen draw \w+ \w+"))
                    {
                        // Get the x and y position variables from the program string
                        string hPoint = splitprogram[2];
                        string vPoint = splitprogram[3];

                        // Check if the x and y position variables are defined in the list of variables
                        if (listVn.Contains(hPoint) && listVn.Contains(vPoint))
                        {
                            // Get the index of the x and y position variables in the list of names
                            int hPointIndex = listVn.IndexOf(hPoint);
                            int vPointIndex = listVn.IndexOf(vPoint);

                            // Get the x and y position values from the list of values
                            int hPointValue = listV[hPointIndex];
                            int vPointValue = listV[vPointIndex];

                            // Draw a line using the pen to the values of the x and y position variables
                            pen pen1 = new pen();
                            pen1.penDraw(xPos, yPos, hPointValue, vPointValue, p, drawingSurface, g, color);
                        }
                        else
                        {
                            // Show an error message if the x and y position variables are not defined
                            MessageBox.Show("x and/or y position variables not defined");
                        }
                    }
                    else
                    {
                        // Show an error message if the input string does not match either of the regex patterns
                        MessageBox.Show("invalid pen draw parameters");
                    }
                    }
                    catch (Exception e)
                    {
                        // Handle the exception here, for example by showing an error message
                        MessageBox.Show("Invalid color: " + e.Message);
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

                    color.ToLower();

                    if (color.Equals("red") || color.Equals("green") || color.Equals("blue") || color.Equals("redgreen") || color.Equals("blueyellow") || color.Equals("blackwhite"))
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

                case string when Regex.IsMatch(program, @"^(?<name>\w+) = (?<value>\d+)$"):

                    string variableName = variables.getVariableName(program);

                    // Check if the list already contains the variable name
                    if (!listVn.Contains(variableName))
                    {
                        // Add the variable name to the list if it is not a duplicate
                        listVn.Add(variableName);

                        

                        // Convert the value to an integer and add it to the list of values
                        listV.Add(variables.ConvertToInt(program));

                        // Get the count of elements in the list
                        int count = listV.Count;

                       
                    }
                    else {
                        MessageBox.Show("error already exists");
                    
                    }
                        break;




                default:
                    MessageBox.Show("Error in your program enter valid input please");
                    break;
            }






        }


    }

}

