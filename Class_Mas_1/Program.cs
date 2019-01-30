using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Mas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            string sRows = Console.ReadLine();
            int rows = int.Parse(sRows);

            int[][] arr = GetTrianglArray(rows);
            FillTrianglPascal(arr);
            ArrayPrint(arr);
            Console.ReadKey();
        }

        static void FillTrianglPascal(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i > 1 && j > 1)
                        arr[i][j] = arr[i - 1][j] + arr[i - 1][j - 1];
                    else
                        arr[i][i] = 1;
                }
            }
        }

        static void ArrayPrint(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0, -9}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }

        static int[][] GetTrianglArray(int rows)
        {
            int[][] arrTriangl = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                arrTriangl[i] = new int[i + 1];
            }
            return arrTriangl;
        }
    }
}
