using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndConditionalStatements
{
    class Demo2
    {
        void Main3()
        {
            string username = "kiran";
            string password = "Test@2018";

            string enteredUsername = "kiran";
            string enteredPassword = "aaaaaa";

            if (username == enteredUsername && password == enteredPassword)
            {
                Console.WriteLine("Welcome to Applications");
            }
            else
            {
                Console.WriteLine("User does not exist");
            }
            Console.ReadKey();
        }
    }
}
