using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static List<int> _s = new List<int>();
        static int _mod = 998244353;
        static int _n;
        static long _result;

        static void dfs(int sum, string st = "")
        {
            Console.WriteLine(st + "sum: " + sum);
            if (sum == _n)
            {
                _result++;
                _result %= _mod;
                // Console.WriteLine(_result);
            }
            if (sum >= _n)
            {
                return;
            }

            foreach (var s in _s)
            {
                dfs(sum + s, st + " ");
            }
        }

        static void Main(string[] args)
        {

            var inputs = Console.ReadLine().Split(" ");
            _n = int.Parse(inputs[0]) - 1;
            var k = long.Parse(inputs[1]);

            for (var i = 0; i < k; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                _s.Add(int.Parse(inputs1[0]));
                _s.Add(int.Parse(inputs1[1]));
            }
            _s = _s.Distinct().ToList();

            dfs(0);
            Console.WriteLine(_result);
        }
    }
}
