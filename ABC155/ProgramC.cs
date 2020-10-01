using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var dic = new Dictionary<string, int>();
            var max = 0;
            for (var i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                if (dic.ContainsKey(s))
                {
                    dic[s]++;
                }
                else
                {
                    dic.Add(s, 1);
                }
                max = dic[s] > max ? dic[s] : max;
            }

            var filter = dic.Where((x) => x.Value == max);
            filter = filter.OrderBy(x => x.Key);

            foreach (var f in filter)
            {
                Console.WriteLine(f.Key);
            }
        }
    }
}
