using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10002
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, area, length;
            string[] str = Console.ReadLine().Split(' ');//2つ以上のスペース区切り入力の取得
            a = int.Parse(str[0]);  //数値で受け取りたい場合は変換する
            b = int.Parse(str[1]);
            area = a * b;
            length = (a + b) * 2;
            Console.WriteLine("{0} {1}", area, length);
        }
    }
}
