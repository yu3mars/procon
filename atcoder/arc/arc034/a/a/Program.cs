using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double[] score = new double[5];
                string[] str = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    score[j] = double.Parse(str[j]);
                }
                double scr = 0;
                for (int j = 0; j < 4; j++)
                {
                    scr += score[j];
                }
                scr += score[4] * 11 / 90;
                max = Math.Max(max, scr);
            }
            Console.WriteLine(max);
        }
    }
}
