using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_3
{
    enum Functions
    {
        Linear = 0,
        Square,
        NonLinear
    }

    public static class Function
    {
        public static double LinearFunction(double x)
        {
            return 6 - (0.5 * x);
        }

        public static double SquareFunction(double x)
        {
            return 0.3 * Math.Pow(x - 2, 2) + 1;
        }

        public static double NonLinearFunction(double x)
        {
            return 1.5 * Math.Cos((2 * x) + 1);
        }
    }
}
