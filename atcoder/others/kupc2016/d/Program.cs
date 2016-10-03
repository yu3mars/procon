using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    class Program
    {
        static string[][] c = new string[2][];
        static void Main(string[] args)
        {
            c[0] = new string[] { "#", "#", ".", "." };
            c[1] = new string[] { "#", ".", "#", "." };
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[2];
            for (int i = 0; i < 2; i++)
            {
                s[i] = "";
            }
            bool afterMode = true;
            while (s[0].Length < n)
            {
                if (afterMode)//ato ni ireru
                {
                    afterMode = false;
                    for (int ccnt = 0; ccnt < 4; ccnt++)
                    {
                        for (int scnt = 0; scnt < 2; scnt++)
                        {
                            Console.WriteLine("{0}{1}", s[scnt], c[scnt][ccnt]);
                        }
                        string r = Console.ReadLine();
                        if (r == "T")
                        {
                            for (int scnt = 0; scnt < 2; scnt++)
                            {
                                s[scnt] = s[scnt] + c[scnt][ccnt];
                            }
                            afterMode = true;
                            break;
                        }
                        else if (r == "end") return;
                    }
                }
                else//mae ni ireru
                {
                    for (int ccnt = 0; ccnt < 4; ccnt++)
                    {
                        for (int scnt = 0; scnt < 2; scnt++)
                        {
                            Console.WriteLine("{0}{1}", c[scnt][ccnt], s[scnt]);
                        }
                        string r = Console.ReadLine();
                        if (r == "T")
                        {
                            for (int scnt = 0; scnt < 2; scnt++)
                            {
                                s[scnt] = c[scnt][ccnt] + s[scnt];
                            }
                            break;
                        }
                        else if (r == "end") return;
                    }
                }
            }
        }
    }
}
