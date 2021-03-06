﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
//using System.Numerics;  //comment out if AOJ
using System.Text;

using Problem = Tmp.Problem;
using MyIO;

#pragma warning disable   //for AOJ

namespace Tmp
{
    class Problem : IDisposable
    {
        bool IsGCJ;
        int Repeat;
        Scanner sc;
        Printer pr;
        public Problem(bool isGCJ, Scanner scanner, Printer printer)
        {
            sc = scanner;
            pr = printer;
            IsGCJ = isGCJ;
            if (isGCJ) Repeat = sc.nextInt();
            else Read();
        }
        public Problem(bool isGCJ) : this(isGCJ, new Scanner(), new Printer()) { }
        public Problem(bool isGCJ, Scanner scanner) : this(isGCJ, scanner, new Printer()) { }
        public Problem(bool isGCJ, Printer printer) : this(isGCJ, new Scanner(), printer) { }
        public void Solve()
        {
            if (IsGCJ) for (var i = 0; i < Repeat; i++) { Read(); pr.Write("Case #" + (i + 1) + ": "); SolveOne(); }
            else SolveOne();
        }
        public void Dispose()
        {
            sc.Dispose();
            pr.Dispose();
        }
        public int Size { get { return 1; } }
        public const long Mod = 1000000007;

        // 使用する変数をここに書く
        // string S;
        // int a;
        /// <summary>
        /// 読み込み処理をここに書く
        /// </summary>
        void Read()
        {

        }
        /// <summary>
        /// メイン処理をここに書く
        /// </summary>
        void SolveOne()
        {
            int n =sc.nextInt();
            int m =sc.nextInt();
            int k =sc.nextInt();

            Func.Mod ans = new Func.Mod(0);
            for (int i = 0; i <= k; i++)
            {
                
                int u = n + i;
                int d = i;
                int r = m + k - i;
                int l = k - i;
                Func.Mod ud = Func.comb(u + d, d);
                if (d > 0)
                {
                    ud -= Func.comb(u + d, d - 1);
                }
                Func.Mod rl = Func.comb(r + l, l);
                if (l > 0)
                {
                    rl -= Func.comb(r + l, l - 1);
                }                
                Func.Mod tmp = Func.comb(u + d + r + l, u + d) * ud * rl;
                ans += tmp;
            }
            Console.WriteLine(ans.n);
        }

    }
}
class Program
{
    //public static RandomSFMT rand = new RandomSFMT();
    public static bool IsJudgeMode = true;
    public static bool IsGCJMode = false;
    public static bool IsSolveCreated = true;
    static void Main()
    {
        if (IsJudgeMode)
            if (IsGCJMode) using (var problem = new Problem(true, new Scanner("C-large-practice.in.txt"), new Printer("output.txt"))) problem.Solve();
            else using (var problem = new Problem(false, new Printer())) problem.Solve();
        else
        {
            var num = 1;
            int size = 0;
            decimal time = 0;
            for (var tmp = 0; tmp < num; tmp++)
            {
                using (var P = IsSolveCreated ? new Problem(false, new Scanner("input.txt"), new Printer()) : new Problem(false))
                {
                    size = P.Size;
                    //time += Func.MeasureTime(() => P.Solve());
                }
            }
            Console.WriteLine("{0}, {1}ms", size, time / num);
        }
    }
}

/// <summary>
/// カスタマイズしたIO
/// </summary>
namespace MyIO
{
    class Printer : IDisposable
    {
        bool isConsole;
        TextWriter file;
        public Printer() { file = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false }; isConsole = true; }
        public Printer(string path) { file = new StreamWriter(path, false) { AutoFlush = false }; isConsole = false; }
        public void Write<T>(T value) { file.Write(value); }
        public void Write(bool b) { file.Write(b ? "YES" : "NO"); }
        public void Write(string str, params object[] args) { file.Write(str, args); }
        public void WriteLine() { file.WriteLine(); }
        public void WriteLine<T>(T value) { file.WriteLine(value); }
        public void WriteLine(bool b) { file.WriteLine(b ? "YES" : "NO"); }
        public void WriteLine<T>(IEnumerable<T> list) { foreach (var x in list) file.WriteLine(x); }
        public void WriteLine<T>(List<T> list) { foreach (var x in list) file.WriteLine(x); }
        public void WriteLine<T>(T[] list) { foreach (var x in list) file.WriteLine(x); }
        public void WriteLine(string str, params object[] args) { file.WriteLine(str, args); }
        public void Dispose() { file.Flush(); if (!isConsole) file.Dispose(); }
    }
    class Scanner : IDisposable
    {
        bool isConsole;
        TextReader file;
        public Scanner() { file = Console.In; }
        public Scanner(string path) { file = new StreamReader(path); isConsole = false; }
        public void Dispose() { if (!isConsole) file.Dispose(); }

        #region next読み込み
        string[] nextBuffer = new string[0];
        int BufferCnt = 0;

        char[] cs = new char[] { ' ' };

        public string next()
        {
            while (BufferCnt >= nextBuffer.Length)
            {
                string st = file.ReadLine();
                while (st == "") st = file.ReadLine();
                nextBuffer = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
                BufferCnt = 0;
            }
            return nextBuffer[BufferCnt++];
        }

        public int nextInt()
        {
            return int.Parse(next());
        }

        public long nextLong()
        {
            return long.Parse(next());
        }

        public double nextDouble()
        {
            return double.Parse(next());
        }

        private T[] enumerate<T>(int n, Func<T> f)
        {
            var a = new T[n];
            for (int i = 0; i < n; ++i) a[i] = f();
            return a;
        }

        public string[] next(int n) { return enumerate(n, next); }
        public double[] nextDouble(int n) { return enumerate(n, nextDouble); }
        public int[] nextInt(int n) { return enumerate(n, nextInt); }
        public long[] nextLong(int n) { return enumerate(n, nextLong); }
        #endregion
    }
}



#region MyMath
static partial class Func
{
    #region BasicMath
    //TODO: 基本セットの整備(extgcdとか)

    /// <summary>
    /// 最大公約数
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public static int GCD(int n, int m)
    {
        var a = Math.Abs(n);
        var b = Math.Abs(m);
        if (a < b) { var c = a; a = b; b = c; }
        while (b > 0)
        {
            var c = a % b;
            a = b;
            b = c;
        }
        return a;
    }
    /// <summary>
    /// 使わないで
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public static long GCD_oldver(long n, long m)
    {
        var a = Math.Abs(n);
        var b = Math.Abs(m);
        if (a < b) { var c = a; a = b; b = c; }
        while (b > 0)
        {
            var c = a % b;
            a = b;
            b = c;
        }
        return a;
    }
    /// <summary>
    /// 最大公約数
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long GCD(long a, long b)
    {
        var n = (ulong)Math.Abs(a); var m = (ulong)Math.Abs(b);
        if (n == 0) return (long)m; if (m == 0) return (long)n;
        int zm = 0, zn = 0;
        while ((n & 1) == 0) { n >>= 1; zn++; }
        while ((m & 1) == 0) { m >>= 1; zm++; }
        while (m != n)
        {
            if (m > n) { m -= n; while ((m & 1) == 0) m >>= 1; }
            else { n -= m; while ((n & 1) == 0) n >>= 1; }
        }
        return (long)n << Math.Min(zm, zn);
    }
    /// <summary>
    /// 最大公約数
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    //public static BigInteger GCD(BigInteger a, BigInteger b) { return BigInteger.GreatestCommonDivisor(a, b); } //comment out if AOJ

    /// <summary>
    /// 最小公倍数
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public static long LCM(long n, long m) { return Math.Abs((n / GCD(n, m)) * m); }

    /// <summary>
    /// n以下の素数のリストを返す (get all primes less than or equal to n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static List<int> GetPrimes(int n)
    {
        if (n < 3) n = 3;
        var m = (n - 1) >> 1;
        var primes = new List<int>((int)(n / Math.Log(n)));
        primes.Add(2);
        var composites = new bool[m];
        composites[0] = false;
        for (var p = 0; p < m; p++)
        {
            if (!composites[p])
            {
                var pnum = 2 * p + 3;
                primes.Add(pnum);
                for (var k = 3 * p + 3; k < m; k += pnum) composites[k] = true;
            }
        }
        return primes;
    }

    #endregion

    #region Mod
    const int mod = 1000000007;

    public struct Mod
    {
        public long n;
        public Mod(long m)
        {
            n = m;
            if (n >= mod) n %= mod;
            else if (n < 0) n = (n % mod + mod) % mod;
        }

        public static explicit operator long(Mod m) { return m.n; }

        //public static bool operator ==(Mod a, Mod b) { return a.n == b.n; }
        //public static Mod operator +=(Mod a, Mod b) { a.n += b.n; if (a.n >= mod) a.n -= mod; return a; }
        //public static Mod operator -=(Mod a, Mod b) { a.n -= b.n; if (a.n < 0) a.n += mod; return a; }
        //public static Mod operator *=(Mod a, Mod b) { a.n = (int)(((long)a.n* b.n) % mod); return a; }
        public static Mod operator +(Mod a, Mod b) { long tmp = a.n + b.n; if (tmp >= mod) tmp -= mod; return new Mod(tmp); }
        public static Mod operator -(Mod a, Mod b) { long tmp = a.n - b.n; if (tmp < mod) tmp += mod; return new Mod(tmp); }
        public static Mod operator *(Mod a, Mod b) { long tmp = ((a.n * b.n) % mod); return new Mod(tmp); }
        public static Mod operator ^(Mod a, int n)
        {
            if (n == 0) return new Mod(1);
            Mod res = (a * a) ^ (n / 2);
            if (n % 2 == 1) res = res * a;
            return res;
        }
        public static Mod operator /(Mod a, Mod b)
        {
            return a * new Mod(inv(b.n, mod));
        }
    }


    static long inv(long a, long p)
    {
        return (a == 1 ? 1 : (1 - p * inv(p % a, a)) / a + p);
    }

    const int MAX_N = 1024000;
    static bool modFact_Initialized = false;
    static Mod[] fact = new Mod[MAX_N], factinv = new Mod[MAX_N];
    static void init()
    {
        modFact_Initialized = true;
        fact[0] = new Mod(1); factinv[0] = new Mod(1);
        for (int i = 0; i < MAX_N - 1; i++)
        {
            fact[i + 1] = fact[i] * new Mod(i + 1);
            factinv[i + 1] = factinv[i] / new Mod(i + 1);
        }
    }
    public static Mod comb(int a, int b)
    {
        if (modFact_Initialized == false) { init(); }
        return fact[a] * factinv[b] * factinv[a - b];
    }

    #endregion
}
#endregion