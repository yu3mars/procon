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
            int[] a = sc.nextInt(n);
            int ans = 0;
            bool[] used = new bool[n];
            Deque<int> d1 = new Deque<int>();
            Deque<int> d2 = new Deque<int>();
            Deque<int> d3 = new Deque<int>();
            Deque<int> d4 = new Deque<int>();
            for (int i = 0; i < n; i++)
            {
                switch (a[i])
                {
                    case 1:
                        d1.PushBack(i);
                        break;

                    case 2:
                        d2.PushBack(i);
                        break;

                    case 3:
                        d3.PushBack(i);
                        break;

                    case 4:
                        d4.PushBack(i);
                        break;

                    default:
                        break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (used[i]) continue;
                ans++;
                int tmp = a[i];
                used[i] = true;
                switch (a[i])
                {
                    case 1:
                        d1.PopFront();
                        break;

                    case 2:
                        d2.PopFront();
                        break;

                    case 3:
                        d3.PopFront();
                        break;

                    case 4:
                        d4.PopFront();
                        break;

                    default:
                        break;
                }

                while (tmp < 4)
                {
                    if (d3.Count > 0 && tmp <= 1)
                    {
                        used[d3.PopBack()] = true;
                        tmp += 3;
                    }
                    else if (d2.Count > 0 && tmp <= 2)
                    {
                        used[d2.PopBack()] = true;
                        tmp += 2;
                    }
                    else if (d1.Count > 0 && tmp <= 3)
                    {
                        used[d1.PopFront()] = true;
                        tmp += 1;
                    }
                    else break;
                }
            }
            Console.WriteLine(ans);
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
/// C++のSTLを再実装
/// </summary>
#region STL
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
#endregion //STL
