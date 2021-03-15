using System;
using System.Collections.Generic;
using System.Linq;

namespace EP326
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { -1, -10, -5, -40, -15};
            // n配列の全ての要素数を１０増やし、その結果０以上となる要素数の個数を求める
            int i = n.Select(n => n +10).Where(n => n >= 0).Count();
            Console.WriteLine(i + "個");
        }
    }
}
