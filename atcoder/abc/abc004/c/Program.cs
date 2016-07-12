using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static int[] ls;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) % 30;
            ls = new int[6];
            for (int i = 0; i < 6; i++)
            {
                ls[i] = i + 1;
            }
            for (int i = 0; i < n; i++)
            {
                Swap(i);
                    
            }
            Console.WriteLine(String.Join("", ls));
        }
        
        static void Swap(int n)
        {
            n %= 5;
            int tmp = ls[n];
            ls[n] = ls[n + 1];
            ls[n + 1] = tmp;
        }
    }
}
