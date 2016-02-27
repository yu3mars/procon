using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2369
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chr = Console.ReadLine().ToCharArray();
            string[] str = new string[chr.Length];
            for (int i = 0; i < chr.Length; i++)
            {
                str[i] = chr[i].ToString();
            }
            Stack<string> stk = new Stack<string>();
            bool end = false;
                        
            for (int i = 0; i < chr.Length; i++)
            {
                if(str[i] == "m")
                {
                    stk.Push("m");
                    if (end == true)
                    {
                        Console.WriteLine("Rabbit");
                        return;
                    }
                }
                else if(str[i] =="e")
                {
                    if (stk.Count == 0)
                    {
                        Console.WriteLine("Rabbit");
                        return;
                    }
                    if(stk.Pop() == "m")
                    {
                        stk.Push("e");
                    }
                    else
                    {
                        Console.WriteLine("Rabbit");
                        return;
                    }
                }
                else if(str[i] =="w")
                {
                    if (stk.Count == 0)
                    {
                        Console.WriteLine("Rabbit");
                        return;
                    }
                    if(stk.Pop() =="e")
                    {
                        if (stk.Count == 0)
                        {
                            end = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Rabbit");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Rabbit");
                    return;
                }
            }
            if (stk.Count==0)
            {
                    Console.WriteLine("Cat");

            }
            else
            {
                    Console.WriteLine("Rabbit");
            }
        }
    }
}
