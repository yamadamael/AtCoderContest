using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static string[] _graph;
        static bool[,] _seen;

        static int[] _dx = { 0, 1, 0, -1 };
        static int[] _dy = { 1, 0, -1, 0 };

        static void Main(string[] args)
        {
            var count = 0;
            _graph = new string[10];
            var x = 10;
            var y = 10;
            for (var i = 0; i < y; i++)
            {
                _graph[i] = Console.ReadLine();
                count += _graph[i].Count(x => x == 'o');
            }

            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    if (isBetween(j, i))
                    {
                        _seen = new bool[10, 10];
                        // Console.WriteLine(string.Format("{0}, {1}", j, i));
                        if (dfs(j, i, 0) == count + 1)
                        {
                            Console.WriteLine("YES");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("NO");
        }

        static int dfs(int x, int y, int c)
        {
            // Console.WriteLine(string.Format("  {0}, {1}, {2}", x, y, c));
            _seen[y, x] = true;
            c++;

            for (var i = 0; i < 4; i++)
            {
                var nx = x + _dx[i];
                var ny = y + _dy[i];
                if (nx < 0 || 10 <= nx) continue;
                if (ny < 0 || 10 <= ny) continue;
                if (_seen[ny, nx]) continue;
                if (_graph[ny][nx] == 'o')
                    c = dfs(nx, ny, c);
            }
            return c;
        }

        static bool isBetween(int x, int y)
        {
            if (_graph[y][x] == 'o') return false;
            var count = 0;
            for (var i = 0; i < 4; i++)
            {
                var nx = x + _dx[i];
                var ny = y + _dy[i];
                if (nx < 0 || 10 <= nx) continue;
                if (ny < 0 || 10 <= ny) continue;
                if (_graph[ny][nx] == 'o')
                    count++;
            }

            return count >= 2;
        }
    }
}
