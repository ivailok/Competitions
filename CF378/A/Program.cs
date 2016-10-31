using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static bool IsVowel(char c)
        {
            if (c == 'A' || c == 'E' || c == 'O' || c == 'U' || c == 'Y' || c == 'I')
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = ' ' + str + ' ';
            int jumpSize = 1, pos = 0, next;
            do
            {
                next = pos + 1;
                while (str[next] != ' ' && !IsVowel(str[next]))
                {
                    next++;
                }
                jumpSize = Math.Max(jumpSize, next - pos);
                pos = next;
            } while (str[pos] != ' ');
            Console.WriteLine(jumpSize);
        }
    }
}
