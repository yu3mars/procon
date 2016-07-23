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
            string s = Console.ReadLine();
            string bef = "ODIZSB";
            string aft = "001258";
            for (int i = 0; i < bef.Length; i++)
            {
                s = s.Replace(bef[i], aft[i]);
            }
            Console.WriteLine(s);
        }
    }
}
