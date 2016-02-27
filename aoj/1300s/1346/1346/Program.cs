using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1346
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = Console.ReadLine();
            int ans = int.Parse(Console.ReadLine());
            int sum = 0;
            int now = int.Parse(f[0].ToString());
            for (int i = 1; i < f.Length; i+=2)
            {
                if (f[i] == '+')
                {
                    sum += now;
                    now = int.Parse(f[i + 1].ToString());
                }
                else if (f[i] == '*')
                {
                    now *= int.Parse(f[i + 1].ToString());
                }
            }
            sum += now;
            int m = sum;

            sum = int.Parse(f[0].ToString());
            for (int i = 1; i < f.Length; i += 2)
            {
                if (f[i] == '+')
                {
                    sum += int.Parse(f[i + 1].ToString());
                }
                else if (f[i] == '*')
                {
                    sum *= int.Parse(f[i + 1].ToString());
                }
            }
            int l = sum;

            if (m == ans)
            {
                if (l == ans) Console.WriteLine("U");
                else Console.WriteLine("M");
            }
            else
            {
                if (l == ans) Console.WriteLine("L");
                else Console.WriteLine("I");
            }
        }
    }
}
