using System;
using System.Collections.Generic;
using System.Linq;
using Solver.Ex;
using Debug = System.Diagnostics.Debug;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
namespace Solver
{
    public class Solver
    {
        public void Solve()
        {
            for (; ; )
            {
                var n = sc.Integer();//town_num
                var m = sc.Integer();//life
                var l = sc.Integer();//freezer_num
                var k = sc.Integer();//road_num
                var a = sc.Integer();//from
                var h = sc.Integer();//to
                if (n == 0) return;
                var G = (n * (m + 1)).Enumerate(x => new List<KeyValuePair<int, long>>());
                for (int i = 0; i < l; i++)
                {
                    int ltmp = sc.Integer();
                    for (int j = 0; j < n * (m + 1); j += n)
                    {
                        G[ltmp + j].Add(new KeyValuePair<int, long>(ltmp, 1));
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    var x = sc.Integer();
                    var y = sc.Integer();
                    var t = sc.Integer();
                    for (int j = 0; j < m; j++)
                    {
                        if (x + n * (j + t) < n * (m + 1))
                        {
                            G[y + n * j].Add(new KeyValuePair<int, long>(x + n * (j + t), t));
                        }
                        if (y + n * (j + t) < n * (m + 1))
                        {
                            G[x + n * j].Add(new KeyValuePair<int, long>(y + n * (j + t), t));
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n * (m + 1); j += n)
                    {
                        G[i].Add(new KeyValuePair<int, long>(i + j, 0));
                    }
                }
                var dist = G.Dijkstra(a);
                if (dist[h] == 1L << 60)
                {
                    IO.Printer.Out.WriteLine("Help!");
                }
                else
                {
                    IO.Printer.Out.WriteLine(dist[h]);
                }
                IO.Printer.Out.WriteLine("####");
                /*
                for (int i = 0; i < n; i++)
                {
                    if (i == s || i == g) continue;
                    if (dist[i] == 1L << 60 || dist2[i] == 1L << 60) continue;
                    if (dist[i] == dist2[i])
                    {
                        IO.Printer.Out.WriteLine(i + 1);
                        return;
                    }
                }
                IO.Printer.Out.WriteLine(-1);
            */
            }
        }
        internal IO.StreamScanner sc;
    }
    #region Main and Settings
    static class Program
    {
        static void Main(string[] arg)
        {
#if DEBUG
            var errStream = new System.IO.FileStream(@"..\..\dbg.out", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(errStream, "debugStream"));
            Debug.AutoFlush = false;
            var sw = new Watch(); sw.Start();
            IO.Printer.Out.AutoFlush = true;
            try
            {
#endif

                var solver = new Solver();
                solver.sc = new IO.StreamScanner(Console.OpenStandardInput());
                solver.Solve();
                IO.Printer.Out.Flush();
#if DEBUG
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
            finally
            {
                sw.Stop();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Error.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);
                Debug.Close();
                System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
            }
#endif
        }


    }
    #endregion
}
#region IO Helper
namespace Solver.IO
{
    public class Printer : System.IO.StreamWriter
    {
        static Printer()
        {
            Out = new Printer(Console.OpenStandardOutput()) { AutoFlush = false };
#if DEBUG
            Error = new Printer(Console.OpenStandardOutput()) { AutoFlush = false };
#else
            Error = new Printer(System.IO.Stream.Null) { AutoFlush = false };
#endif
        }
        public static Printer Out { get; set; }
        public static Printer Error { get; set; }
        public override IFormatProvider FormatProvider { get { return System.Globalization.CultureInfo.InvariantCulture; } }
        public Printer(System.IO.Stream stream) : base(stream, new System.Text.UTF8Encoding(false, true)) { }
        public Printer(System.IO.Stream stream, System.Text.Encoding encoding) : base(stream, encoding) { }
        public void Write<T>(string format, IEnumerable<T> source) { Write(format, source.OfType<object>().ToArray()); }
        public void WriteLine<T>(string format, IEnumerable<T> source) { WriteLine(format, source.OfType<object>().ToArray()); }
    }
    public class StreamScanner
    {
        public StreamScanner(System.IO.Stream stream) { iStream = stream; }
        private readonly System.IO.Stream iStream;
        private readonly byte[] buf = new byte[1024];
        private int len, ptr;
        private bool eof = false;
        public bool IsEndOfStream { get { return eof; } }
        const byte lb = 33, ub = 126, el = 10, cr = 13;
        public byte read()
        {
            if (eof) throw new System.IO.EndOfStreamException();
            if (ptr >= len) { ptr = 0; if ((len = iStream.Read(buf, 0, 1024)) <= 0) { eof = true; return 0; } }
            return buf[ptr++];
        }
        public char Char() { byte b = 0; do b = read(); while (b < lb || ub < b);            return (char)b; }
        public char[] Char(int n) { var a = new char[n]; for (int i = 0; i < n; i++) a[i] = Char(); return a; }
        public char[][] Char(int n, int m) { var a = new char[n][]; for (int i = 0; i < n; i++) a[i] = Char(m); return a; }
        public string Scan()
        {
            if (eof) throw new System.IO.EndOfStreamException();
            StringBuilder sb = null;
            var enc = System.Text.UTF8Encoding.Default;
            do
            {
                for (; ptr < len && (buf[ptr] < lb || ub < buf[ptr]); ptr++) ;
                if (ptr < len) break;
                ptr = 0;
                if ((len = iStream.Read(buf, 0, 1024)) <= 0) { eof = true; return ""; }
            } while (true);
            do
            {
                var f = ptr;
                for (; ptr < len; ptr++)
                    if (buf[ptr] < lb || ub < buf[ptr])
                    //if (buf[ptr] == cr || buf[ptr] == el)
                    {
                        string s;
                        if (sb == null) s = enc.GetString(buf, f, ptr - f);
                        else { sb.Append(enc.GetChars(buf, f, ptr - f)); s = sb.ToString(); }
                        ptr++; return s;
                    }
                if (sb == null) sb = new StringBuilder(enc.GetString(buf, f, len - f));
                else sb.Append(enc.GetChars(buf, f, len - f));
                ptr = 0;

            }
            while (!eof && (len = iStream.Read(buf, 0, 1024)) > 0);
            eof = true; return (sb != null) ? sb.ToString() : "";
        }
        public long Long()
        {
            long ret = 0; byte b = 0; bool isMynus = false;
            const byte zr = 48, nn = 57, my = 45;
            do b = read();
            while (b != my && (b < zr || nn < b));
            if (b == my) { isMynus = true; b = read(); }
            for (; true; b = read())
                if (b < zr || nn < b)
                    return isMynus ? -ret : ret;
                else ret = ret * 10 + b - zr;
        }
        public int Integer()
        {
            int ret = 0; byte b = 0; bool isMynus = false;
            const byte zr = 48, nn = 57, my = 45;
            do b = read();
            while (b != my && (b < zr || nn < b));
            if (b == my) { isMynus = true; b = read(); }
            for (; true; b = read())
                if (b < zr || nn < b)
                    return isMynus ? -ret : ret;
                else ret = ret * 10 + b - zr;
        }
        public double Double() { return double.Parse(Scan(), System.Globalization.CultureInfo.InvariantCulture); }
        public string[] Scan(int n) { var a = new string[n]; for (int i = 0; i < n; i++) a[i] = Scan(); return a; }
        public double[] Double(int n) { var a = new double[n]; for (int i = 0; i < n; i++) a[i] = Double(); return a; }
        public int[] Integer(int n) { var a = new int[n]; for (int i = 0; i < n; i++) a[i] = Integer(); return a; }
        public long[] Long(int n) { var a = new long[n]; for (int i = 0; i < n; i++)a[i] = Long(); return a; }
        public void Flush() { iStream.Flush(); }
    }
}
#endregion
#region Extension
namespace Solver.Ex
{
    static public partial class EnumerableEx
    {
        static public string AsString(this IEnumerable<char> ie) { return new string(ie.ToArray()); }
        static public string AsJoinedString<T>(this IEnumerable<T> ie, string st = " ") { return string.Join(st, ie); }
        static public T[] Enumerate<T>(this int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; i++) a[i] = f(i); return a; }
    }
}
#endregion
#region Dijkstra
static partial class Graph
{
    //O(|V+E|log|V|)
    static public long[] Dijkstra(this List<KeyValuePair<int, long>>[] G, int s)
    {
        var n = G.Length;
        var ans = Enumerable.Repeat(1L << 60, n).ToArray();
        ans[s] = 0;
        var pq = new PriorityQueue<KeyValuePair<int, long>>((l, r) => l.Value.CompareTo(r.Value));
        pq.Enqueue(new KeyValuePair<int, long>(s, 0));
        while (pq.Count > 0)
        {
            var p = pq.Dequeue();
            if (p.Value > ans[p.Key]) continue;
            foreach (var to in G[p.Key])
                if (p.Value + to.Value < ans[to.Key])
                {
                    ans[to.Key] = p.Value + to.Value;
                    pq.Enqueue(new KeyValuePair<int, long>(to.Key, ans[to.Key]));
                }
        }

        return ans;
    }
}
#endregion

#region PriorityQueue by BinaryHeap
public class PriorityQueue<T>
{
    private readonly List<T> heap;
    private readonly Comparison<T> compare;
    private int size;
    public PriorityQueue() : this(Comparer<T>.Default) { }
    public PriorityQueue(IComparer<T> comparer) : this(16, comparer.Compare) { }
    public PriorityQueue(Comparison<T> comparison) : this(16, comparison) { }
    public PriorityQueue(int capacity, Comparison<T> comparison)
    {
        this.heap = new List<T>(capacity);
        this.compare = comparison;
    }
    public void Enqueue(T item)
    {

        this.heap.Add(item);
        var i = size++;
        while (i > 0)
        {
            var p = (i - 1) >> 1;
            if (compare(this.heap[p], item) <= 0)
                break;
            this.heap[i] = heap[p];
            i = p;
        }
        this.heap[i] = item;

    }
    public T Dequeue()
    {
        var ret = this.heap[0];
        var x = this.heap[--size];
        var i = 0;
        while ((i << 1) + 1 < size)
        {
            var a = (i << 1) + 1;
            var b = (i << 1) + 2;
            if (b < size && compare(heap[b], heap[a]) < 0) a = b;
            if (compare(heap[a], x) >= 0)
                break;
            heap[i] = heap[a];
            i = a;
        }
        heap[i] = x;
        heap.RemoveAt(size);
        return ret;

    }
    public T Peek() { return heap[0]; }
    public int Count { get { return size; } }
    public bool Any() { return size > 0; }
}
#endregion
