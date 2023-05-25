using MyMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Геометрия:");
            Console.WriteLine("Площадь Треугольника");
            Console.WriteLine(GeometryClass.STriangle(3, 7));
            Console.WriteLine("Площадь Прямоугольного треугольника");
            Console.WriteLine(GeometryClass.SRighttriangle(4, 8));
            Console.WriteLine("Площадь Прямоугольника ");
            Console.WriteLine(GeometryClass.SRectangle(7, 2));
            Console.WriteLine("Площадь Круга");
            Console.WriteLine(GeometryClass.SCircle(5));
            Console.WriteLine("Площадь Трапеции");
            Console.WriteLine(GeometryClass.STrapezoid(3, 7, 6));
            Console.WriteLine("Тригонометрия:");
            Console.WriteLine("Синус");
            Console.WriteLine(TrigonometryClass.Sin(3.4));
            Console.WriteLine("Косинус");
            Console.WriteLine(TrigonometryClass.Cos(5));
            Console.WriteLine("Тангенс");
            Console.WriteLine(TrigonometryClass.Tg(6.8));
            Console.WriteLine("Котангенс ");
            Console.WriteLine(TrigonometryClass.Ctg(9));
            Console.WriteLine("АркСинус");
            Console.WriteLine(TrigonometryClass.ArcSin(2));
            Console.WriteLine("Алгебра:");
            Console.WriteLine("Квадратный корень");
            Console.WriteLine(AdgebraClass.SquareRoot(4,7,2));
            Console.WriteLine("Математический корень");
            Console.WriteLine(AdgebraClass.MathRoot(2));
            Console.WriteLine("Сумма ряда");
            Console.WriteLine(AdgebraClass.SumSeries(9,6,3,1));
            Console.WriteLine("Максимальная из ряда");
            Console.WriteLine(AdgebraClass.MassRow(4,2,7,4));
            Console.WriteLine("Средняя значение ряда");
            Console.WriteLine(AdgebraClass.AvgSeries(2,6,4,8));
        }
        
    }
}
