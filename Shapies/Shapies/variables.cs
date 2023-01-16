using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Shapies
{
    public class variables
    {
        
        /// <summary>
        /// Converts a string representation of a variable declaration to an integer.
        /// </summary>
        /// <param name="declaration">
        /// The string representation of the variable declaration in the form of "name = value".
        /// </param>
        /// <returns>
        /// The integer value of the variable.
        /// </returns>
        /// <exception cref="FormatException">
        /// Thrown if the string provided is not in the correct format for a variable declaration.
        /// </exception>

        public static int ConvertToInt(string declaration)
        {
            // Extract the integer value from the declaration string
            string pattern = @"^(?<name>\w+) = (?<value>\d+)$";

            Match match = Regex.Match(declaration, pattern);
            string valueString = match.Groups["value"].Value;

            // Convert the extracted string to an integer and return it
            int value;

            if (int.TryParse(valueString, out value))
            {
                return value;
            }
            else
            {
                throw new FormatException("Error in variable declaration. Declare like this: 'size = {number};'");
            }
        }

        /// <summary>
        /// getVariableName method extracts the value of the "name" group and returns it from the given string declaration
        /// </summary>
        /// <param name="declaration">string to be matched with the regular expression</param>
        /// <returns>the value of the "name" group if the match is successful, otherwise returns null</returns>
        public static string getVariableName(string declaration)
        {
            // Compile the regular expression
            Regex regex = new Regex(@"^(?<name>\w+) = (?<value>\d+)$");

            // Match the regular expression to the declaration string
            Match match = regex.Match(declaration);

            // If the match is successful
            if (match.Success)
            {
                // Extract the value of the "name" group and return it
                return match.Groups["name"].Value;
               
            }

            // If the match is not successful, return null
            return null;
        }
    }
    }

