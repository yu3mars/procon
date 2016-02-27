using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace copypaste
{
    class Program
    {
        static int m;
        static string s;
        static void Main(string[] args)
        {
            m = int.Parse(Console.ReadLine());
            s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] abc = Console.ReadLine().Split(' ');
                int a = int.Parse(abc[0]);
                int b = int.Parse(abc[1]);
                int c = int.Parse(abc[2]);
                Copy(a, b, c);
            }
            Console.WriteLine(s);
        }

        static void Copy(int a, int b, int c)
        {
            string buff = s.Substring(a, b - a);
            string mae = s.Substring(0, c);
            string ato = s.Substring(c);
            s = mae + buff + ato;
            if (s.Length > m)
            {
                s = s.Substring(0, m);
            }
        }
    }
}
