using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors._2
{

    class Variables
    { 

		public static void GeneratePoints()

		{
            var listX = new int[100] ;
			var listY = new int[100] ;
            var listC = Enumerable.Zip(listX, listY, (x, y) => new { x, y });

            Random randNum = new Random();

            for (int i = 0; i < listX.Length; i++)
            {
                listX[i] = randNum.Next();
            }

            for (int i = 0; i < listY.Length; i++)
            {
                listY[i] = randNum.Next();
            }

            foreach (var item in listC)
            {
				Console.WriteLine("{0},{1}", item.x,item.y);
            }
		}
	}
}

