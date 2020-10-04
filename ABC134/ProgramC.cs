using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var a = new List<int>();
            for (var i = 0; i < n; i++)
            {
                var ai = int.Parse(Console.ReadLine());
                a.Add(ai);
            }

            var b = a.OrderBy(x => x).ToList();

            var last1 = b[b.Count - 1];
            var last2 = b[b.Count - 2];

            for (var i = 0; i < n; i++)
            {
                var result = a[i] == last1 ? last2 : last1;
                Console.WriteLine(result);
            }
        }
    }
}
