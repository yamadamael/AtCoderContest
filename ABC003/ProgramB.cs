using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();

            var result = true;
            for (var i = 0; i < s.Length; i++)
            {
                if (!canConvert(s[i], t[i]))
                {
                    result = false;
                    break;
                }
            }
            Console.WriteLine(result ? "You can win" : "You will lose");
        }

        static bool canConvert(char s, char t)
        {
            if (s == t)
            {
                return true;
            }

            if (s == '@' || t == '@')
            {
                var c = s == '@' ? t : t == '@' ? s : 'z';

                switch (c)
                {
                    case 'a':
                    case 't':
                    case 'c':
                    case 'o':
                    case 'd':
                    case 'e':
                    case 'r':
                        return true;
                }
            }
            return false;
        }
    }
}
