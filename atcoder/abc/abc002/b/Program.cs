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
            string w = Console.ReadLine();
            string a = "aiueo";
            foreach (char c in a)
            {
                w = w.Replace(c.ToString(),"");
            }
            Console.WriteLine(w);
        }
    }
}
