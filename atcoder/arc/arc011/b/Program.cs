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
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().ToLower().Split(' ');
            List<string> ans = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < s[i].Length; j++)
                {
                    switch (s[i][j])
                    {
                        case 'b':
                        case 'c':
                            sb.Append("1");
                            break;
                        case 'd':
                        case 'w':
                            sb.Append("2");
                            break;
                        case 't':
                        case 'j':
                            sb.Append("3");
                            break;
                        case 'f':
                        case 'q':
                            sb.Append("4");
                            break;
                        case 'l':
                        case 'v':
                            sb.Append("5");
                            break;
                        case 's':
                        case 'x':
                            sb.Append("6");
                            break;
                        case 'p':
                        case 'm':
                            sb.Append("7");
                            break;
                        case 'h':
                        case 'k':
                            sb.Append("8");
                            break;
                        case 'n':
                        case 'g':
                            sb.Append("9");
                            break;
                        case 'z':
                        case 'r':
                            sb.Append("0");
                            break;
                        default:
                            break;
                    }
                }
                string sbb = sb.ToString();
                if (sbb.Length > 0)
                {
                    ans.Add(sbb);
                }
            }
            Console.WriteLine(String.Join(" ", ans));
        }
    }
}
