using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string ans = s[(n - 1) / 5].ToString() + s[(n - 1) % 5].ToString();
            Console.WriteLine(ans);
        }
    }
}
