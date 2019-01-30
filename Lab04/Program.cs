using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Enter n: ");
            string sn = Console.ReadLine();
            int n = int.Parse(sn);
            double[] arr = GetArray(n);
            ArrayPrint(arr);
            Console.WriteLine();
            double max, min;
            GetMaxMin(arr, out min, out max);
            Console.WriteLine("Min: {0, -9:N3}", min);
            Console.WriteLine("Max: {0, -9:N3}", max);
            double sum = GetSumByArray(arr);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("-----------------------------");
            Console.ReadKey();


            //Console.Write("Enter n1: ");
            //string sn1 = Console.ReadLine();
            //int n1 = int.Parse(sn1);

            //Console.Write("Enter n2: ");
            //string sn2 = Console.ReadLine();
            //int n2 = int.Parse(sn2);

            double[,] arr2 = GetArray();
            ArrayPrint(arr2);
            GetMaxMin(arr2, out min, out max);
            Console.WriteLine("Min: {0, -9:N3}", min);
            Console.WriteLine("Max: {0, -9:N3}", max);
            Console.ReadKey();
        }

        public int ArrayIndexOf(double[] arr, double value)
        {
            int i = 0;
            foreach (double item in arr)
            {
                if (item == value)
                {
                    return i;
                }
                i++;
            }
            return i;
        }

        public static double GetSumByArray(double[] arr)
        {
            double sum = 0;
            double max = arr.Max();
            Array.Sort(arr);
            arr.Reverse();
            for (int i = 0; i < arr.Length && arr[i] <= max * 0.9; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static void ArrayPrint(double[] arr)
        {
            foreach (double item in arr)
            {
                Console.Write("{0, -9:N3}", item);
            }
        }

        public static void ArrayPrint(double[,] arr)
        {

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write("{0, -9:N3}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static double[,] GetArray(int n1, int n2)
        {
            Random rnd = new Random();
            double[,] arr = new double[n1, n2];
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = rnd.Next(100) + rnd.NextDouble();
                }
            }
            return arr;
        }

        public static double[,] GetArray()
        {
            double[,] arr = new double[4, 7];
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    arr[i, j] = Math.Pow(10, i) - Math.Pow(2, j);
                }
            }
            return arr;
        }

        public static double[] GetArray(int n)
        {
            Random rnd = new Random();
            double[] arr = new double[n];
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                arr[i] = rnd.Next(100) + rnd.NextDouble();
            }
            return arr;
        }

        public static void GetMaxMin(double[] arr, out double min, out double max)
        {
            max = arr[0];
            min = arr[0];
            for (int i = arr.GetLowerBound(0) + 1; i <= arr.GetUpperBound(0); i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
        }

        public static void GetMaxMin(double[,] arr, out double min, out double max)
        {
            max = arr[0, 0];
            min = arr[0, 0];
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1) + 1; j <= arr.GetUpperBound(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
        }
    }
}
