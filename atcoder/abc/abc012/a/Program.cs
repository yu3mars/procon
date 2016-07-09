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
            int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Reverse(ab);
            Console.WriteLine(String.Join(" ",ab));
        }
    }
}
