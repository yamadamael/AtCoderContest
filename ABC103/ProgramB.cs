using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            var result = false;

            s += s;

            for (var i = 0; i < t.Length; i++)
            {
                var r = s.Substring(i, t.Length);
                if (r == t)
                {
                    result = true;
                }
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
