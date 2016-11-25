using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static long N, A, B, C;

        static long Solve(long N, long A, long B, long C)
        {
            switch (N % 4)
            {
                case 1:
                    return Math.Min(Math.Min(3L * A, C), A + B);

                case 2:
                    return Math.Min(Math.Min(2L * A, B), 2L * C);

                case 3:
                    return Math.Min(Math.Min(A, 3L * C), B + C);

                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vals = input.Split(' ');
            N = long.Parse(vals[0]);
            A = long.Parse(vals[1]);
            B = long.Parse(vals[2]);
            C = long.Parse(vals[3]);

            //Console.WriteLine(Solve(N, A, B, C));

            long minVal = long.MaxValue;
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    for (int k = 0; k <= 10; k++)
                    {
                        if ((N + i + 2 * j + 3 * k) % 4 == 0)
                        {
                            minVal = Math.Min(minVal, A * i + B * j + C * k);
                        }
                    }
                }
            }

            Console.WriteLine(minVal);
        }
    }
}
