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
            var result = "";
            for (var i = 0; i < s.Length; i++)
            {
                if (i == 0)
                    result += s[i].ToString().ToUpper();
                else
                    result += s[i].ToString().ToLower();
            }
            Console.WriteLine(result);
        }
    }
}
