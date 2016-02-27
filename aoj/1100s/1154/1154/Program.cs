using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1154
{
    class Program
    {
        public static List<int> primels;
        static void Main(string[] args)
        {
            primels = new List<int>();
            for (int i = 7; i < 300010; i += 7)
            {
                addPrime(i - 1);
                addPrime(i + 1);
            }

            for (; ; )
            {
                int tar = int.Parse(Console.ReadLine());
                if (tar == 1) return;
                //ansls.Clear();
                Console.Write("{0}:", tar);
                for (int i = 0; i < primels.Count; i++)
                {
                    if (tar % primels[i] == 0)
                    {
                        Console.Write(" {0}", primels[i]);
                    }
                }
                Console.WriteLine();
            }
        }

        static void addPrime(int num)
        {
            bool isprime = true;
            for (int i = 0; i < primels.Count; i++)
            {
                if (primels[i] > Math.Sqrt(num))
                {
                    break;
                }
                if (num % primels[i] == 0)
                {
                    isprime = false;
                }
            }
            if (isprime == true)
            {
                primels.Add(num);
            }            
        }

    }
}
