using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static int N;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            if ((N & 1) != 0)
            {
                Console.WriteLine(((N - 3) >> 1) + 1);
                for (int i = 0; i < ((N - 3) >> 1); i++)
                {
                    Console.Write("{0} ", 2);
                }
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(N >> 1);
                for (int i = 0; i < (N >> 1); i++)
                {
                    if (i != 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(2);
                }
                Console.WriteLine();
            }
        }
    }
}
