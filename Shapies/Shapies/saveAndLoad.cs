using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapies
{
    public class saveAndLoad
    {
        
          
         /// <summary> saves string to text file at path specified</summary>
         /// 
         /// <param name="tosave"> passes string that will be saved to the text file </param>
        public void save(string tosave)
        {
            System.IO.File.WriteAllText(@"C:\Users\msaif\source\repos\saif01khan01\ShapeAssignment\ShapeAssignment\Shapies\Shapies\formProgram.txt", tosave);
        }
        
        
       /// <summary> loads string from text file at path specified</summary>
       /// 
       /// <param name="t"> uses textbox parameter so we can define which text box to write the textfile to  </param>
        public void load(TextBox t)
        {
            t.Text = File.ReadAllText(@"C:\Users\msaif\source\repos\saif01khan01\ShapeAssignment\ShapeAssignment\Shapies\Shapies\formProgram.txt");
        }
    }
}
