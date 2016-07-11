using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            bool[] ls = new bool[10];
            for (int i = 0; i < s.Length; i++)
            {
                ls[s[i] - '0'] = true;
            }
            bool[] yoko = new bool[3];
            bool[] tate = new bool[4];
            
            if(ls[0])
            {
                yoko[1] = true;
                tate[3] = true;
            }

            for (int i = 1; i < 10; i++)
            {
                if(ls[i])
                {
                    yoko[(i - 1) % 3] = true;
                    tate[(i - 1) / 3] = true;
                }
            }
            if (tate[3])//0
            {
                if (tate[0])
                {
                    Console.WriteLine("YES");
                    return;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            if((tate[0]&&tate[2]) && yoko[0]&&yoko[2])
            {
                if (ls[7] || ls[9])
                {
                    Console.WriteLine("YES");
                    return;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }

        }
    }
}
