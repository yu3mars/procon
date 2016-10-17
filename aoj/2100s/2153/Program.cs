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
        int w, h;
        string[][] room;
        bool[,,,] done; //ly,lx,ry,rx

        int[] vy = { 1, 0, -1, 0 };
        int[] vx = { 0, 1, 0, -1 }; 
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
                w = sc.nextInt();
                h = sc.nextInt();
                if (w == 0) return;
                room = new string[2][];
                done = new bool[h, w, h, w];

                for (int i = 0; i < 2; i++)
                {
                    room[i] = new string[h];
                }
                Place s = new Place();
                Place g = new Place();
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        room[j][i] = sc.next();
                        for (int k = 0; k < w; k++)
                        {
                            if(room[j][i][k]=='L')
                            {
                                s.ly = i;
                                s.lx = k;
                            }
                            else if(room[j][i][k]=='R')
                            {
                                s.ry = i;
                                s.rx = k;
                            }
                            else if (room[j][i][k] == '%')
                            {
                                if(j==0)
                                {
                                    g.ly = i;
                                    g.lx = k;
                                }
                                else
                                {
                                    g.ry = i;
                                    g.rx = k;
                                }
                            }
                        }
                    }
                }
                Queue<Place> q = new Queue<Place>();
                q.Enqueue(s);
                done[s.ly, s.lx, s.ry, s.rx] = true;
                while(q.Count>0)
                {
                    Place now = q.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        Place next = new Place(now.lx + vx[i], now.ly + vy[i], now.rx - vx[i], now.ry + vy[i]);
                        if(inside(next.ly,next.lx) == false || room[0][next.ly][next.lx]=='#')
                        {
                            next.lx = now.lx;
                            next.ly = now.ly;
                        }
                        if (inside(next.ry, next.rx) == false || room[1][next.ry][next.rx] == '#')
                        {
                            next.rx = now.rx;
                            next.ry = now.ry;
                        }
                        if((room[0][next.ly][next.lx] == '%' && room[1][next.ry][next.rx] != '%') ||
                            (room[0][next.ly][next.lx] != '%' && room[1][next.ry][next.rx] == '%')) //  katahou dake goal
                        {
                            continue;
                        }
                        if(done[next.ly,next.lx,next.ry,next.rx]==false)
                        {
                            q.Enqueue(next);
                            done[next.ly, next.lx, next.ry, next.rx] = true;
                        }
                    }
                }
                pr.WriteLine(done[g.ly, g.lx, g.ry, g.rx]);
            }
        }
        struct Place
        {
            public int lx, ly, rx, ry;
            public Place(int lx, int ly, int rx, int ry)
            {
                this.lx = lx;
                this.ly = ly;
                this.rx = rx;
                this.ry = ry;
            }
        }

        bool inside(int y, int x)
        {
            return y >= 0 && x >= 0 && y < h && x < w;
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
        public void WriteLine(bool b) { file.WriteLine(b ? "Yes" : "No"); }
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