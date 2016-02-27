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
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0) Console.Write(" ");
                if (s[i] == "Left")
                {
                    Console.Write("<");
                }
                else if (s[i] == "Right")
                {
                    Console.Write(">");
                }
                else
                {
                    Console.Write("A");
                }
            }
            Console.WriteLine();
        }
    }
}
