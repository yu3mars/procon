using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int strlen = str.Length;
            int target = (num - 1) % strlen;
            Console.WriteLine(str[target]);
        }
    }
}
