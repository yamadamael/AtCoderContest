// 2解答したが文字列結合でTLEしてただけで、どちらの解答もACできる

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            // var b = new List<int>();
            // var l = a.Count % 2 == 0;
            // for (var i = 0; i < n; i++)
            // {
            //     if ((i % 2 == 0 && l) || (i % 2 == 1 && !l))
            //         b.Add(a[i]);
            //     else
            //         b.Insert(0, a[i]);
            // }

            var b = new int[n];
            var l = a.Count % 2 == 0;
            int begin = 0, end = b.Length - 1;
            for (var i = n - 1; i >= 0; i--)
            {
                var ind = 0;
                if ((i % 2 == 0 && l) || (i % 2 == 1 && !l))
                    ind = end--;
                else
                    ind = begin++;

                b[ind] = a[i];
            }

            Console.WriteLine(string.Join(' ', b));
        }
    }
}
