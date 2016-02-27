using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int child = int.Parse(str[0]);
            int candy = int.Parse(str[1]);
            string[] candystr = Console.ReadLine().Split(' ');
            Queue<int> childque = new Queue<int>();
            Queue<int> candyque = new Queue<int>();
            for (int i = 1; i <= child; i++)
            {
                childque.Enqueue(i);
                candyque.Enqueue(int.Parse(candystr[i-1]));
            }
            for(;;)
            {
                int nowchild = childque.Dequeue();
                int nowcandy = candyque.Dequeue() - candy;
                if (nowcandy > 0)
                {
                    childque.Enqueue(nowchild);
                    candyque.Enqueue(nowcandy);
                }
                if (candyque.Count() == 0)
                {
                    Console.WriteLine(nowchild);
                    return;
                }
            }
        }
    }
}
