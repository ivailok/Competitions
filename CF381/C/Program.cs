using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        const int MAXN = 100000;
        const int MAXM = 100000;

        static int N, M;
        static Tuple<int, int>[] subarr = new Tuple<int, int>[MAXM];

        static int[] ans = new int[MAXN];

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vals = input.Split(' ');
            N = int.Parse(vals[0]);
            M = int.Parse(vals[1]);
            
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                vals = input.Split(' ');
                subarr[i] = new Tuple<int, int>(int.Parse(vals[0]) - 1, int.Parse(vals[1]) - 1);
            }

            int minLength = N;
            for (int i = 0; i < M; i++)
            {
                minLength = Math.Min(minLength, subarr[i].Item2 - subarr[i].Item1 + 1);
            }
            
            for (int i = 0; i < N; i++)
            {
                ans[i] = i % minLength;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                if (i != 0)
                {
                    sb.Append(" ");
                }
                sb.Append(ans[i]);
            }
            Console.WriteLine(minLength);
            Console.WriteLine(sb.ToString());
        }
    }
}
