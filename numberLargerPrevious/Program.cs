using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberLargerPrevious
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();
            string[] ss = s.Split(' ');

            int[] numbers = new int[length];

            for (int index = 0; index <= numbers.Length - 1; index++)
            {
                int number = Convert.ToInt32(ss[index]);
                numbers[index] = number;
            }

            int comparisonVariable = numbers[0];
            int count = 0;

            for(int index = 0; index < numbers.Length; index++)
            {
                if(numbers[index] > comparisonVariable)
                {
                    count++;
                    comparisonVariable = numbers[index];
                }
                else
                    comparisonVariable = numbers[index];
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}