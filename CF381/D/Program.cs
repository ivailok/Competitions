using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        const int MAXN = 200000;

        static int N;
        static int[] a = new int[MAXN];
        static List<Tuple<int, int>>[] children = new List<Tuple<int, int>>[MAXN];

        static List<int> path;

        static void DFS(int at)
        {

        }

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string[] vals = input.Split(' ');
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(vals[i]);
            }

            for (int i = 1; i < N; i++)
            {
                input = Console.ReadLine();
                vals = input.Split(' ');
                int parent = int.Parse(vals[0]) - 1, weight = int.Parse(vals[1]);
                if (children[parent] == null)
                {
                    children[parent] = new List<Tuple<int, int>>();
                }
                children[parent].Add(new Tuple<int, int>(i, weight));
            }


        }
    }
}
