using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void GetParamsCube(double a, out double s, out double v)
        {
            s = 6 * a * a;
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsCube(a, out s, out v);
            Console.WriteLine("Площадь поверхности куба: {0:.00}", s);
            Console.WriteLine("Объем куба: {0:.00}", v);
            Console.ReadKey();
        }
    }
}
