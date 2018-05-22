using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9BinDecOct
{
    class Program
    {
        private static void Main(string[] args)
        {
            Program.DoWork();
        }

        private static void DoWork()
        {
            Console.WriteLine("Press 1 to convert a Binary number, Press 2 to convert an Octal number, Press 3 to convert a Decimal number: ");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                string input2 = input.ToString();
                Binary.BinConvert(input2);
            }

            else if (input == 2)
            {
                string input3 = input.ToString();
                Octal.OctConvert(input3);
            }

            else if (input == 3)
            {
                string input4 = input.ToString();
                Decimal.DecConvert(input4);
            }

            else if (input != 3 && input != 2 && input != 1)
            {
                Console.WriteLine("invalid number, try again");
                Program.DoWork();
            }

        }

    }

}
