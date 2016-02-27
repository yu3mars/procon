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
            string[] str = Console.ReadLine().Split(' ');
            int max = Math.Max(int.Parse(str[0]),int.Parse(str[1]));
            Console.WriteLine(max);
        }
    }
}
