using System;
using Accord.Math.Random;

namespace RGZ_3
{
    static public class Statistics
    {
        public static double MeanEstimation(double[] t)
        {
            double est = 0;
            foreach (double x in t)
            {
                est += x;
            }

            return est / t.Length;
        }

        public static double VarianceEstimation(double[] t, double mean)
        {
            double est = 0;
            foreach (double x in t)
            {
                est += Math.Pow(x - mean, 2);
            }

            return Math.Sqrt(est / (t.Length - 1));
        }

        public static double[] MpcGenerator(double m1, double m2, double d1, double d2)
        {
            Random rng = Generator.Random;

            double s = 0, v1 = 0, v2 = 0, x1 = 0, x2 = 0;
            do
            {
                v1 = 2 * rng.NextDouble() - 1;
                v2 = 2 * rng.NextDouble() - 1;
                s = Math.Pow(v1, 2) + Math.Pow(v2, 2);
            }
            while (s >= 1);

            x1 = d1 * v1 * Math.Sqrt((-2.0 * Math.Log(s)) / s) + m1;
            x2 = d2 * v2 * Math.Sqrt((-2.0 * Math.Log(s)) / s) + m2;

            return new double[] { x1, x2 };
        }      

        
    }
}
