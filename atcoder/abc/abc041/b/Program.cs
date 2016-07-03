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
            long[] abc = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long mod = 1000000007;
            Console.WriteLine(abc[0]* abc[1] % mod * abc[2] % mod );
        }
    }
}
