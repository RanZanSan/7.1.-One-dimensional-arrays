using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rearrangeAdjacentElementsToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] arrayString = Console.ReadLine().Split();

            for (int index = 0; index < length - 1; index += 2)
            {
                Console.Write(arrayString[index + 1] + " " + arrayString[index] + " ");
            }

            if (length % 2 == 1)
            {
                Console.Write(arrayString[length - 1]);
            }

            Console.ReadKey();
        }
    }
}