using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1137
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int ncount = 0; ncount < n; ncount++)
            {
                string[] str = Console.ReadLine().Split(' ');
                char[][] mcxi = new char[2][];
                int ansdigit = 0;
                int nextdigit = 1;
                string ansmcxi = "";
                for (int i = 0; i < 2; i++)
                {
                    mcxi[i] = str[i].ToCharArray();
                    for (int j = 0; j < mcxi[i].Length; j++)
                    {
                        if (mcxi[i][j].ToString() == "m")
                        {
                            ansdigit += nextdigit * 1000;
                            nextdigit = 1;
                        }
                        else if (mcxi[i][j].ToString() == "c")
                        {
                            ansdigit += nextdigit * 100;
                            nextdigit = 1;
                        }
                        else if (mcxi[i][j].ToString() == "x")
                        {
                            ansdigit += nextdigit * 10;
                            nextdigit = 1;
                        }
                        else if (mcxi[i][j].ToString() == "i")
                        {
                            ansdigit += nextdigit;
                            nextdigit = 1;
                        }
                        else
                        {
                            nextdigit = int.Parse(mcxi[i][j].ToString());
                        }
                    }
                }

                int[] div = new int[4] { 1000, 100, 10, 1 };
                string[] rome = new string[4] { "m", "c", "x", "i" };
                for (int i = 0; i < 4; i++)
                {
                    if (ansdigit / div[i] == 0)
                    {
                        continue;
                    }
                    else if (ansdigit / div[i] == 1)
                    {
                        ansmcxi += rome[i];
                    }
                    else
                    {
                        ansmcxi += (ansdigit / div[i]).ToString() + rome[i];
                    }
                    ansdigit -= (ansdigit / div[i]) * div[i];
                }
                Console.WriteLine(ansmcxi);
            }
        }
    }
}
