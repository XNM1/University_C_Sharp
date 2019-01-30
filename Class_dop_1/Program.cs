using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_dop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[,] array = ReadArrayFromFile("array.txt");
                ArrayPrint(array);
                Console.WriteLine("-----------------------------------");
                GausGordanoMethod(array);
                ArrayPrint(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void GausMethod(double[,] array, int offset)
        {
            if (array.GetUpperBound(0) + 1 == offset) return;
            if (array[offset, offset] != 1)
            {
                double x = array[offset, offset];
                for (int i = offset; i <= array.GetUpperBound(1); i++)
                {
                    array[offset, i] /= x;
                }
            }
            for (int i = offset; i <= array.GetUpperBound(0) - 1; i++)
            {
                double x = array[i + 1, offset];
                for (int j = offset; j <= array.GetUpperBound(1); j++)
                {
                    array[i + 1, j] -= x * array[offset, j];
                }
            }
            GausMethod(array, ++offset);
        }

        static void GordanoMethod(double[,] array, int offset)
        {
            if (offset == 0) return;
            if (array[offset, offset] != 1)
            {
                double x = array[offset, offset];
                for (int i = offset; i <= array.GetUpperBound(1); i++)
                {
                    array[offset, i] /= x;
                }
            }
            for (int i = offset; i > 0; i--)
            {
                double x = array[i - 1, offset];
                for (int j = offset; j <= array.GetUpperBound(1); j++)
                {
                    array[i - 1, j] -= x * array[offset, j];
                }
            }
            GordanoMethod(array, --offset);
        }

        static void GausGordanoMethod(double[,] array)
        {
            GausMethod(array, 0);
            GordanoMethod(array, array.GetUpperBound(0));
        }

        static void ArrayPrint(double[,] array)
        {
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    Console.Write("{0, 6:N1} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        static double[,] ReadArrayFromFile(string path)
        {
            string array;
            using (StreamReader reader = new StreamReader(path))
            {
                array = reader.ReadToEnd();
            }
            string[] rows = array.Split('\n');
            double[,] matrix = new double[rows.Length, rows.Length + 1];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] colons = rows[i].Split(' ');
                if (colons.Length > rows.Length + 1)
                    throw new Exception("Неверный формат матрицы");
                for (int j = 0; j < colons.Length; j++)
                {
                    double col;
                    if (double.TryParse(colons[j], out col))
                        matrix[i, j] = col;
                    else
                        throw new Exception("Матрица не найдена");
                }
            }
            return matrix;
        }
    }
}
