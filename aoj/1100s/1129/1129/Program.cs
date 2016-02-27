using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1129
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nr = Console.ReadLine().Split(' ');
                int n = int.Parse(nr[0]);
                int r = int.Parse(nr[1]);
                if (n == 0 && r == 0)
                {
                    return;
                }
                int[] card = new int[n];
                for (int i = 0; i < n; i++)
                {
                    card[i] = n - i;
                }
                for (int k = 0; k < r; k++)
                {
                    string[] pc = Console.ReadLine().Split(' ');
                    int p = int.Parse(pc[0]);
                    int c = int.Parse(pc[1]);
                    int[] ue = new int[p - 1];
                    int[] shita = new int[c];
                    for (int i = 0; i < p - 1; i++)
                    {
                        ue[i] = card[i];
                    }
                    for (int i = 0;i < c; i++)
                    {
                        shita[i] = card[p - 1 + i];
                    }
                    for (int i = 0; i < c; i++)
                    {
                        card[i] = shita[i];
                    }
                    for (int i = 0; i < p - 1; i++)
                    {
                        card[i + c] = ue[i];
                    }
                }
                
                Console.WriteLine(card[0]);
            }
        }
    }
}
