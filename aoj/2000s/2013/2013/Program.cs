using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2013
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                SortedList<string,int> train = new SortedList<string,int>();
                int max = 0;
                int running = 0;
                for (int i = 0; i < n; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    if (train.ContainsKey(str[0]) == true)
                    {
                        train[str[0]] += 1;
                    }
                    else
                    {
                        train.Add(str[0] , 1);
                    }
                    if (train.ContainsKey(str[1]) == true)
                    {
                        train[str[1]] -= 1;
                    }
                    else
                    {
                        train.Add(str[1], -1);
                    }
                }
                for (int i = 0; i < train.Count(); i++)
                {
                    running += train.Values[i];
                    max = Math.Max(max, running);
                }
                Console.WriteLine(max);
            }
        }
    }
}
