using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2175
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string suitstr = Console.ReadLine();
                if (suitstr == "#") return;
                char suit = suitstr[0];
                string[][] card = new string[4][];
                for (int i = 0; i < 4; i++)
                {
                    card[i] = Console.ReadLine().Split(' ');
                }
                int ns = 0;
                int ew = 0;
                int winner = 0;
                int befwinner = 0;
                for (int j = 0; j < 13; j++)
                {
                    int[] score = new int[4];
                    int max = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (card[i][j][0] == 'T') score[i] = 10;
                        else if (card[i][j][0] == 'J') score[i] = 11;
                        else if (card[i][j][0] == 'Q') score[i] = 12;
                        else if (card[i][j][0] == 'K') score[i] = 13;
                        else if (card[i][j][0] == 'A') score[i] = 14;
                        else score[i] = card[i][j][0] - '0';

                        if (card[i][j][1] == suit) score[i] += 1000;
                        else if (card[i][j][1] == card[befwinner][j][1]) score[i] += 100;
                        if (score[i] >= max)
                        {
                            max = score[i];
                            winner = i;
                        }
                    }
                    if (winner % 2 == 0) ns++;
                    else ew++;
                    befwinner = winner;
                }

                if (ns >= ew)
                {
                    Console.WriteLine("NS {0}", ns - 6);
                }
                else
                {
                    Console.WriteLine("EW {0}", ew - 6); 
                }
            }

        }
    }
}
