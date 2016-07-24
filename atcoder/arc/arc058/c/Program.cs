using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] d = Console.ReadLine().Split(' ');
            for (int i = nk[0]; ; i++)
            {
                string s = i.ToString();
                bool ok = true;
                for (int j = 0; j < d.Length; j++)
                {
                    if (s.Contains(d[j]))
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
