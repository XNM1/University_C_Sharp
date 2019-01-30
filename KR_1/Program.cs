using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_1
{
    class Program
    {
        delegate double FunctionDelegate(int x);

        static void Main(string[] args)
        {
            Console.Write("Enter count of elements: ");
            string sLength = Console.ReadLine();
            int length = int.Parse(sLength);
            double[] array = GetArray(Function, length);
            ArrayPrint(array);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            double sum = GetArraySum(array, 2, 4);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Evens: ");
            double[] evens = array.Where(x => x % 2 == 0).ToArray();
            ArrayPrint(evens);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Reverse: ");
            double[] revrs = array.Reverse().ToArray();
            ArrayPrint(revrs);
            Console.ReadKey();
        }

        static double[] GetArray(FunctionDelegate f, int length)
        {
            double[] array = new double[length];
            for (int i = 0; i < length; i++)
			{
                array[i] = f(i);
			}
            return array;
        }

        static void ArrayPrint(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write("{0}\t", item);
            }
        }

        static double Function(int x)
        {
            return (double)(2 * x - 1) * (1 << x);
        }

        static double GetArraySum(double[] array, int n, int k)
        {
            if (array.Length <= k) return 0;
            double sum = 0;
            for (int i = n; i <= k; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
