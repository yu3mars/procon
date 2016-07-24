using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nl = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] s = new string[nl[0]];
            for (int i = 0; i < nl[0]; i++)
            {
                s[i] = Console.ReadLine();
            }
            Array.Sort(s);
            Console.WriteLine(String.Join("", s));
        }
    }
}
