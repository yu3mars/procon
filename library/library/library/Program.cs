using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region StreamScanner
    /// <summary>
    /// 入力
    /// </summary>
    public class StreamScanner
    {
        public StreamScanner(Stream stream) { str = stream; }
        private readonly Stream str;
        private readonly byte[] buf = new byte[1024];
        private int len, ptr;
        public bool isEof = false;
        public bool IsEndOfStream { get { return isEof; } }
        private byte read()
        {
            if (isEof) throw new EndOfStreamException();
            if (ptr >= len)
            {
                ptr = 0;
                if ((len = str.Read(buf, 0, 1024)) <= 0)
                {
                    isEof = true;
                    return 0;
                }
            }
            return buf[ptr++];
        }
        public char Char()
        {
            byte b = 0;
            do b = read();
            while (b < 33 || 126 < b);
            return (char)b;
        }
        public string Scan()
        {
            var sb = new StringBuilder();
            for (var b = Char(); b >= 33 && b <= 126; b = (char)read())
                sb.Append(b);
            return sb.ToString();
        }
        public long Long()
        {
            long ret = 0; byte b = 0; var ng = false;
            do b = read();
            while (b != '-' && (b < '0' || '9' < b));
            if (b == '-') { ng = true; b = read(); }
            for (; true; b = read())
            {
                if (b < '0' || '9' < b)
                    return ng ? -ret : ret;
                else ret = ret * 10 + b - '0';
            }
        }
        public int Integer() { return (int)Long(); }
        public double Double() { return double.Parse(Scan(), CultureInfo.InvariantCulture); }
    }
    #endregion

    #region PriorityQueue<T>
    /// <summary>
    /// 優先度付きキュー
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class PriorityQueue<T>
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

    #region Deque<T>
    /// <summary>
    /// デキュー
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Deque<T>
    {
        T[] buf;
        int offset, count, capacity;
        public int Count { get { return count; } }
        public Deque(int cap) { buf = new T[capacity = cap]; }
        public Deque() { buf = new T[capacity = 16]; }
        public T this[int index]
        {
            get { return buf[getIndex(index)]; }
            set { buf[getIndex(index)] = value; }
        }
        private int getIndex(int index)
        {
            if (index >= capacity)
                throw new IndexOutOfRangeException("out of range");
            var ret = index + offset;
            if (ret >= capacity)
                ret -= capacity;
            return ret;
        }
        public void PushFront(T item)
        {
            if (count == capacity) Extend();
            if (--offset < 0) offset += buf.Length;
            buf[offset] = item;
            ++count;
        }
        public T PopFront()
        {
            if (count == 0)
                throw new InvalidOperationException("collection is empty");
            --count;
            var ret = buf[offset++];
            if (offset >= capacity) offset -= capacity;
            return ret;
        }
        public void PushBack(T item)
        {
            if (count == capacity) Extend();
            var id = count++ + offset;
            if (id >= capacity) id -= capacity;
            buf[id] = item;
        }
        public T PopBack()
        {
            if (count == 0)
                throw new InvalidOperationException("collection is empty");
            return buf[getIndex(--count)];
        }
        public void Insert(int index, T item)
        {
            if (index > count) throw new IndexOutOfRangeException();
            this.PushFront(item);
            for (int i = 0; i < index; i++)
                this[i] = this[i + 1];
            this[index] = item;
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();
            var ret = this[index];
            for (int i = index; i > 0; i--)
                this[i] = this[i - 1];
            this.PopFront();
            return ret;
        }
        private void Extend()
        {
            T[] newBuffer = new T[capacity << 1];
            if (offset > capacity - count)
            {
                var len = buf.Length - offset;
                Array.Copy(buf, offset, newBuffer, 0, len);
                Array.Copy(buf, 0, newBuffer, len, count - len);
            }
            else Array.Copy(buf, offset, newBuffer, 0, count);
            buf = newBuffer;
            offset = 0;
            capacity <<= 1;
        }
        public T[] Items//デバッグ時に中身を調べるためのプロパティ
        {
            get
            {
                var a = new T[count];
                for (int i = 0; i < count; i++)
                    a[i] = this[i];
                return a;
            }
        }
    }
    #endregion

    #region HashMap<K, V> : Dictionary<K, V>
    /// <summary>
    /// 例外処理をされたDictionary
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
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

}
