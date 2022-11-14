using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] rastgeleDizi = new int[100];
            for (int i = 0; i < rastgeleDizi.Length; i++)
            {
                rastgeleDizi[i]=random.Next(1,11);
            }
            int[] adet = new int[10];
            for (int i = 0; i < 100; i++)
            {
                adet[rastgeleDizi[i] - 1]++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,2} Adet -----> {1,2} ", adet[i], i + 1);
                for (int j = 0; j < adet[i]; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
