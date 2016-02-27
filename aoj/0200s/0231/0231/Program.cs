using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0231
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
                SortedList<int, int> bridge = new SortedList<int, int>();
                int walking = 0;
                for (int i = 0; i < n; i++)
                {
                    string[] bstr = Console.ReadLine().Split(' ');
                    int[] str = new int[3];
                    for (int j = 0; j < 3; j++)
                    {
                        str[j] = int.Parse(bstr[j]);
                    }
                    if (bridge.ContainsKey(str[1]) == true)
                    {
                        bridge[str[1]] += str[0];
                    }
                    else
                    {
                        bridge.Add(str[1], str[0]);
                    }
                    if (bridge.ContainsKey(str[2]) == true)
                    {
                        bridge[str[2]] -= str[0];
                    }
                    else
                    {
                        bridge.Add(str[2], -str[0]);
                    }
                }
                bool overweight = false;
                for (int i = 0; i < bridge.Count(); i++)
                {
                    walking += bridge.Values[i];
                    if (walking > 150)
                    {
                        overweight = true;
                    }
                }
                if (overweight == true)
                {
                    Console.WriteLine("NG");
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
        }
    }
}
