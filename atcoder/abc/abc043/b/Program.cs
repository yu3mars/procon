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
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '0':
                        sb.Append("0");
                        break;
                    case '1':
                        sb.Append("1");
                        break;
                    case 'B':
                        if (sb.Length > 0)
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
