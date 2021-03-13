using System;
using System.Collections.Generic;
using System.Linq;

namespace B326
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 100, 400, 300, 1200, 600};
            List<int> price = new List<int>();
            // 500以上の値を格納
            foreach(int p in n)
            {
                if(p > 500)
                {
                    price.Add(p);
                }
            }

            // 上記をLINQを利用して記述
            // 500以下の値を取り出し、新しい配列を作成
            var lowPrice = n.Where(n => n <= 500);


            // 全ての値を90ずつ下げる
            // List<int> downPrice = new List<int>();
            var downPrice = n.Select(n => n - 90);
            foreach(int p in downPrice)
            {
                Console.WriteLine(p);
            }
        }
    }
}
