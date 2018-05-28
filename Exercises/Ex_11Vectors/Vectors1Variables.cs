using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors._1
{
 
    public class Variables
    {
     
        public static void GeneratePoints()
        {
            var listX = new int[100];

            var listY = new int[100];

            var listC = Enumerable.Zip(listX, listY, (x, y) => new { x, y });

            Random randNum = new Random();

            var firstListElement = listC.ElementAt(0);

            var firstListElementCount = firstListElement.Count();

            int min = 1;

            int max = 100;

            for (int i = 0; i < listX.Length; i++)

            {

                    listX[i] = randNum.Next(min, max);

            }

            for (int j = 0; j < listY.Length; j++)

            {

                listY[j] = randNum.Next(min, max);

            }

            foreach (var item in listC)

            {

                Console.WriteLine("{0},{1}", item.x, item.y);

                Console.WriteLine($"{Math.Sqrt(Math.Pow((listX[i++] - listX[i]), 2) + Math.Pow((listY[j++] - listY[j]), 2))} ");

                

            }

        }

        public static void DoWork()

        {



        }

    }

}