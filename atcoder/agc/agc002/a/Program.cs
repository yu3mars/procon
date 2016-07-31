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
            int a = ab[0];
            int b = ab[1];
            if(a>0)
            {
                Console.WriteLine("Positive");
            }
            else if (a<=0 && b>=0)
            {
                Console.WriteLine("Zero");
            }
            else if( (b-a)%2==1)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
