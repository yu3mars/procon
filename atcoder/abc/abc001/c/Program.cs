using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dirls = new string[]
            {"N","NNE","NE","ENE","E","ESE","SE","SSE","S","SSW","SW","WSW","W","WNW","NW","NNW"};

            int[] wls = new int[]
                {25,155,335,545,795,1075,1385,1715,2075,2445,2845,3265};
            for (int i = 0; i < wls.Length; i++)
            {
                wls[i] *= 6;
            }

            int[] dd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            dd[0] = (dd[0] * 10 + 1125) / 2250 % dirls.Length;
            dd[1] *= 10;

            if(dd[1]<wls[0])
            {
                Console.WriteLine("C 0");
                return;
            }

            for (int i = 0; i < wls.Length; i++)
            {
                if (dd[1] < wls[i])
                {
                    Console.WriteLine("{0} {1}", dirls[dd[0]], i);
                    return;
                }
            }
            Console.WriteLine("{0} {1}", dirls[dd[0]], wls.Length);

        }
    }
}
