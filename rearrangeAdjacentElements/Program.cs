using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rearrangeAdjacentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[length];
            string[] arrayString = Console.ReadLine().Split(' ');

            for (int index = 0; index < numbers.Length - 1; index++)
            {
                if (index % 2 != 0)
                    numbers[index - 1] = Convert.ToInt32(arrayString[index]);
                if (index % 2 == 0)
                    numbers[index + 1] = Convert.ToInt32(arrayString[index]);
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] != 0)
                    Console.Write(numbers[index] + " ");
                else
                    Console.Write(arrayString.Last() + " ");
            }

            Console.ReadKey();
        }
    }
}