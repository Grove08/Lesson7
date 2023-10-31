using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double area1 = CalculateTriangleArea(x1, y1, z1);

            Console.WriteLine("Введите длины сторон второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double area2 = CalculateTriangleArea(x2, y2, z2);

            if (area1 > area2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (area1 < area2)
                Console.WriteLine("Площаль второго треугольника больше");
            else
                Console.WriteLine("Площади равны");
            Console.ReadKey();

        }
    }
}
