using LinearAlgebraCalculatorConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraCalculatorConsoleApp.Core
{
    public class MatrixUI
    {
        public static void UI()
        {
            Console.Write("Please enter matrix row count: ");
            int rowCount;

            if (int.TryParse(Console.ReadLine(), out rowCount))
            {
                CreateMatrix(rowCount);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

            UI();
        }

        private static void CreateMatrix(int rowCount)
        {
            var matrix = new Matrix(rowCount, rowCount + 1, MatrixType.None);
            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("Enter {0} row numbers with a comma (Ex: '3,4,5'): ",(i+1));
                var numbers = Console.ReadLine().Split(",");
                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix.Value[i, j] = Double.Parse(numbers[j]);
                }
            }

            DoCalculation(matrix);
        }

        private static void DoCalculation(Matrix matrix)
        {
            Console.WriteLine("Which calculation ?");
            var calType = Console.ReadLine();
            switch (calType)
            {
                case "transpose":
                    var transpose = matrix.Transpose();
                    transpose.Write();
                    break;
                case "gauss":
                    var gauss = matrix.GaussElimination();
                    gauss.Write();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
