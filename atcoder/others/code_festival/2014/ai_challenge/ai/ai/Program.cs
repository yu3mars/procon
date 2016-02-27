using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("READY");
            string[] str1 = Console.ReadLine().Split(' ');
            int t = int.Parse(str1[0]);
            int p = int.Parse(str1[1]);
            int n = int.Parse(str1[2]);
            string[] str2 = Console.ReadLine().Split(' ');
            int[] an = new int[str2.Length];
            for (int i = 0; i < str2.Length; i++)
            {
                an[i] = int.Parse(str2[i]);
            }
            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[1] == "W")
                {
                    Weekday(p,n);
                }
                else
                {
                    Holiday(p,n);
                }
            }
        }


        static void Weekday(int p, int n)
        {
            string[][] sinja = new string[n][];
            for (int i = 0; i < n; i++)
            {
                sinja[i] = Console.ReadLine().Split(' ');
            }
            string[] rlist = Console.ReadLine().Split(' ');
            string[] plist = Console.ReadLine().Split(' ');
            Console.WriteLine("0 1 2 3 3");
        }

        static void Holiday(int p, int n)
        {
            string[][] sinja = new string[n][];
            for (int i = 0; i < n; i++)
            {
                sinja[i] = Console.ReadLine().Split(' ');
            }
            string[] rlist = Console.ReadLine().Split(' ');
            Console.WriteLine("4 5");
        }
    }
}
