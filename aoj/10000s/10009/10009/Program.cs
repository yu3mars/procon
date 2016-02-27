using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10009
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, menseki, nagasa;
            r = double.Parse(Console.ReadLine());
            menseki = Math.Pow(r, 2) * Math.PI;
            nagasa = 2 * r * Math.PI;
            Console.WriteLine("{0} {1}",menseki,nagasa);
        }
    }
}
