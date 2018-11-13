using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndConditionalStatements
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Write a program to print numbers for 0 to 10;
            for(int i = 1; i <= 10; )
            {
                Console.WriteLine(i);
                i = i * 2;
            }
            Console.ReadKey();
        }

    }
}
