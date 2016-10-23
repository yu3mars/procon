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
        int h, w;
        char[][] c;
        int[,,] dp;
        //char nil = '.';
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
            h = sc.nextInt();
            w = sc.nextInt();

            if (w > 3) return;  //TODO: Delete
            int ans = int.MaxValue;

            c = new char[h][];
            for (int i = 0; i < h; i++)
            {
                c[i] = sc.next().ToCharArray();
            }

            dp = new int[h + 2, h + 2, h + 2];
            for (int i = 0; i < h + 2; i++)
            {
                for (int j = 0; j < h + 2; j++)
                {
                    for (int k = 0; k < h + 2; k++)
                    {
                        dp[i, j, k] = int.MaxValue;
                    }
                }
            }
            dp[0, 0, 0] = 0;
            
            /*
            Queue<int> qp = new Queue<int>();
            Queue<int> qq = new Queue<int>();
            Queue<int> qr = new Queue<int>();
            HashSet<long> dic = new HashSet<long>();
            qp.Enqueue(0);
            qq.Enqueue(0);
            qr.Enqueue(0);
            dic.Add(0);
            while(qp.Count>0)
            {
                int p = qp.Dequeue();
                int q = qq.Dequeue();
                int r = qr.Dequeue();
                if(p<h && dic.Contains(CalcHash(p+1,q,r))==false)
                {
                    dp[p + 1, q, r] = Math.Min(dp[p + 1, q, r], dp[p, q, r] + CountScore(0, p, q, r));
                    qp.Enqueue(p+1);
                    qq.Enqueue(q);
                    qr.Enqueue(r);
                }
                if (q < h && dic.Contains(CalcHash(p , q + 1, r)) == false)
                {
                    dp[p, q + 1, r] = Math.Min(dp[p, q + 1, r], dp[p, q, r] + CountScore(1, p, q, r));

                    qp.Enqueue(p);
                    qq.Enqueue(q + 1);
                    qr.Enqueue(r);
                }
                if (r < h && dic.Contains(CalcHash(p, q, r + 1)) == false)
                {
                    dp[p, q, r + 1] = Math.Min(dp[p, q + 1, r], dp[p, q, r] + CountScore(2, p, q, r));

                    qp.Enqueue(p);
                    qq.Enqueue(q);
                    qr.Enqueue(r + 1);
                }
            }
            */

            
            for (int sum = 0; sum < h*w; sum++)
            {
                for (int p = 0; p <= Math.Min(sum,h); p++)
                {
                    for (int q = 0; q <= Math.Min(sum-p,h); q++)
                    {
                        for (int r = 0; r <= Math.Min(sum - p - q, h); r++)
                        {
                            dp[p + 1, q, r] = Math.Min(dp[p + 1, q, r], dp[p, q, r] + CountScore(0, p, q, r));
                            dp[p, q + 1, r] = Math.Min(dp[p, q + 1, r], dp[p, q, r] + CountScore(1, p, q, r));
                            dp[p, q, r + 1] = Math.Min(dp[p, q, r + 1], dp[p, q, r] + CountScore(2, p, q, r));
                        }
                    }
                }
            }
            

            Console.WriteLine(dp[h,h,h]);
        }
        long CalcHash(int p,int q,int r)
        {
            return p * 1000000L + q * 1000L + r;
        }
        bool insideH(int y)
        {
            return y >= 0 && y < h;
        }
        bool insideW(int x)
        {
            return x >= 0  && x < w;
        }

        int CountScore(int wi, int p, int q, int r)
        {
            int ret = 0;
            if(wi == 0)
            {
                for (int i = 0; (i + p < h && i + q < h); i++)
                {
                    if (c[i + q][0] == c[i + p][1]) ret++;
                }
            }
            else if(wi==1)
            {
                for (int i = 0; (i + p < h && i + q < h); i++)
                {
                    if (c[i + q][0] == c[i + p][1]) ret++;
                }
                for (int i = 0; (i + q < h && i + r < h); i++)
                {
                    if (c[i + q][2] == c[i + r][1]) ret++;
                }
            }
            else if(wi==2)
            {
                for (int i = 0; ( i + q < h && i + r < h); i++)
                {
                    if (c[i + q][2] == c[i + r][1]) ret++;
                }
            }
            return ret;
        }

        /*

        int Delete(int wi)
        {
            int ret = CountScore(wi);
            Down(wi);
            return ret;
        }

        /// <summary>
        /// 全部消えているかを返す
        /// </summary>
        /// <param name="wi"></param>
        /// <returns></returns>
        bool Down(int wi)
        {
            for (int i = h - 1; i > 0; i--)
            {
                c[i][wi] = c[i - 1][wi];
            }
            c[0][wi] = nil;
            return (c[h - 1][wi] == nil);
        }
        int CountScore(int wi)
        {
            int ret = 0;
            for (int i = 0; i < h; i++)
            {
                if (c[i][wi] == nil) continue;
                if (wi > 0)//hidari check
                {
                    if (c[i][wi] == c[i][wi - 1]) ret++;
                }
                if(wi < w - 1)//migi check
                {
                    if (c[i][wi] == c[i][wi + 1]) ret++;
                }
            }
            return ret;
        }

        void cFukugen()
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    c[i][j] = cOrigin[i][j];
                }
            }
        }
        */
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