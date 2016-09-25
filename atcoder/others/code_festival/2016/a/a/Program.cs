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
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                if (i == 3) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
