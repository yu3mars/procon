using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2583
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;

                char[][] s = new char[n][];
                for (int i = 0; i < n; i++)
                {
                    s[i] = Console.ReadLine().ToCharArray();
                }
                for (int word = 0; word < n; word++)
                {
                    for (int chr = 0; chr < s[word].Length - 1; chr++)
                    {
                        if (s[word][chr] != '.') break;
                        else
                        {
                            if(s[word][chr + 1] == '.')
                            {
                                s[word][chr] = ' ';
                            }
                            else
                            {
                                s[word][chr] = '+';
                                for (int wword = word - 1; wword >= 0; wword--)
                                {
                                    if (s[wword][chr] == ' ')
                                    {
                                        s[wword][chr] = '|';
                                    }
                                    else break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}
