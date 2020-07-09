using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static bool[,] _seen;
        static int[] _dx = new int[] { 0, 1, 0, -1 };
        static int[] _dy = new int[] { 1, 0, -1, 0 };
        static long _h, _w;
        static string[] _field;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            _h = long.Parse(inputs[0]);
            _w = long.Parse(inputs[1]);

            _field = new string[_h];
            int sh = 0, sw = 0, gh = 0, gw = 0;
            for (var i = 0; i < _h; i++)
            {
                _field[i] = Console.ReadLine();
                for (var j = 0; j < _w; j++)
                {
                    if (_field[i][j] == 's') { sh = i; sw = j; }
                    if (_field[i][j] == 'g') { gh = i; gw = j; }
                }
            }

            _seen = new bool[_h, _w];
            dfs(sh, sw);

            // Console.WriteLine(string.Format("({0},{1}), ({2},{3})", sh, sw, gh, gw));
            Console.WriteLine(_seen[gh, gw] ? "Yes" : "No");
        }

        static void dfs(int h, int w)
        {
            _seen[h, w] = true;
            for (var i = 0; i < 4; i++)
            {
                var nh = h + _dy[i];
                var nw = w + _dx[i];

                // 範囲外
                if (nh < 0 || _h <= nh) continue;
                if (nw < 0 || _w <= nw) continue;

                // 通過済みか
                if (_seen[nh, nw]) continue;

                // .ですか
                if (_field[nh][nw] == '#') continue;

                dfs(nh, nw);
            }
        }
    }
}
