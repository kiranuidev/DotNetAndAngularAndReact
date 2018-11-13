
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndConditionalStatements
{
    class Program1
    {
        static void Main1(string[] args)
        {

            //Syntax for declaring Variables
            //1. Datatype 2. Variable Name 3. Assignment
            //variable names willl be created usually in the camel Casing.

            int totalStudents = 10;
            string sessionName = "Dot Net";
            int attendance = 9;
            bool allAttended = false;

            //== Equality Operator
            // > Greater than
            // < less than
            // >= Greater than or equal to 
            // <= lessthan or equal to

            if (totalStudents > 8)
            {
                allAttended = true;
                Console.WriteLine("All the Students are atteneded");
            }
            else
            {
                allAttended = false;
                Console.WriteLine("Some of the Students are absent");
            }

            Console.ReadKey();
        }
    }
}
