using System;
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
            int n = sc.nextInt();
            int[] a = new int[n];
            int[] asum = new int[n];
            for (int i = 0; i < n - 1; i++)
            {
                a[i] = sc.nextInt();
                asum[i] = a[i];
                if (i > 0)
                {
                    asum[i] += asum[i - 1];
                }
            }
            int m = sc.nextInt();
            if (m > 1) return;
            int[] x = sc.nextInt(m);
            for (int mCnt = 0; mCnt < m; mCnt++)
            {
                a[n - 1] = x[mCnt];

                int scnt = 0;
                int rcnt = 1;
                int sscore = a[0];
                int rscore = a[1];
                while (scnt != n - 1 && rcnt != n - 1)
                {
                    if(scnt<rcnt)
                    {
                        int next = rcnt + 1;
                        for (int nexttmp = rcnt + 1; nexttmp < n; nexttmp++)
                        {
                            if(a[nexttmp]> asum[nexttmp - 1]- asum[rcnt])
                            {
                                next = nexttmp;
                            }
                        }
                        rscore += asum[next - 1] - asum[rcnt];
                        rcnt = next - 1;
                        sscore += a[next];
                        scnt = next;
                    }
                    else
                    {
                        int next = scnt + 1;
                        for (int nexttmp = scnt + 1; nexttmp < n; nexttmp++)
                        {
                            if (a[nexttmp] > asum[nexttmp - 1] - asum[scnt])
                            {
                                next = nexttmp;
                            }
                        }
                        sscore += asum[next - 1] - asum[scnt];
                        scnt = next - 1;
                        rscore += a[next];
                        rcnt = next;
                    }
                }
                Console.WriteLine(sscore-rscore);
            }
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
