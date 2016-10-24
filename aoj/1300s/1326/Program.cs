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
            for(;;)
            {
                int p = sc.nextInt();
                int q = sc.nextInt();
                if (p == 0) return;
                string[] sp = sc.next(p);
                string[] sq = sc.next(q);
                int[] pdot = new int[p];
                int[][] pkakko = new int[p][];
                int[] qdot = new int[q];
                int[][] qkakko = new int[q][];
                List<int[]> kakkols = new List<int[]>();
                
                for (int pcnt = 0; pcnt < p; pcnt++)
                {
                    pkakko[pcnt] = new int[3];
                    if(pcnt > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            pkakko[pcnt][i] = pkakko[pcnt - 1][i];
                        }
                    }

                    bool indent = true;
                    for (int charcnt = 0; charcnt < sp[pcnt].Length; charcnt++)
                    {
                        switch (sp[pcnt][charcnt])
                        {
                            case '.':
                                if (indent) pdot[pcnt]++;
                                break;
                            case '(':
                                indent = false;
                                pkakko[pcnt][0]++;
                                break;
                            case '{':
                                indent = false;
                                pkakko[pcnt][1]++;
                                break;
                            case '[':
                                indent = false;
                                pkakko[pcnt][2]++;
                                break;
                            case ')':
                                indent = false;
                                pkakko[pcnt][0]--;
                                break;
                            case '}':
                                indent = false;
                                pkakko[pcnt][1]--;
                                break;
                            case ']':
                                indent = false;
                                pkakko[pcnt][2]--;
                                break;
                            default:
                                indent = false;
                                break;
                        }
                    }                    
                }

                for (int qcnt = 0; qcnt < q; qcnt++)
                {
                    qkakko[qcnt] = new int[3];
                    if (qcnt > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            qkakko[qcnt][i] = qkakko[qcnt - 1][i];
                        }
                    }
                    
                    for (int charcnt = 0; charcnt < sq[qcnt].Length; charcnt++)
                    {
                        switch (sq[qcnt][charcnt])
                        {
                            case '(':
                                qkakko[qcnt][0]++;
                                break;
                            case '{':
                                qkakko[qcnt][1]++;
                                break;
                            case '[':
                                qkakko[qcnt][2]++;
                                break;
                            case ')':
                                qkakko[qcnt][0]--;
                                break;
                            case '}':
                                qkakko[qcnt][1]--;
                                break;
                            case ']':
                                qkakko[qcnt][2]--;
                                break;
                            default:
                                break;
                        }
                    }
                }

                for (int a = 1; a <= 20; a++)
                {
                    for (int b = 1; b <= 20; b++)
                    {
                        for (int c = 1; c <= 20; c++)
                        {
                            bool ok = true;
                            for (int pcnt = 0; pcnt < p - 1; pcnt++)
                            {
                                int indent = a * pkakko[pcnt][0] + b * pkakko[pcnt][1] + c * pkakko[pcnt][2];
                                if(indent != pdot[pcnt + 1])
                                {
                                    ok = false;
                                    break;
                                }
                            }
                            if(ok)
                            {
                                kakkols.Add(new int[3] { a, b, c });
                            }
                        }
                    }
                }


                for (int lscnt = 0; lscnt < kakkols.Count; lscnt++)
                {
                    for (int qcnt = 0; qcnt < q - 1; qcnt++)
                    {
                        int indent = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            indent += kakkols[lscnt][i] * qkakko[qcnt][i];
                        }
                        if(qdot[qcnt + 1] == 0)
                        {
                            qdot[qcnt + 1] = indent;
                        }
                        else if(qdot[qcnt + 1] != indent)
                        {
                            qdot[qcnt + 1] = -1;
                        }
                    }
                }

                //Console.WriteLine(string.Join(" ", qdot));
                for (int i = 0; i < q; i++)
                {
                    if (i > 0) Console.Write(" ");
                    Console.Write(qdot[i]);
                }
                Console.WriteLine();
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