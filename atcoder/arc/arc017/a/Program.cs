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
            int n = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i * i <= n; i++)
            {
                if(n%i==0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
