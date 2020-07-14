using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    struct Robot
    {
        public int s;
        public int t;
    }
    class ProgramB
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var robo = new List<Robot>();
            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                var x = int.Parse(inputs[0]);
                var l = int.Parse(inputs[1]);

                robo.Add(new Robot() { s = x - l, t = x + l });
            }

            robo.Sort((a, b) => a.t - b.t);

            var result = 1;
            var prev = 0;

            for (var i = 1; i < n; i++)
            {
                var r = robo[i];
                var p = robo[prev];
                if (p.t <= r.s && p.s <= r.t)
                {
                    result++;
                    prev = i;
                }
            }

            Console.WriteLine(result);
        }
    }
}
