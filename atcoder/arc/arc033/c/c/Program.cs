using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            List<int> ls = new List<int>();
            
            
            for (int i = 0; i < q; i++)
            {
                string[] tx = Console.ReadLine().Split(' ');
                int num = int.Parse(tx[1]);
                if (tx[0] == "1")
                {
                    ls.Add(num);
                }
                else
                {
                    ls.Sort();
                    int rm = ls[num - 1];
                    Console.WriteLine(rm);
                    ls.Remove(rm);
                }

            }
        }
    }
}
