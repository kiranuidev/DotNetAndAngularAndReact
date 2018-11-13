using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndConditionalStatements
{
    class Demo4
    {//Method Syntax
        // returntype  Methodname(paramerters)
        static int addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }


        static int division(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            else
            {
                return 0;
            }

        }
    }
}
