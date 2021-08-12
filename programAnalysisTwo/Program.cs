using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysisTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');

            int n = ss.Length;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(ss[i]);
            }

            int cnt = 0;

            for (int i = 1; i < n - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}