using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0510
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, sumb = 0;
            string[] stra = Console.ReadLine().Split(' ');
            string[] strb = Console.ReadLine().Split(' ');
            for (int i = 0; i < 4; i++)
            {
                suma += int.Parse(stra[i]);
                sumb += int.Parse(strb[i]);
            }
            if (suma > sumb)
            {
                Console.WriteLine(suma);
            }
            else
            {
                Console.WriteLine(sumb);
            }
        }
    }
}
