using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyclicShiftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[length];
            string[] arrayString = Console.ReadLine().Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = Convert.ToInt32(arrayString[i]);
                numbers[i] = number;
            }

            int lastNumber = numbers.Last();

            Console.Write(lastNumber +" ");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}