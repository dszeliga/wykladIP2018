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
            a = 2;
            b = 0;
            c = -8;

            double delta = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("Równanie linowe, x={0}", -c / b);
            }
            else if (delta >= 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Pierwiastki to: {0} i {1}", x1, x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Brak rozwiazan w dziedzinie R");
            }


        }
    }
}
