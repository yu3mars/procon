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
            string s = Console.ReadLine().ToLower();
            s = s[0].ToString().ToUpper() + s.Substring(1);
            Console.WriteLine(s);
        }
    }
}
