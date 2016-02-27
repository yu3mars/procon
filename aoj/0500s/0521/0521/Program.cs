using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0521
{
    class Program
    {
        static void Main(string[] args)
        {
            int daikin, otsuri,coin;
            for (; ; )
            {
                daikin = int.Parse(Console.ReadLine());
                if (daikin == 0)
                {
                    return;
                }
                else
                {
                    coin = 0;
                    otsuri = 1000 - daikin;
                    coin += (otsuri / 500);
                    otsuri = otsuri % 500;
                    coin += (otsuri / 100);
                    otsuri = otsuri % 100;
                    coin += (otsuri / 50);
                    otsuri = otsuri % 50;
                    coin += (otsuri / 10);
                    otsuri = otsuri % 10;
                    coin += (otsuri / 5);
                    otsuri = otsuri % 5;
                    coin += (otsuri / 1);
                    Console.WriteLine(coin);
                }
            }
        }
    }
}
