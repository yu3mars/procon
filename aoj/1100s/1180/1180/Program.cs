using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1180
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int l = int.Parse(str[1]);
                if (str[0] =="0" && str[1] == "0")
                {
                    return;
                }
                string target = str[0];
                int cnt = 0;
                bool found = false;
                Dictionary<string,int> dic = new Dictionary<string,int>();
                while (found == false)
                {
                    dic.Add(target, cnt);
                    cnt += 1;
                    int[] ls = new int[10];
                    foreach (char s in target)
                    {
                        ls[int.Parse(s.ToString())] += 1;
                    }
                    string large = "";
                    string small = "";
                    for (int i = 9; i > 0; i--)
                    {
                        for (int j = 0; j < ls[i]; j++)
                        {
                            large += i.ToString();
                        }
                    }
                    while (large.Length < l)
                    {
                        large += "0";
                    }
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 0; j < ls[i]; j++)
                        {
                            small += i.ToString();
                        }
                    }
                    if (small == "")
                    {
                        small = "0";
                    }
                    int lint = int.Parse(large);
                    int sint = int.Parse(small);
                    int next = lint - sint;
                    target = next.ToString();
                    if (dic.ContainsKey(target))
                    {
                        Console.WriteLine("{0} {1} {2}", dic[target], target, cnt - dic[target]);
                        found = true;
                    }
                }
            }
        }
    }
}
