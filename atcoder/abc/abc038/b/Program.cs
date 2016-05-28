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
            int[] hw1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] hw2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool ok = false;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if(hw1[i]==hw2[j])
                    {
                        ok = true;
                    }
                }
            }
            if (ok) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
