using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<int>> tr = new List<List<int>>();
            for (int i = 0; i <= n; i++)
            {
                List<int> p = new List<int>();
                tr.Add(p);
            }
            for (int i = 1; i < n; i++)
            {
                string[] ab = Console.ReadLine().Split(' ');
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);
                tr[a].Add(b);
                tr[b].Add(a);
            }
            SortedSet<int> done = new SortedSet<int>();
            PriorityQueue<int> q = new PriorityQueue<int>();
            int cnt = 0;
            q.Enqueue(1);
            while (q.Count > 0)
            {
                int now = q.Dequeue();
                Console.Write(now);
                if (cnt < n - 1)
                {
                    Console.Write(" ");
                    cnt += 1;
                }
                else Console.WriteLine();
                done.Add(now);
                foreach (int next in tr[now])
                    if (done.Contains(next) == false)
                    {
                        q.Enqueue(next);
                    }
                }            
        }
    }

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
}
