using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static int N;

        static int[] R = new int[100000];
        static int[] L = new int[100000];

        static void Main(string[] args)
        {
            int val = 0, col = 0;
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                var data = s.Split(' ');
                L[i] = int.Parse(data[0]);
                R[i] = int.Parse(data[1]);
                val += L[i];
                val -= R[i];
            }

            int beaty = Math.Abs(val);
            for (int i = 0; i < N; i++)
            {
                int updVal = val - 2 * L[i] + 2 * R[i];
                if (beaty < Math.Abs(updVal)) {
                    beaty = Math.Abs(updVal);
                    col = i + 1;
                }
            }

            Console.WriteLine(col);
        }
    }
}
