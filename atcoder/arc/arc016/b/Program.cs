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
            int n = int.Parse(Console.ReadLine());
            string[] map = new string[n];
            for (int i = 0; i < n; i++)
            {
                map[i] = Console.ReadLine();
            }
            int ans = 0;
            bool[] nowmaru = new bool[9];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    switch (map[i][j])
                    {
                        case 'o':
                            if(nowmaru[j] ==false)
                            {
                                nowmaru[j] = true;
                                ans++;
                            }
                            break;
                        case 'x':
                            nowmaru[j] = false;
                            ans++;
                            break;
                        case '.':
                            nowmaru[j] = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
