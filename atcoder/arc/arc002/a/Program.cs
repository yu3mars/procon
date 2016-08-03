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
            if (isUruu(n)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }

        static bool isUruu(int n)
        {
            if (n % 400 == 0) return true;
            else if (n % 100 == 0) return false;
            else if (n % 4 == 0) return true;
            return false;
        }
    }
}
