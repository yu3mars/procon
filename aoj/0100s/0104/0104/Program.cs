using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0104
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] hw = Console.ReadLine().Split(' ');
                int h = int.Parse(hw[0]);
                int w = int.Parse(hw[1]);
                if (h == 0 && w == 0)
                {
                    return;
                }
                string[] map = new string[h];
                for (int i = 0; i < h; i++)
                {
                    map[i] = Console.ReadLine();
                }
                bool[,] check = new bool[h, w];
                int nowh = 0;                
                int noww = 0;    
                for(;;)
                {
                    if (check[nowh, noww] == true)
                    {
                        Console.WriteLine("LOOP");
                        break;
                    }
                    check[nowh, noww] = true;
                    string dir = map[nowh][noww].ToString();
                    if (dir == ">")
                    {
                        noww += 1;
                    }
                    else if (dir == "<")
                    {
                        noww -= 1;
                    }
                    else if (dir == "^")
                    {
                        nowh -= 1;
                    }
                    else if (dir == "v")
                    {
                        nowh += 1;
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", noww, nowh);
                        break;
                    }
                }
            }
        }
    }
}
