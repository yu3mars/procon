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
            int ans = int.Parse(s[0].ToString()) + int.Parse(s[1].ToString());
            Console.WriteLine(ans);
        }
    }
}
