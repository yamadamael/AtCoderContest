using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var aList = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToArray();
            var result = 0;

            // ビット落ちがわかればいいから加算を考慮しなくて良い
            var xList = new long[n + 1];
            // var pList = new long[n + 1];

            for (var i = 1; i < n + 1; i++)
            {
                xList[i] = xList[i - 1] + aList[i - 1];
                // pList[i] = pList[i - 1] ^ aList[i - 1];
            }



            Console.WriteLine(result);
        }

    }
}
