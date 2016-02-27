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
            string[] str = Console.ReadLine().Split(' ');
            long people = long.Parse(str[0]);
            long team = long.Parse(str[1]);
            long membersformin = people / team;
            long plus1team = people % team;
            long min = (team - plus1team) * Nc2(membersformin)
                + plus1team * Nc2(membersformin + 1);
            long max = Nc2(people - team + 1);
            Console.WriteLine("{0} {1}", min, max);
        }

        static long Nc2(long n)
        {
            return n*(n-1)/2;
        }
    }
}
