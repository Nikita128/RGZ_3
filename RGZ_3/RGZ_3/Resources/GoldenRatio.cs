using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_3
{
    public class GoldenRatio
    {
        public int N { get; set; }
        public double R { get; set; }

        private Dictionary<double, double> obj;
        private ModelBuilding modelData;

        public GoldenRatio(Dictionary<double, double> obj, ModelBuilding modelData)
        {
            this.obj = obj;
            this.modelData = modelData;
        }

        private double Function(double x)
        {
            double coreXN, reg, temp = 0;
            for (int i = 0; i < obj.Count; i++)
            {
                coreXN = 0;
                reg = 0;

                foreach (var elem in obj)                
                    coreXN += modelData.CoreFunction(obj.ElementAt(i).Key, elem.Key);
                
                for (int j = 0; j < obj.Count; j++)                
                    reg += (modelData.CoreFunction(obj.ElementAt(i).Key, obj.ElementAt(j).Key) / coreXN) * obj.ElementAt(j).Value;

                temp += Math.Pow(obj.ElementAt(i).Value - reg, 2);
            }

            return temp / obj.Count;            
        }

        public double FindMin(double acc, double a0, double b0)
        {
            double a = 0, b = 0, l = 0, y = 0, z = 0, fy = 0, fz = 0, delta = 0, x = 0;

            R = 0; N = 0;

            int step = 1;

            while (true)
            {
                switch (step)
                {
                    case 1:
                        a = a0;
                        b = b0;

                        if (acc > 0)
                            l = acc;
                        else
                            return -1;

                        step = 2;
                        break;

                    case 2:
                        y = a + ((3.0 - Math.Sqrt(5)) / 2) * (b - a);
                        z = a + b - y;

                        step = 3;
                        break;

                    case 3:
                        fy = Function(y);
                        fz = Function(z);

                        step = 4;
                        break;

                    case 4:
                        if (fy <= fz)
                        {
                            b = z;
                            z = y;
                            y = a + b - y;
                        }
                        else if (fy > fz)
                        {
                            a = y;
                            y = z;
                            z = a + b - z;
                        }

                        step = 5;
                        break;

                    case 5:
                        delta = Math.Abs(a - b);

                        if (delta <= l)
                        {
                            x = (a + b) / 2;
                            R = Math.Pow(0.618, N - 1);
                            return x;
                        }
                        else
                        {
                            step = 3;
                            break;
                        }

                }
            }
        }
    }
}
