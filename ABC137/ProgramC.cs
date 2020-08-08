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
            var dic = new Dictionary<string, long>();
            for (var i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Select(x => x.ToString()).ToList();
                s.Sort();
                var ss = string.Join("", s);
                if (dic.ContainsKey(ss))
                    dic[ss]++;
                else
                    dic.Add(ss, 1);
            }

            // Console.WriteLine(string.Join(",", dic.Values));

            var result = 0L;
            foreach (var d in dic)
            {
                result += comb(d.Value, 2);
            }

            Console.WriteLine(result);
        }

        static long comb(long n, long r)
        {
            var p = fact(n, n - r + 1);
            return p / fact(r);
        }

        static long fact(long s, long e = 0)
        {
            if (s == e)
            {
                return Math.Max(s, 1);
            }
            return s * fact(s - 1, e);
        }
    }
}
