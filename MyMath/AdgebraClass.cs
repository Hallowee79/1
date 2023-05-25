using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class AdgebraClass
    {
        public static double SquareRoot(double a, double b, double c)
        {
            double D;
            double x1;
            double x2;
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return x1;

            }
            else
            {
                return 1;
            }

        }

        public static double MathRoot(double a)
        {
            return Math.Sqrt(a);

        }
        public static double SumSeries(double a, double b, double a1, double b1)
        {
            return a + b + a1 + b1;
        }
        public static double MassRow(double a, double b, double a1, double b1)
        {
            if (a < b && b > a1 && b > b1)
            {
                return b;
            }
            else if (b < a && a > a1 && a > b1)
            {
                return a;
            }
            else if (b < a1 && a1 > a && a1 > b1)
            {
                return a1;
            }
            else
            {
                return b1;
            }
        }
        public static double AvgSeries(double a, double b, double a1, double b1)
        {
            return (a + b + a1 + b1) / 4;
        }
    }
}

