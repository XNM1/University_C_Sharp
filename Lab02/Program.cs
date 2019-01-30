using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            double xMax, xMin, dx;
            Console.Write("Enter xMin: ");
            string sxMin = Console.ReadLine();
            xMin = double.Parse(sxMin);
            Console.Write("Enter xMax: ");
            string sxMax = Console.ReadLine();
            xMax = double.Parse(sxMax);
            Console.Write("Enter dx: ");
            string sdx = Console.ReadLine();
            dx = double.Parse(sdx);

            Console.WriteLine(" {0,-5}{1,5}", 'x', 'y');
            for (double i = xMin; i <= xMax; i += dx)
            {
                Console.WriteLine("{0, -7:N3} {1, -7:N3}", i, f(i));
            }

            Console.WriteLine("--------------");
            Console.WriteLine(" {0,-5}{1,5}", 'x', 'y');
            double x = xMin;
            while (x <= xMax)
            {
                Console.WriteLine("{0, -7:N3} {1, -7:N3}", x, f(x));
                x += dx;
            }
            Console.ReadKey();
        }
        static double f(double x)
        {
            double c = 1.57;
            if (x > 0)
            {
                return Math.Pow(Math.Sin(x), 2);
            }
            else if (x < 0)
            {
                return Math.Pow(Math.Log(1 + x * x), 3);
            }
            else if (Math.Abs(x) < 1e-7)
            {
                return x + c;
            }
            return 0;
        }
    }
}
