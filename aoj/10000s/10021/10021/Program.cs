using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ans = Console.ReadLine();
            for (int i = 1; i < n; i++)
            {
                string next = Console.ReadLine();
                if (ans.CompareTo(next) > 0)
                {
                    ans = next;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
