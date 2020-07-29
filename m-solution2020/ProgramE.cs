using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramE
    {

        static (int, int, int)[] _list;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            _list = new (int, int, int)[n];
            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                var x = int.Parse(inputs[0]);
                var y = int.Parse(inputs[1]);
                var p = int.Parse(inputs[2]);
                _list[i] = (x, y, p);
            }

            var result = 0;

            Console.WriteLine(result);
        }

        // 0 none
        // 1 hori
        // 2 vart
        static int _m = 3;
        static void dfs(Stack<int> l, int n)
        {
            if (n <= l.Count)
            {
                for (var i = 0; i < l.Count; i++)
                {

                }
            }

            for (var i = 0; i < _m; i++)
            {
                l.Push(i);
                dfs(l, n);
                l.Pop();
            }
        }
    }
}
