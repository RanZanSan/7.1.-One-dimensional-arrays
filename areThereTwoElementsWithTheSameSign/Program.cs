using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areThereTwoElementsWithTheSameSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[length];
            string[] ss = Console.ReadLine().Split(' ');

            for (int index = 0; index < numbers.Length; index++)
            {
                int number = Convert.ToInt32(ss[index]);
                numbers[index] = number;
            }

            int comparisonVar = numbers[0];
            int count = 1;

            for (int index = 1; index < numbers.Length; index++)
            {
                if ((comparisonVar * numbers[index]) > 0)
                {
                    comparisonVar = numbers[index];
                    count++;

                    if (count == 2)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                }
                else
                {
                    comparisonVar = numbers[index];
                    count = 1;
                }
            }

            if (count < 2)
                Console.WriteLine("NO");

            Console.ReadKey();
        }
    }
}