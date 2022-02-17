using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public static class Harmonic
    {
        public static void harmonicFunction()

        {
            int n = 5;
            double x = 0.0;

            for (double i = 1; i < n; i++)
            {
                x = x + 1 / i;
            }
            Console.WriteLine(x + "is harmonic value");
        }

    }
}
