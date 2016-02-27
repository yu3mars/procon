using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _1136
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;
                Line ori = new Line();
                Line orirev = DeepCopyHelper.DeepCopy<Line>(ori);

                int mrev = 4 - ori.turn[ori.m - 2];
                for (int i = 0; i < ori.m - 1; i++)
                {
                    orirev.len[i] = ori.len[ori.m - 2 - i];
                    orirev.turn[i] = (mrev + ori.turn[ori.m - 2 - i]) % 4;
                }
                for (int i = 1; i <= n; i++)
                {
                    Line l = new Line();
                    if ((ori.len.SequenceEqual(l.len) &&
                        ori.turn.SequenceEqual(l.turn)) ||
                        (orirev.len.SequenceEqual(l.len) &&
                        orirev.turn.SequenceEqual(l.turn))
                        )
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("+++++");
            }
        }
    }

    [Serializable]
    class Line
    {
        public int m;
        public int[] x;
        public int[] y;
        public int[] len;
        public int[] turn;

        public Line()
        {
            m = int.Parse(Console.ReadLine());
            x = new int[m];
            y = new int[m];
            len = new int[m - 1];
            turn = new int[m - 1];
            for (int i = 0; i < m; i++)
            {
                string[] xy = Console.ReadLine().Split(' ');
                x[i] = int.Parse(xy[0]);
                y[i] = int.Parse(xy[1]);
            }
            for (int i = 0; i < m - 1; i++)
            {
                if (x[i] != x[i + 1])
                {
                    len[i] = Math.Abs(x[i] - x[i + 1]);
                    if (x[i] < x[i + 1])
                    {
                        turn[i] = 0;
                    }
                    else
                    {
                        turn[i] = 2;
                    }
                }
                else
                {
                    len[i] = Math.Abs(y[i] - y[i + 1]);
                    if (y[i] < y[i + 1])
                    {
                        turn[i] = 1;
                    }
                    else
                    {
                        turn[i] = 3;
                    }
                }
            }

            int turnbgn = 4 - turn[0];
            for (int i = 0; i < m - 1; i++)
            {
                turn[i] = (turnbgn + turn[i]) % 4;
            }
        }

    }


    public static class DeepCopyHelper
    {
        public static T DeepCopy<T>(T target)
        {

            T result;
            BinaryFormatter b = new BinaryFormatter();

            MemoryStream mem = new MemoryStream();

            try
            {
                b.Serialize(mem, target);
                mem.Position = 0;
                result = (T)b.Deserialize(mem);
            }
            finally
            {
                mem.Close();
            }

            return result;

        }
    }
}
