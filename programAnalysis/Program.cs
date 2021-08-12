using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            int count = 0;

            int[] a = new int[n];

            a[0] = 10;
            a[1] = 9;
            a[2] = 8;
            a[3] = 7;
            a[4] = 6;
            a[5] = 5;
            a[6] = 4;
            a[7] = 3;
            a[8] = 2;
            a[9] = 1;
            a[10] = 0;

            for (int i = 0; i < n; i++)
            {
                int k = a[i];
                a[k] = 0;
            }
            for(int i = 0; i < n; i++)
            {
                if(a[i] != 0)
                    count++;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}