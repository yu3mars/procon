using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2252
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> q = new HashSet<string>();
            q.Add("q");
            q.Add("w");
            q.Add("e");
            q.Add("r");
            q.Add("t");
            q.Add("a");
            q.Add("s");
            q.Add("d");
            q.Add("f");
            q.Add("g");
            q.Add("z");
            q.Add("x");
            q.Add("c");
            q.Add("v");
            q.Add("b");
            
            for (; ; )
            {
                string str = Console.ReadLine();
                if (str == "#")
                {
                    return;
                }
                int cnt = 0;
                bool left = true;
                for (int i = 0; i < str.Length; i++)
                {
                    string next = str[i].ToString();
                    if (left == true)
                    {
                        if (q.Contains(next) == false)
                        {
                            left = false;
                            cnt += 1;
                        }
                    }
                    else
                    {
                        if (q.Contains(next) == true)
                        {
                            left = true;
                            cnt += 1;
                        }
                    }
                    if (i == 0)
                    {
                        cnt = 0;
                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
