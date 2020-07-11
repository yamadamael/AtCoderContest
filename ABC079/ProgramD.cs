using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static int[][] _graph;
        static int[] _costList;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var h = long.Parse(inputs[0]);
            var w = long.Parse(inputs[1]);

            // グラフ作成
            _graph = new int[10][];
            for (var i = 0; i < 10; i++)
            {
                _graph[i] = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            }

            // dfsで変換コスト表作成
            _costList = Enumerable.Range(0, 10).Select(x => _graph[x][1]).ToArray();
            for (var i = 0; i < 10; i++)
            {
                if (i == 1) continue;
                dfs(i, 0, i, "");
                // Console.WriteLine(i + ": " + _costList[i]);
            }

            // 変換
            var result = 0;
            for (var i = 0; i < h; i++)
            {
                var wall = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
                for (var j = 0; j < w; j++)
                {
                    if (wall[j] == -1 || wall[j] == 1) continue;
                    result += _costList[wall[j]];
                }
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// dfs
        /// </summary>
        /// <param name="v">見ている頂点</param>
        /// <param name="dist">累計距離</param>
        /// <param name="target">起点(再帰中は不変)</param>
        /// <param name="path">通過したパス</param>
        /// <param name="ind">デバッグ用インデント</param>
        static void dfs(int v, int dist, int target, string path, string ind = "")
        {
            // Console.WriteLine(ind + "v: " + v + ", dist: " + dist);
            path += v.ToString();

            // 距離更新
            if (v == 1)
            {
                _costList[target] = Math.Min(_costList[target], dist);
                // Console.WriteLine(ind + "_costList[" + target + "]: " + _costList[target] + ", dist: " + dist);
                return;
            }

            // 各変換パターンを探索
            for (var i = 0; i < 10; i++)
            {
                // 同数の変換 || 1以外の通過済みはスキップ
                if (i == v || (i != 1 && path.Contains(i.ToString()))) continue;
                var nextCost = _graph[v][i];

                // 設定済みコストを超えなければ(安くなる見込みがあれば)探索
                if (_costList[target] > dist + nextCost)
                {
                    dfs(i, dist + nextCost, target, ind + "  ", path);
                }
            }
        }
    }
}
