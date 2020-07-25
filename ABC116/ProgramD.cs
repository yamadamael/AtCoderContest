using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        struct Sushi
        {
            public int t;
            public int d;
        }
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var k = long.Parse(inputs[1]);

            var list = new List<Sushi>();
            for (var i = 0; i < n; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var t = int.Parse(inputs1[0]);
                var d = int.Parse(inputs1[1]);
                var s = new Sushi() { t = t, d = d, };
                list.Add(s);
            }

            list.Sort((a, b) => a.d - b.d);

            var result = 0;


            Console.WriteLine(result);
        }

    }
}
