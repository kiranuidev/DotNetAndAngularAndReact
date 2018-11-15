using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //ArrayType[] variable name
        //string[] students = new string[5];
        //students[0] = "kiran";
        //students[1] = "Ravi";
        //students[2] = "John";
        //students[3] = "Geetha";
        //students[4] = "Pony";

        //for(int i=0;i<5;i++)
        //{
        //    Console.WriteLine(students[i]);
        //}
        string[] students = new string[] { "Jan", "Feb", "Mar" };
        
        for(int i=0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }
        Console.WriteLine("------------FOREACH---------------");
        //                   collection
        foreach(string item in students)
        {
            Console.WriteLine(item);   
        }
        Console.ReadKey();
    }
}

