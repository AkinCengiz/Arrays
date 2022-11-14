using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 15;
            int[,] dizi = new int[15, 15];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (j == i)
                    {
                        dizi[i, j] = 1;
                        dizi[i, deger - j - 1] = 1;
                    }

                    if (i == deger / 2)
                    {
                        dizi[i, j] = 1;
                    }

                    if (j == deger / 2)
                    {
                        dizi[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < deger; i++)
            {
                for (int j = 0; j < deger; j++)
                {
                    if (dizi[i, j] == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
