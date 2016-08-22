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
            string st = Console.ReadLine();
            bool n = false;
            bool w = false;
            bool s = false;
            bool e = false;
            for (int i = 0; i < st.Length; i++)
            {
                switch (st[i])
                {
                    case 'N':
                        n = true;
                        break;
                    case 'W':
                        w = true;
                        break;
                    case 'S':
                        s = true;
                        break;
                    case 'E':
                        e = true;
                        break;
                    default:
                        break;
                }
            }
            if (n == s && e == w) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}
