using System;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 0L;

            for (var i = 1; i <= n; i++)
            {
                // var y = yakusu2(i);
                // // Console.WriteLine(i + ", " + y);
                // result += y * i;

                // 純粋に約数を求めるのと同じ計算で約数の個数を求めると処理速度的に追いつかない
                // nまでの値をiで割りきれた場合、iを加算する方式にする
                // (この方法は約数そのものはわからないが個数は取得できる)
                result += i * sumI(n / i);
            }

            Console.WriteLine(result);
        }

        // 約数の個数を求める O(N)
        // static int yakusu(int n)
        // {
        //     var count = 0;
        //     for (var i = 1; i <= n; i++)
        //     {
        //         if (n % i == 0)
        //         {
        //             count++;
        //         }
        //     }
        //     return count;
        // }

        // 約数の個数を求める O(sqrt(N))
        // static int yakusu2(int n)
        // {
        //     var count = 0;
        //     for (var i = 1; i * i <= n; i++)
        //     {
        //         if (n % i == 0)
        //         {
        //             count++;
        //             if (i * i != n)
        //                 count++;
        //         }
        //     }
        //     return count;
        // }

        // 総和
        static long sumI(long i)
        {
            return (i * (i + 1)) / 2;
        }
    }
}
