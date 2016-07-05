using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int t = int.Parse(Console.ReadLine());

            int lr = 0;
            int ud = 0;
            int que = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'L':
                        lr++;
                        break;
                    case 'R':
                        lr--;
                        break;
                    case 'U':
                        ud++;
                        break;
                    case 'D':
                        ud--;
                        break;
                    case '?':
                        que++;
                        break;
                    default:
                        break;
                }
            }
            int abs = Math.Abs(lr) + Math.Abs(ud);
            if(t==1)
            {
                Console.WriteLine(abs + que);
            }
            else
            {
                if(abs>=que)
                {
                    Console.WriteLine(abs-que);
                }
                else
                {
                    Console.WriteLine((que - abs) % 2);
                }
            }


        }
    }
}
