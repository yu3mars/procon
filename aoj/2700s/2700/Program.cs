using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2700
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;
                string[] s = new string[n];
                string[] code = new string[n];

                for (int i = 0; i < n; i++)
                {
                    s[i] = Console.ReadLine();
                    StringBuilder sb = new StringBuilder();
                    sb.Append(s[i][0]);
                    for (int j = 0; j < s[i].Length - 1; j++)
                    {
                        if(s[i][j] == 'a' || s[i][j] == 'i' || s[i][j] == 'u' || s[i][j] == 'e' || s[i][j] == 'o')
                        {
                            sb.Append(s[i][j + 1]);
                        }
                    }
                    code[i] = sb.ToString();
                }
                bool ok = false;
                for (int k = 1; k < 51; k++)
                {
                    HashSet<string> set = new HashSet<string>();
                    for (int i = 0; i < n; i++)
                    {
                        if (code[i].Length < k)
                        {
                            set.Add(code[i]);
                        }
                        else
                        {
                            set.Add(code[i].Substring(0, k));
                        }
                    }
                    if(set.Count == n)
                    {
                        Console.WriteLine(k);
                        ok = true;
                        break;
                    }
                }
                if(ok==false)
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
