using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static int _n;
        static int _k;
        static int[,] _list;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            _n = int.Parse(inputs[0]);
            _k = int.Parse(inputs[1]);

            _list = new int[_n, _k];
            for (var i = 0; i < _n; i++)
            {
                var l = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
                for (var j = 0; j < _k; j++)
                {
                    _list[i, j] = l[j];
                }
            }

            var result = false;


            for (var i = 0; i < _k; i++)
            {
                // Console.WriteLine(string.Format("{0}, {1}, {2}", 0, _list[0, i], _list[0, i]));
                if (dfs(0, _list[0, i]))
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(result ? "Found" : "Nothing");
        }

        static bool dfs(int depth, int value, string ind = "  ")
        {
            if (depth == _n - 1)
            {
                return value == 0;
            }

            for (var i = 0; i < _k; i++)
            {
                // Console.WriteLine(string.Format(ind + "{0}, {1}, {2}", depth + 1, _list[depth + 1, i], value ^ _list[depth + 1, i]));
                if (dfs(depth + 1, value ^ _list[depth + 1, i], ind + "  "))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
