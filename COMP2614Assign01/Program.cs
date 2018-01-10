using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign01
{
    class Program
    {
        static void Main(string[] args)
        {
            string columnTitle1 = "number";
            string columnTitle2 = "square";
            string columnTitle3 = "cube";

            double number = 0;
            double square = 0;
            double cube = 0;
          
            double countSum = 0;
            double squareSum = 0;
            double cubeSum = 0;

            Console.WriteLine("{0, 10} {1, 10} {2, 10}", columnTitle1, columnTitle2, columnTitle3);
            Console.WriteLine(DrawDashedLine());

            for (int index = 0; index <= 20; index++) {
                if (index % 2 == 0) {
                    number = index;
                    countSum += index;

                    square = Math.Pow(index, 2);
                    squareSum += Math.Pow(index, 2);

                    cube = Math.Pow(index, 3);
                    cubeSum += Math.Pow(index, 3);

                    Console.WriteLine("{0, 10:N0} {1, 10:N0} {2, 10:N0}", number, square, cube);
                }
            }
            Console.WriteLine(DrawDashedLine());
            Console.WriteLine("{0, 10:N0} {1, 10:N0} {2, 10:N0}", countSum, squareSum, cubeSum);
        }

        public static string DrawDashedLine()
        {
            string line = new string('-', 32);
            return line;
        }
    }

}
