using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static string[] _mGraph;
        static string[] _nGraph;

        static int[] _dx = { 1, 0 };
        static int[] _dy = { 0, 1 };

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            _nGraph = new string[n];
            _mGraph = new string[m];
            for (var i = 0; i < n; i++)
                _nGraph[i] = Console.ReadLine();
            for (var i = 0; i < m; i++)
                _mGraph[i] = Console.ReadLine();

            for (var ny = 0; ny <= n - m; ny++)
            {
                for (var nx = 0; nx <= n - m; nx++)
                {
                    if (_nGraph[nx][ny] != _mGraph[0][0]) continue;
                    if (search(nx, ny, m))
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }

            Console.WriteLine("No");
        }

        static bool search(int nx, int ny, int m)
        {
            for (var my = 0; my < m; my++)
            {
                for (var mx = 0; mx < m; mx++)
                {
                    // Console.WriteLine(string.Format("({0},{1})({2},{3})", nx, ny, mx, my));
                    if (_nGraph[ny + my][nx + mx] != _mGraph[my][mx])
                        return false;
                }
            }
            return true;
        }
    }
}
