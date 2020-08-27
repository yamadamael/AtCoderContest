using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToList();
            var result = 0;
            var current = s[0];

            for (var i = 0; i < s.Count; i++)
            {
                if(s[i] != current)
                {
                    result++;
                    current = s[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
