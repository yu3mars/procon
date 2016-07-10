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
            int n = int.Parse(Console.ReadLine());
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            int[] ls = set.ToArray();
            Array.Sort(ls);
            Console.WriteLine(ls[ls.Length - 2]);
        }
    }
}
