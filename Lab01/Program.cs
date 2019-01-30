using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.825;
            double y = 18.225;
            double z = -3.298;
            double r1 = Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1 / 3));
            double r2 = (y - x) * ((y - z) / (1 + Math.Pow(y - x, 2)));
            Console.WriteLine("Result 1: {0:N4}", r1);
            Console.WriteLine("Result 2: {0:N4}", r2);
            Console.ReadKey();
        }
    }
}
