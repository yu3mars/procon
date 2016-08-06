using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int[] cnt = new int[4];
            for (int i = 0; i < s.Length; i++)
            {
                cnt[s[i] - '1']++;
            }
            Console.WriteLine("{0} {1}", cnt.Max(), cnt.Min());
        }
    }
}
