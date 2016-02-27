using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0033
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            for (int z = 0; z < cnt; z++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int small = 0;
                int large = 0;
                int target;
                bool yn = true;
                for (int i = 0; i < 10; i++)
                {
                    target = int.Parse(str[i]);
                    if (target > large)
                    {
                        large = target;
                    }
                    else if (target > small)
                    {
                        small = target;
                    }
                    else
                    {
                        yn = false;
                        Console.WriteLine("NO");
                        break;
                    }                    
                }
                if (yn == true)
                {
                    Console.WriteLine("YES");
                }
            }            
        }
    }
}
