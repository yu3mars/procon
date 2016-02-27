using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        const long mod = 1000000007;
        static void Main(string[] args)
        {
            string[] ab = Console.ReadLine().Split(' ');
            Mod a = new Mod(long.Parse(ab[0]));
            Mod b = new Mod(long.Parse(ab[1]));
            long bas = b.num / a.num;
            long amari = b.num - a.num * bas;
            Mod ans = new Mod(1);
            for (uint i = 0; i < amari; i++)
            {
                ans = new Mod(ans.num * (a.num - i) / (i + 1));
            }
            Console.WriteLine(ans.num);
        }

        public struct Mod
        {
            public long num;
            
            public Mod(long n)
            {
                num = n;
            }
        }

        static public Mod operator +(Mod a, Mod b) { return new Mod((a.num + b.num) % mod); }
        static public Mod operator -(Mod a, Mod b) { return new Mod((mod + a.num - b.num) % mod); }
        static public Mod operator *(Mod a, Mod b) { return new Mod((a.num * b.num) % mod); }
        //static public Mod operator+=(Mod a, Mod b) { return a = a + b; }
        //static public Mod operator-=(Mod a, Mod b) { return a = a - b; }
        static public Mod operator ^(Mod a, int n)
        {
            if (n == 0) return new Mod(1);
            Mod res = new Mod((a.num * a.num) ^ (n / 2));
            if (n % 2 == 1) res = new Mod(res.num * a.num);
            return res;
        }
        static public Mod inv(Mod a) { return new Mod(a.num ^ (mod - 2)); }
        static public Mod operator /(Mod a, Mod b) { return new Mod(a.num * inv(b).num); }
    }
}
