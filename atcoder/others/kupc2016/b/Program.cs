using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nk[0];
            int k = nk[1];
            int[] l = new int[26];
            for (int i = 0; i < n; i++)
            {
                l[(Console.ReadLine()[0] - 'A')]++;
            }
            PriorityQueue<int> pq = new PriorityQueue<int>(CompareAccount);
            for (int i = 0; i < 26; i++)
            {
                if (l[i] > 0) pq.Enqueue(l[i]);
            }
            int ans = 0;
            while (pq.Count >= k)
            {
                List<int> ls = new List<int>();
                for (int i = 0; i < k; i++)
                {
                    ls.Add(pq.Dequeue() - 1);
                }
                for (int i = 0; i < ls.Count; i++)
                {
                    if (ls[i] > 0) pq.Enqueue(ls[i]);
                }
                ans++;
            }
            Console.WriteLine(ans);
        }
        static int CompareAccount(int x, int y)
        {
            if (x > y)
                return -1; // xがyより大きい
            else if (x < y)
                return 1; // xがyより小さい
            else // if (x == y)
                return 0; // xとyが等しい
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
