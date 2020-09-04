using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var list = new Dictionary<string, List<(int, int)>>();

            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                var s = (inputs[0]);
                var p = int.Parse(inputs[1]);

                List<(int, int)> l;
                if (list.ContainsKey(s))
                {
                    l = list[s];
                }
                else
                {
                    l = new List<(int, int)>();
                    list.Add(s, l);
                }
                l.Add((p, i + 1));
            }

            var keys = list.Keys.OrderBy(x => x);

            foreach (var key in keys)
            {
                list[key] = list[key].OrderByDescending((x) => x.Item1).ToList();
            }

            foreach (var k in keys)
            {
                var l = list[k];
                foreach (var x in l)
                {
                    Console.WriteLine(x.Item2);
                }
            }
        }
    }
}
