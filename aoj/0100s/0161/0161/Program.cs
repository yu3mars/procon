using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0161
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (; ; )
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    return;
                }
                else
                {
                    int n1time = 10000000,n2time = 10000001, w1time = 0, w2time = 0,tmptime;
                    string n1team = "",n2team = "", w1team = "", w2team = "";
                    for (int i = 0; i < num; i++)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        tmptime =
                            (int.Parse(str[1]) + int.Parse(str[3]) + int.Parse(str[5]) + int.Parse(str[7])) * 60
                            + (int.Parse(str[2]) + int.Parse(str[4]) + int.Parse(str[6]) + int.Parse(str[8]));
                        if (tmptime < n1time)
                        {
                            n2time = n1time;
                            n2team = n1team;
                            n1time = tmptime;
                            n1team = str[0];
                        }
                        else if (tmptime < n2time)
                        {
                            n2time = tmptime;
                            n2team = str[0];
                        }
                        if (tmptime > w1time)
                        {
                            w2time = w1time;
                            w2team = w1team;
                            w1time = tmptime;
                            w1team = str[0];
                        }
                        else if (tmptime > w2time)
                        {
                            w2time = tmptime;
                            w2team = str[0];
                        }
                    }
                    Console.WriteLine(n1team);
                    Console.WriteLine(n2team);
                    Console.WriteLine(w2team);
                }
            }
        }
    }
}
