using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9BinDecOct
{
   
        class Decimal
        {
            public static void DecConvert(string message)
            {
                Console.WriteLine("enter a Decimal number: ");
                string number1 = Console.ReadLine();
                int convertnumber = Convert.ToInt32(number1, 10);
                Console.WriteLine("The binary version of this number is: ");
                Console.WriteLine(Convert.ToString(convertnumber, 2));
                Console.WriteLine("the octal version of this number is: ");
                Console.WriteLine(Convert.ToString(convertnumber, 8));
            }

        }
}

