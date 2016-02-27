using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1325
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] ls = new bool[20010];
            for (int i = 0; i < 142; i++)
            {
                for (int j = i; j < 142; j++)
                {
                    int tmp = i * i + j * j;
                    if (tmp >= 20000) break;
                    ls[tmp] = true;
                }
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] ab = Console.ReadLine().Split(' ');
                int a = Math.Abs(int.Parse(ab[0]));
                int b = Math.Abs(int.Parse(ab[1]));
                if (a > b)
                {
                    int tmp = a;
                    a = b;
                    b = tmp;
                }
                int target = a * a + b * b;
                bool noprime = false;
                for (int x = 0; x <= Math.Sqrt(target); x++)
                {
                    for (int y = x; y <= Math.Sqrt(target); y++)
                    {
                        int test = x * x + y * y;
                        if (test > 0 && target % (test) == 0 && ls[test]
                            && (x == 0 && y == 1) == false
                            && (x == a && y == b) == false)
                        {
                            if (ls[target / test])
                            {
                                noprime = true;
                                break;
                            }
                        }
                    }
                    if (noprime) break;
                }
                if (noprime)
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("P");
                }
            }
        }
    }
}
