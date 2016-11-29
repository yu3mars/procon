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
using static Func;
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
            long n = sc.nextLong();
            long m = sc.nextLong();
            if(n>m)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                Mod ans = new Mod(1);
                for (int i = 0; i < n; i++)
                {
                    ans *= new Mod(m - i);
                }
                for (int i = 0; i < m-n; i++)
                {
                    ans *= new Mod(n);
                }
                Console.WriteLine(ans.n);
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


/// <summary>
/// 共通機能
/// </summary>
static partial class Func
{
    public const int Inf = 1073741789;  // 2 * Inf < int.MaxValue, and Inf is a prime number
    public const long InfL = 4011686018427387913L;  // 2 * InfL < long.MaxValue, and InfL is a prime number
    public static Comparison<T> DefaultComparison<T>() { return (x, y) => Comparer<T>.Default.Compare(x, y); }
    public static Comparison<T> ToComparison<T>(this IComparer<T> comp) { return comp == null ? DefaultComparison<T>() : (x, y) => comp.Compare(x, y); }
    /// <summary>
    /// Find the first number x such that pred(x) is true
    /// if pred(x) is false for all min&lt;=x&lt;max, then return max
    /// in other words, pred(max) is assumed to be true
    /// </summary>
    /// <param name="min">inclusive lower limit</param>
    /// <param name="max">exclusive upper limit</param>
    /// <param name="pred">monotonous predicate, i.e. if pred(a) and a&lt;b, then pred(b)</param>
    /// <returns>first number such that satisfy pred</returns>
    public static long FirstBinary(long min, long max, Predicate<long> pred)
    {
        while (min < max)
        {
            var mid = (min + max) / 2;
            if (pred(mid)) max = mid;
            else min = mid + 1;
        }
        return min;
    }
    /// <summary>
    /// Find the first number x such that pred(x) is true
    /// if pred(x) is false for all min&lt;=x&lt;max, then return max
    /// in other words, pred(max) is assumed to be true
    /// </summary>
    /// <param name="min">inclusive lower limit</param>
    /// <param name="max">exclusive upper limit</param>
    /// <param name="pred">monotonous predicate, i.e. if pred(a) and a&lt;b, then pred(b)</param>
    /// <returns>first number such that satisfy pred</returns>
    public static int FirstBinary(int min, int max, Predicate<int> pred)
    {
        while (min < max)
        {
            var mid = (min + max) / 2;
            if (pred(mid)) max = mid;
            else min = mid + 1;
        }
        return min;
    }
    public static void Swap<T>(this IList<T> array, int i, int j) { var tmp = array[i]; array[i] = array[j]; array[j] = tmp; }
    public static void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}


/// <summary>
/// C++のSTLを再実装
/// </summary>
namespace STL
{
    class PriorityQueue<T> : IEnumerable<T>, ICollection, IEnumerable, ICloneable
    {
        Comparison<T> comp;
        List<T> list;
        public int Count { get; private set; }
        public bool IsEmpty { get { return Count == 0; } }
        public PriorityQueue(IEnumerable<T> source) : this((Comparison<T>)null, 0, source) { }
        public PriorityQueue(int capacity = 0, IEnumerable<T> source = null) : this((Comparison<T>)null, capacity, source) { }
        public PriorityQueue(IComparer<T> comp, IEnumerable<T> source) : this(comp.ToComparison(), source) { }
        public PriorityQueue(IComparer<T> comp, int capacity = 0, IEnumerable<T> source = null) : this(comp.ToComparison(), source) { list.Capacity = capacity; }
        public PriorityQueue(Comparison<T> comp, IEnumerable<T> source) : this(comp, 0, source) { }
        public PriorityQueue(Comparison<T> comp, int capacity = 0, IEnumerable<T> source = null) { this.comp = comp == null ? Func.DefaultComparison<T>() : comp; list = new List<T>(capacity); if (source != null) foreach (var x in source) Enqueue(x); }
        /// <summary>
        /// add an item
        /// this is an O(log n) operation
        /// </summary>
        /// <param name="x">item</param>
        public void Enqueue(T x)
        {
            var pos = Count++;
            list.Add(x);
            while (pos > 0)
            {
                var p = (pos - 1) / 2;
                if (comp(list[p], x) <= 0) break;
                list[pos] = list[p];
                pos = p;
            }
            list[pos] = x;
        }
        /// <summary>
        /// return the minimum element and remove it
        /// this is an O(log n) operation
        /// </summary>
        /// <returns>the minimum</returns>
        public T Dequeue()
        {
            var value = list[0];
            var x = list[--Count];
            list.RemoveAt(Count);
            if (Count == 0) return value;
            var pos = 0;
            while (pos * 2 + 1 < Count)
            {
                var a = 2 * pos + 1;
                var b = 2 * pos + 2;
                if (b < Count && comp(list[b], list[a]) < 0) a = b;
                if (comp(list[a], x) >= 0) break;
                list[pos] = list[a];
                pos = a;
            }
            list[pos] = x;
            return value;
        }
        /// <summary>
        /// look at the minimum element
        /// this is an O(1) operation
        /// </summary>
        /// <returns>the minimum</returns>
        public T Peek() { return list[0]; }
        public IEnumerator<T> GetEnumerator() { var x = (PriorityQueue<T>)Clone(); while (x.Count > 0) yield return x.Dequeue(); }
        void CopyTo(Array array, int index) { foreach (var x in this) array.SetValue(x, index++); }
        public object Clone() { var x = new PriorityQueue<T>(comp, Count); x.list.AddRange(list); return x; }
        public void Clear() { list = new List<T>(); Count = 0; }
        public void TrimExcess() { list.TrimExcess(); }
        /// <summary>
        /// check whether item is in this queue
        /// this is an O(n) operation
        /// </summary>
        public bool Contains(T item) { return list.Contains(item); }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
        void ICollection.CopyTo(Array array, int index) { CopyTo(array, index); }
        bool ICollection.IsSynchronized { get { return false; } }
        object ICollection.SyncRoot { get { return this; } }
    }
    class Deque<T>
    {
        T[] array;
        int offset, capacity;
        public int Count { get; protected set; }
        public Deque(int capacity) { array = new T[this.capacity = capacity]; Count = 0; offset = 0; }
        public Deque() : this(16) { }
        public T this[int index] { get { return array[GetIndex(index)]; } set { array[GetIndex(index)] = value; } }
        int GetIndex(int index) { var tmp = index + offset; return tmp >= capacity ? tmp - capacity : tmp; }
        public T PeekFront() { return array[offset]; }
        public T PeekBack() { return array[GetIndex(Count - 1)]; }
        public void PushFront(T item)
        {
            if (Count == capacity) Extend();
            if (--offset < 0) offset += array.Length;
            array[offset] = item;
            Count++;
        }
        public T PopFront()
        {
            Count--;
            var tmp = array[offset++];
            if (offset >= capacity) offset -= capacity;
            return tmp;
        }
        public void PushBack(T item)
        {
            if (Count == capacity) Extend();
            var id = (Count++) + offset;
            if (id >= capacity) id -= capacity;
            array[id] = item;
        }
        public T PopBack() { return array[GetIndex(--Count)]; }
        public void Insert(int index, T item)
        {
            PushFront(item);
            for (var i = 0; i < index; i++) this[i] = this[i + 1];
            this[index] = item;
        }
        public T RemoveAt(int index)
        {
            var tmp = this[index];
            for (var i = index; i > 0; i--) this[i] = this[i - 1];
            PopFront();
            return tmp;
        }
        void Extend()
        {
            var newArray = new T[capacity << 1];
            if (offset > capacity - Count)
            {
                var length = array.Length - offset;
                Array.Copy(array, offset, newArray, 0, length);
                Array.Copy(array, 0, newArray, length, Count - length);
            }
            else Array.Copy(array, offset, newArray, 0, Count);
            array = newArray;
            offset = 0;
            capacity <<= 1;
        }
    }
    class PairComparer<S, T> : IComparer<Pair<S, T>>
        where S : IComparable<S>
        where T : IComparable<T>
    {
        public PairComparer() { }
        public int Compare(Pair<S, T> x, Pair<S, T> y)
        {
            var p = x.First.CompareTo(y.First);
            if (p != 0) return p;
            else return x.Second.CompareTo(y.Second);
        }
    }
    class Pair<S, T>
    {
        public S First;
        public T Second;
        public Pair() { First = default(S); Second = default(T); }
        public Pair(S s, T t) { First = s; Second = t; }
        public override string ToString() { return string.Format("({0}, {1})", First, Second); }
        public override int GetHashCode() { return First.GetHashCode() ^ Second.GetHashCode(); }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            else if (obj == null) return false;
            var tmp = obj as Pair<S, T>;
            return (object)tmp != null && First.Equals(tmp.First) && Second.Equals(tmp.Second);
        }
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
            public static Point3D operator -(Point3D p) { return new Point3D(-p.X, -p.Y, -p.Z); }
            public static Point3D operator /(Point3D p, double r) { return new Point3D(p.X / r, p.Y / r, p.Z / r); }
            public static Point3D operator *(double r, Point3D p) { return new Point3D(p.X * r, p.Y * r, p.Z * r); }
            public static Point3D operator *(Point3D p, double r) { return new Point3D(p.X * r, p.Y * r, p.Z * r); }
            public static Point3D operator +(Point3D p, Point3D q) { return new Point3D(p.X + q.X, p.Y + q.Y, p.Z + q.Z); }
            public static Point3D operator -(Point3D p, Point3D q) { return new Point3D(p.X - q.X, p.Y - q.Y, p.Z - q.Z); }
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
    /// <summary>
    /// aCb (combination, 組合せ)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Mod comb(int a, int b)
    {
        if (modFact_Initialized == false) { init(); }
        return fact[a] * factinv[b] * factinv[a - b];
    }

    #endregion
}
#endregion
