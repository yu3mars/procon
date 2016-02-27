using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool ng = false;
            bool nowc = false;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (nowc == true)
                {
                    if (c == 'h')
                    {
                        nowc = false;
                    }
                    else
                    {
                        ng = true;
                        break;
                    }
                }
                else if (c == 'c')
                {
                    nowc = true;
                }
                else if (c == 'o' || c == 'k' || c == 'u')
                {
                }
                else
                {
                    ng = true;
                    break;
                }
            }
            if (ng == true)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
