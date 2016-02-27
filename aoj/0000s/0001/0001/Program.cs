using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1 = 0, no2 = 0, no3 = 0, target;
            for (int i = 0; i < 10; i++)
            {
                target = int.Parse(Console.ReadLine());
                if (target >= no1)
                {
                    no3 = no2;
                    no2 = no1;
                    no1 = target;
                }
                else if (target >= no2)
                {
                    no3 = no2;
                    no2 = target;
                }
                else if (target >= no3)
                {
                    no3 = target;
                }
            }
            Console.WriteLine(no1);
            Console.WriteLine(no2);
            Console.WriteLine(no3);            
        }
    }
}
