using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            list.Sort();

            var diffs = new List<int>();
            for (var i = 1; i < m; i++)
            {
                diffs.Add(list[i] - list[i - 1]);
            }
            diffs.Sort((a, b) => b - a);

            var result = 0;
            for (var i = n - 1; i < m - 1; i++)
            {
                result += diffs[i];
            }

            Console.WriteLine(result);
        }
    }
}
