using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var list = new string[] { "dream", "dreamer", "erase", "eraser" };

            while (s != "")
            {
                var t = s;
                for (var i = 0; i < 4; i++)
                {
                    if (s.Length - list[i].Length < 0)
                        continue;
                    var sub = s.Substring(s.Length - list[i].Length, list[i].Length);
                    if (sub == list[i])
                    {
                        s = s.Substring(0, s.Length - list[i].Length);
                        // Console.WriteLine(s);
                    }
                }
                if (s == t)
                    break;
            }

            Console.WriteLine(s == "" ? "YES" : "NO");
        }
    }
}
