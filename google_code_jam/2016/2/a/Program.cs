using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"A-large.in"))
                {
                    int t = int.Parse(r.ReadLine());
                    for (int i = 0; i < t; i++)
                    {
                        int[] nrps = r.ReadLine().Split().Select(int.Parse).ToArray();
                        string ans = "IMPOSSIBLE";
                        int n = nrps[0];
                        int[] rps = new int[3];
 //                       int[] rps2 = new int[3];
                        for (int j = 0; j < 3; j++)
                        {
                            rps[j] = nrps[j + 1];
                        }
                        
                        for (int j = 0; j < 3; j++)
                        {
                            int[] rpsTest = rpsGo(n, j);
                            bool same = true;
                            for (int k = 0; k < 3; k++)
                            {
                                if(rps[k] != rpsTest[k])
                                {
                                    same = false;
                                    break;
                                }
                            }
                            if(same)
                            {
                                ans = rpsStr(n, j);
//                                rps2 = rpsTest;
                                break;
                            }
                        }
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
//                        w.WriteLine("Case #{0}: {1} , {2}", i + 1, ans , String.Join(" ",rps2));
                    }
                }
            }
        }

        static int[] rpsGo(int n,int rps) //rps
        {
            int[] hand = new int[3];
            hand[rps] = 1;
            for (int j = 0; j < n; j++)
            {
                int[] nextHand = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    nextHand[i] = hand[i] + hand[(i + 1) % 3];
                }
                hand = nextHand;
            }
            return hand;
        }
        
        static string rpsStr(int n, int rps)
        {
            string[] rpss = new string[3] { "R", "P", "S" };
            string hand = rpss[rps];
            for (int j = 0; j < n; j++)
            {
                StringBuilder nextHand = new StringBuilder();
                for (int i = 0; i < hand.Length; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (hand[i].ToString() == rpss[k])
                        {
                            nextHand.Append(rpss[k]);
                            nextHand.Append(rpss[(k + 2) % 3]);
                        }
                    }
                }
                hand = nextHand.ToString();
            }

            for (int i = 0; i < n; i++)
            {
                int tani = 1 << i;
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < hand.Length; j += tani * 2)
                {                    
                    string s1 = hand.Substring(j, tani);
                    string s2 = hand.Substring(j + tani, tani);
                    if(s1.CompareTo(s2)<0)
                    {
                        sb.Append(s1);
                        sb.Append(s2);
                    }
                    else
                    {
                        sb.Append(s2);
                        sb.Append(s1);
                    }
                }
                hand = sb.ToString();
            }
            return hand;
        }


    }
}
