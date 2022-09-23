using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0.0)
            {
                throw ArgumentOutOfRangeException("y", "You cannot divide by 0!");
            } else
            {
                return x / y;
            }
            
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName==null || fileName == "")
            {
                throw ArgumentNullException("fileName", "Must pass through a file.");
            }
            else if (fileName[fileName.Length-1] == "s" && fileName[fileName.Length-2] == "c" && fileName[fileName.Length-3] == ".")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try 
            {
                Divide(9.9, 0.0)
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            try
            {
                foreach(student s in students)
                {
                    CheckFileExtension(s);
                }
            }
            catch(ArgumentNullException t)
            {
                Console.WriteLine(t.Message);
            }


        }
    }
}
