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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = "";
                int asta = Math.Abs(n / 2 - i);
                int d = n - 2 * asta;
                for (int j = 0; j < asta; j++)
                {
                    str += "*";
                }
                for (int j = 0; j < d; j++)
                {
                    str += "D";
                }
                for (int j = 0; j < asta; j++)
                {
                    str += "*";
                }
                Console.WriteLine(str);
            }
        }
    }
}
