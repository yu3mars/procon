using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2424
{
    class Program
    {
        static void Main(string[] args)
        {
            int qr = int.Parse(Console.ReadLine());
            for (int q = 0; q < qr; q++)
            {
                string num = Console.ReadLine();
                int cnt = 0;
                while (num.Length > 1)
                {
                    int max = int.MinValue;
                    for (int i = 1; i < num.Length; i++)
                    {
                        int mae = int.Parse(num.Substring(0, i));
                        int ato = int.Parse(num.Substring(i));
                        max = Math.Max(max, mae * ato);
                    }
                    num = max.ToString();
                    cnt += 1;
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
