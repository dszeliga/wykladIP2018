using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RownaniaKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = 1;
            b = 4;
            c = -5;

            double delta = b * b - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine("Pierwiastki to: {0} i {1}", x1,x2);
            Console.ReadKey();
        }
    }
}
