using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        public delegate double Function(double x);
        public delegate double Integral(double a, double b, double n, Function f);
        static void Main(string[] args)
        {
            bool isExit = false;
            Integral[] inetegralFunc = { IntegTrap, IntegLeftRect, IntegRigthRect };
            while (!isExit)
            {
                Console.WriteLine("1 - Метод трапеций\n2 - Метод левых прямоугольников\n3 - Метод правых прямоугольников");
                string skey = Console.ReadLine();
                int key = int.Parse(skey);
                Console.Write("Введите a: ");
                string sa = Console.ReadLine();
                double a = double.Parse(sa);
                Console.Write("Введите b: ");
                string sb = Console.ReadLine();
                double b = double.Parse(sb);
                Console.Write("Введите n: ");
                string sn = Console.ReadLine();
                double n = double.Parse(sn);
                if ((b - a) < 0 || (key > 3 && key <= 0))
                {
                    Console.WriteLine("Некоректный ввод");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                double Intgrl = 0;
                Intgrl = inetegralFunc[key - 1](a, b, n, G);
                Console.WriteLine("Integral G [{0}, {1}]: {2:0.0000}", a, b, Intgrl);
                Intgrl = inetegralFunc[key - 1](a, b, n, F1);
                Console.WriteLine("Integral F1 [{0}, {1}]: {2:0.0000}", a, b, Intgrl);
                Console.WriteLine("Repeat calculation? (yes/no)");
                string repeatCalc = Console.ReadLine();
                Console.Clear();
                if (repeatCalc == "no")
                {
                    isExit = true;
                }
            }
        }

        static double IntegTrap(double a, double b, double n, Function f)
        {
            double dx = (b - a) / n;
            double x1, x2;
            double Intgrl = 0;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * dx;
                x2 = x1 + dx;

                Intgrl += (f(x1) + f(x2)) / 2 * dx;
            }
            return Intgrl;
        }

        static double IntegLeftRect(double a, double b, double n, Function f)
        {
            double dx = (b - a) / n;
            double x;
            double Intgrl = 0;
            for (int i = 0; i < n; i++)
            {
                x = a + i * dx;
                Intgrl += f(x) * dx;
            }
            return Intgrl;
        }

        static double IntegRigthRect(double a, double b, double n, Function f)
        {
            double dx = (b - a) / n;
            double x;
            double Intgrl = 0;
            for (int i = 0; i < n; i++)
            {
                x = (a + i * dx) + dx;
                Intgrl += f(x) * dx;
            }
            return Intgrl;
        }

        static double G(double z)
        {
            double y = z + 2;
            if (y < 0)
            {
                return Math.Pow(y, 3) - 0.3;
            }
            else if ((0 < y && y < 1) || Math.Abs(y) < 1e-7 || Math.Abs(y - 1) < 1e-7)
            {
                return 0;
            }
            else if (y > 1)
            {
                return y * y + y;
            }
            return 0;
        }
        static double F1(double x)
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
