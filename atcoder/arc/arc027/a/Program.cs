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
            int[] hm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(18 * 60 - hm[0] * 60 - hm[1]);
        }
    }
}
