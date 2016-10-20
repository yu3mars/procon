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
        char[][] image;
        HashMap<char,bool> check;
        HashMap<char, Zahyou> map;
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
            int dataset = sc.nextInt();
            for (int datasetcnt = 0; datasetcnt < dataset; datasetcnt++)
            {
                h = sc.nextInt();
                w = sc.nextInt();
                image = new char[h][];
                check = new HashMap<char, bool>();
                map = new HashMap<char, Zahyou>();
                for (int i = 0; i < h; i++)
                {
                    image[i] = sc.next().ToCharArray();
                    for (int j = 0; j < w; j++)
                    {
                        char c = image[i][j];
                        if ('A'<= c&& c<='Z')
                        {
                            if(map.ContainsKey(c))
                            {
                                map[c] = map[c].update(i, j);
                            }
                            else
                            {
                                map.Add(c, new Zahyou(i, j));
                                check.Add(c, false);
                            }
                        }
                    }
                }

                for (int cnt = 0; cnt < check.Count; cnt++)
                {
                    var ch = check.ToList();
                    foreach (var kv in ch)
                    {
                        if(kv.Value==false)
                        {
                            if(Scan(kv.Key))
                            {
                                check[kv.Key] = true;
                                Rewrite(kv.Key);
                            }
                        }
                    }
                }

                bool ok = true;
                foreach (var kv in check)
                {
                    if(kv.Value==false)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok) Console.WriteLine("SAFE");
                else Console.WriteLine("SUSPICIOUS");
            }
        }
        bool Scan(char c)
        {
            for (int y = map[c].u; y < map[c].d; y++)
            {
                for (int x = map[c].l; x < map[c].r; x++)
                {
                    if (image[y][x] != c && image[y][x] != '*')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        void Rewrite(char c)
        {
            for (int y = map[c].u; y < map[c].d; y++)
            {
                for (int x = map[c].l; x < map[c].r; x++)
                {
                    image[y][x] = '*';
                }
            }
        }
        struct Zahyou
        {
            public int u, d, l, r;
            public Zahyou(int y, int x)
            {
                u = y;
                d = y + 1; 
                l = x;
                r = x + 1;
            }
            public Zahyou update(int y,int x)
            {
                u = Math.Min(u, y);
                d = Math.Max(d, y + 1);
                l = Math.Min(l, x);
                r = Math.Max(r, x + 1);
                return this;
            }
        }

        bool inside(int y, int x)
        {
            return y >= 0 && x >= 0 && y < h && x < w;
        } 

        class HashMap<K, V> : Dictionary<K, V>
        {
            new public V this[K i]
            {
                get
                {
                    V v;
                    return TryGetValue(i, out v) ? v : base[i] = default(V);
                }
                set { base[i] = value; }
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