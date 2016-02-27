using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int ans = 0;
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length-4; j++)
                {
                    if (s[j] == 't')
                    {
                        if (s.Substring(j, 5) == "tokyo")
                        {
                            ans++;
                            j += 4;
                        }
                    } 
                    else if (s[j] == 'k')
                    {
                        if (s.Substring(j, 5) == "kyoto")
                        {
                            ans++;
                            j += 4;
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
