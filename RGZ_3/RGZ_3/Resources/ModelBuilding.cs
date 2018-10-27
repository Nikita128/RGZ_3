using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_3
{
    public class ModelBuilding
    {
        public ModelBuilding(double delta, CoreType core)
        {
            Delta = delta;
            Core = core;
        }

        public enum CoreType
        {
            Recatangle = 0,
            Triangle,
            Parabola,
            Cube
        }

        public double B { get; set; }
        public double Delta { get; set; }
        public CoreType Core { get; set; }

        public double CoreFunction(double x, double xi)
        {
            double z = B * ((x - xi) / Delta);

            switch (Core)
            {
                case CoreType.Recatangle:
                    if (Math.Abs(z) <= 1)
                        return 0.5;
                    else return 0;

                case CoreType.Triangle:
                    if (Math.Abs(z) <= 1)
                        return 1 - Math.Abs(z);
                    else return 0;

                case CoreType.Parabola:
                    if (Math.Abs(z) <= 1)
                        return 0.75 * (1 - Math.Pow(z, 2));
                    else return 0;

                case CoreType.Cube:
                    if (Math.Abs(z) <= 1)
                        return (1 + 2 * Math.Abs(z)) * Math.Pow(1 - Math.Abs(z), 2);
                    else return 0;

                default:
                    return 0;
            }
        }
    }
}
