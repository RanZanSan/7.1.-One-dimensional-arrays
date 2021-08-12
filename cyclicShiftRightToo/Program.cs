using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyclicShiftRightToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();
            string[] ss = s.Split(' ');

            int[] numbers = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = Convert.ToInt32(ss[i]);
                numbers[i] = number;
            }

            Console.Write(numbers[length - 1] + " ");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}