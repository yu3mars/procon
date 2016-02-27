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
            string[] str = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += int.Parse(str[i]);
            }
            if (sum % 5 == 0 && sum / 5 > 0)
            {
                Console.WriteLine(sum / 5);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
