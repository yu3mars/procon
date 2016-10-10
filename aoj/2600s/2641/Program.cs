using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
//using System.Numerics;
using System.Text;

using Problem = Tmp.Problem;
using MyIO;
//using STL;

namespace Tmp
{
    //   using static Func;
    //   using static Math;
    //using static Geometry.Geometry3D;
    using Point3D = Geometry.Geometry3D.Point3D;
    using Line3D = Geometry.Geometry3D.Line3D;

    class Problem : IDisposable
    {
//        bool IsGCJ;
//        int Repeat;
        Scanner sc;
        Printer pr;
        public Problem(bool isGCJ, Scanner scanner, Printer printer)
        {
            sc = scanner;
            pr = printer;
//            IsGCJ = isGCJ;
            //if (isGCJ) Repeat = sc.Get<int>();
            //else Read();
        }
        public Problem(bool isGCJ) : this(isGCJ, new Scanner(), new Printer()) { }
        public Problem(bool isGCJ, Scanner scanner) : this(isGCJ, scanner, new Printer()) { }
        public Problem(bool isGCJ, Printer printer) : this(isGCJ, new Scanner(), printer) { }
        public void Solve()
        {
             SolveOne();
        }
        public void Dispose()
        {
            sc.Dispose();
            pr.Dispose();
        }
        public int Size { get { return 1; } }
        public const long Mod = 1000000007;
//        RandomSFMT rand = Program.rand;

        // 使用する変数をここに書く
//        string S;
//        int a;
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
            int q = sc.nextInt();
            Point3D[] syougai = new Point3D[n];
            double[] r = new double[n];
            long[] l = new long[n];
            for (int i = 0; i < n; i++)
            {
                syougai[i] = new Point3D(sc.nextDouble(3));
                r[i] = sc.nextDouble();
                l[i] = sc.nextLong();
            }
            for (int i = 0; i < q; i++)
            {
                long ans = 0;
                Point3D start = new Point3D(sc.nextDouble(3));
                Point3D goal = new Point3D(sc.nextDouble(3));
                Line3D line = new Line3D(start, goal);
                for (int j = 0; j < n; j++)
                {
                    //double x = Geometry.Geometry3D.distance_sp(line, syougai[j]);
                    //double y = r[j] - Geometry.Geometry3D.Eps;
                    //bool temp = Geometry.Geometry3D.distance_sp(line, syougai[j]) < r[j] - Geometry.Geometry3D.Eps;
                    if (Geometry.Geometry3D.distance_sp(line,syougai[j]) < r[j] + Geometry.Geometry3D.Eps)
                    {
                        ans += l[j];
                    }
                }
                pr.WriteLine(ans);
            }
        }
    }
}
class Program
{
//    public static RandomSFMT rand = new RandomSFMT();
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
//                    time += Func.MeasureTime(() => P.Solve());
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
        public void WriteLine<T>(T value) { file.WriteLine(value); }
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

/// <summary>
/// 幾何ライブラリ
/// </summary>
namespace Geometry
{
    #region 3次元幾何


    /// <summary>
    /// 3次元幾何
    /// </summary>
    static class Geometry3D
    {
        public static double Eps = 1e-8;
        public static double Inf = 1e12;
        /// <summary>
        /// 点/ベクトル(3次元)
        /// </summary>
        public struct Point3D
        {
            public double X;
            public double Y;
            public double Z;
            public Point3D(double x, double y, double z) { X = x; Y = y; Z = z; }
            public Point3D(double[] ls) { X = ls[0]; Y = ls[1]; Z = ls[2]; }

            public static Point3D operator +(Point3D p) { return new Point3D(p.X, p.Y, p.Z); }
            public static Point3D operator -(Point3D p)
            {
                return new Point3D(-p.X, -p.Y, -p.Z); }
            public static Point3D operator /(Point3D p, double r)
            {
                return new Point3D(p.X / r, p.Y / r, p.Z / r); }
            public static Point3D operator *(double r, Point3D p)
            {
                return new Point3D(p.X * r, p.Y * r, p.Z * r); }
            public static Point3D operator *(Point3D p, double r)
            {
                return new Point3D(p.X * r, p.Y * r, p.Z * r); }
            public static Point3D operator +(Point3D p, Point3D q)
            {
                return new Point3D(p.X + q.X, p.Y + q.Y, p.Z + q.Z);
            }
            public static Point3D operator -(Point3D p, Point3D q)
            { return new Point3D(p.X - q.X, p.Y - q.Y, p.Z - q.Z); }
        }

        /// <summary>
        /// 線分/直線(3次元)
        /// </summary>
        public struct Line3D
        {
            public Point3D a, b;
            public Line3D(Point3D a, Point3D b) { this.a = a; this.b = b; }
        }

        /// <summary>
        /// 内積
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double dot(Point3D a, Point3D b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        /// <summary>
        /// 外積
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Point3D cross(Point3D a, Point3D b)
        {
            return new Point3D(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
        }

        public static double norm(Point3D a)
        {
            return dot(a, a);
        }

        public static double dist(Point3D a)
        {
            return Math.Sqrt(norm(a));
        }

        #region line
        /// <summary>
        /// 点が線分上にあるか
        /// </summary>
        /// <param name="l">線分</param>
        /// <param name="p">点</param>
        /// <returns></returns>
        public static bool is_in_segment(Line3D l, Point3D p)
        {
            return Math.Abs(dist(l.a - p) + dist(l.b - p) - dist(l.a - l.b)) < Eps;
        }

        /// <summary>
        /// 点の射影(点から直線に引いた垂線と線分の交点)
        /// </summary>
        /// <param name="l">直線</param>
        /// <param name="p">点</param>
        /// <returns></returns>
        public static Point3D project_lp(Line3D l, Point3D p)
        {
            Point3D point = l.a, vec = l.b - l.a;
            return point + dot(p - point, vec) / norm(vec) * vec;
        }

        /// <summary>
        /// 点と直線の距離
        /// </summary>
        /// <param name="l">直線</param>
        /// <param name="p">点</param>
        /// <returns></returns>
        public static double distance_lp(Line3D l, Point3D p)
        {
            return dist(p - project_lp(l, p));
        }

        /// <summary>
        /// 点と線分の距離
        /// </summary>
        /// <param name="l">線分</param>
        /// <param name="p">点</param>
        /// <returns></returns>
        public static double distance_sp(Line3D l, Point3D p)
        {
            Point3D proj = project_lp(l, p);
            if (is_in_segment(l, proj))
            {
                return dist(p - proj);
            }
            else
            {
                return Math.Min(dist(p - l.a), dist(p - l.b));
            }
        }

        /// <summary>
        /// 直線と直線の距離
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double distance_ll(Line3D l, Line3D m)
        {
            Point3D v = cross(l.b - l.a, m.b - m.a), p = m.a - l.a;
            if (dist(v) < Eps)
            {
                return distance_lp(l, m.a);
            }
            else
            {
                return Math.Abs(dot(v, p)) / dist(v);
            }
        }
        #endregion

        //TODO Plane関連以下の実装
    }

    #endregion
}
