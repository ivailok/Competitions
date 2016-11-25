using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        const int MAXN = 100;
        const int MAXM = 100;

        static int N, M;
        static int[] arr = new int[MAXN];
        static Tuple<int, int>[] subarr = new Tuple<int, int>[MAXM];

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vals = input.Split(' ');
            N = int.Parse(vals[0]);
            M = int.Parse(vals[1]);
            input = Console.ReadLine();
            vals = input.Split(' ');
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(vals[i]);
            }
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                vals = input.Split(' ');
                subarr[i] = new Tuple<int, int>(int.Parse(vals[0]) - 1, int.Parse(vals[1]) - 1);
            }

            int maxSum = 0;
            for (int i = 0; i < M; i++)
            {
                int sum = 0;
                for (int j = subarr[i].Item1; j <= subarr[i].Item2; j++)
                {
                    sum += arr[j];
                }

                if (sum > 0)
                {
                    maxSum += sum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
