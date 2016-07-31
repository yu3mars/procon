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
            string c = Console.ReadLine();
            string s = Console.ReadLine();
            s = s.Replace(c, "");
            Console.WriteLine(s);
        }
    }
}
