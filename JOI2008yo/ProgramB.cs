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
            var joi = 0;
            var ioi = 0;

            for (var i = 2; i < s.Length; i++)
            {
                var t = s.Substring(i - 2, 3);
                if (t == "JOI")
                    joi++;
                else if (t == "IOI")
                    ioi++;
            }

            Console.WriteLine(joi);
            Console.WriteLine(ioi);
        }
    }
}
