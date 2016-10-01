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
            string x = Console.ReadLine();
            int s = 0;
            int t = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if(x[i]=='S')
                {
                    s++;
                }
                else //T
                {
                    if (s > 0) s--;
                    else t++;
                }
            }
            Console.WriteLine(s+t);
        }
    }
}
