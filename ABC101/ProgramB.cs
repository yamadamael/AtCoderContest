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
            var n = int.Parse(s);
            var sn = 0L;

            for (var i = 0; i < s.Length; i++)
            {
                sn += int.Parse(s[i].ToString());
            }

            var result = n % sn == 0 ? "Yes" : "No";
            Console.WriteLine(result);
        }
    }
}
