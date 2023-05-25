using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class TrigonometryClass
    {
            public static double Sin(double a)
            {
                return Math.Sin(a);
            }
            public static double Cos(double a)
            {
                return Math.Cos(a);
            }
            public static double Tg(double a)
            {
                return Math.Tan(a);
            }
            public static double Ctg(double a)
            {
                return Math.Cos(a) / Math.Sin(a);
            }
            public static double ArcSin(double a)
            {
                return Math.Asin(a);
            }
    }
        
}


