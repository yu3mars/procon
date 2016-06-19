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
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(2*(a[0]*a[1]+a[1]*a[2]+a[2]*a[0]));
        }
    }
}
