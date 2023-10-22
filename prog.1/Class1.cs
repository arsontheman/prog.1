using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog._1
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;
        private double f1(double x)
        {
            return x = Math.Cos(Math.Pow(x, 3) - 4 * x + 4) / (Math.Pow(x, 3) - Math.Log(Math.Abs(x) + 1));
        }
        private double f2(double x)
        {
            return Math.Sin(Math.Pow(x + 2, 2)) / Math.Pow(2 * Math.Pow(x, 2) + Math.Pow(x, 4) + 1, 1.0 / 3.0);
        }
        private double f3(double x)
        {
            return (Math.Sqrt(Math.Abs(Math.Pow(x, 3))) * Math.Sin(Math.Pow(x, 3))) / Math.Pow(Math.Cos(x + 1), 2);
        }
        public void tab(double xn = -2.25, double xk = 34.9, double h = 0.1, double a = 0.5)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                        y = f3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
