using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public static class GeometryClass
    {
        
        public static double STriangle(double a, double b)
            {
                return 0.5 * a * b;
            }

        public static double SRighttriangle(double a, double b)
            {
                return 0.5 * a * b;
            }

        public static double SRectangle(double a, double b)
            {
                return a * b;
            }

        public static double SCircle(double a)
            {
                double Pi = 3.14;
                return Pi * (a*a) ;
            }

        public static double STrapezoid(double a, double b, double h)
            {
                return 0.5 *(a * b) * h;
            }     
    }
}
