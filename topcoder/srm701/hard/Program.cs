using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThueMorseGame.get(30, 3));
            Console.WriteLine(ThueMorseGame.get(499999975, 49));

        }
    }
}

class ThueMorseGame
{
    public static string get(int n, int m)
    {
        bool[] win = new bool[n + 1];
        for (int j = 1; j <= n; j++)
        {
            for (int i = 1; i <= m; i++)
            {
                win[j] |= i <= j && !win[j - i];
            }
        }

        if (win[n]) return "Alice";
        else return "Bob";
    }
}