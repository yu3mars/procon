using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] astr = Console.ReadLine().Split(' ');
            int[] ain = new int[n];
            string bstr = "";
            for (int i = 0; i < n; i++)
            {
                ain[i] = int.Parse(astr[i]);
                if (ain[i] == 1)
                {
                    bstr += "1";
                }
                else
                {
                    bstr += (ain[i] - 1).ToString();
                }
                if (i != n - 1)
                {
                    bstr += " ";
                }
            }
            Console.WriteLine(bstr);
        }
    }
}
