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
            var list = new List<(int, int)>();
            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                list.Add((int.Parse(inputs[0]), int.Parse(inputs[1])));
            }

            var result = true;

            list = list.OrderBy(a => a.Item2).ToList();

            var time = 0;
            for (var i = 0; i < n; i++)
            {
                time += list[i].Item1;
                if (time > list[i].Item2)
                {
                    result = false;
                    break;
                }
            }

            Console.WriteLine(result ? "Yes" : "No");
        }

    }
}
