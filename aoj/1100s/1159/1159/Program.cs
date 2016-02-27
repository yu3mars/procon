using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] np = Console.ReadLine().Split(' ');
                int n = int.Parse(np[0]);
                int p = int.Parse(np[1]);
                if (n == 0 && p == 0)
                {
                    return;
                }
                int[] people = new int[n];
                int wan = p;
                int turn = 0;
                for (; ; )
                {
                    int player = turn % n;
                    if (wan > 0)
                    {
                        wan -= 1;
                        people[player] += 1;
                        if (people[player] == p)
                        {
                            Console.WriteLine(player);
                            break;
                        }
                    }
                    else
                    {
                        wan = people[player];
                        people[player] = 0;
                    }                    
                    turn += 1;
                }
            }
        }
    }
}
