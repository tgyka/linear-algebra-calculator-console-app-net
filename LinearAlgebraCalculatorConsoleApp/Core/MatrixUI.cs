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

                if(numbers.Length != rowCount)
                {
                    Console.WriteLine("Invalid matrix decleration");
                    CreateMatrix(rowCount);
                }

                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix.SetValue(i, j, Double.Parse(numbers[j]));
                }
            }

            Console.Write("Enter result column numbers by top down (Ex: '3,4,5'): ");
            var resultNumbers = Console.ReadLine().Split(",");

            if (resultNumbers.Length != rowCount)
            {
                throw new Exception(String.Format("Please write {0} number with comma", rowCount));
            }

            for (int j = 0; j < resultNumbers.Length; j++)
            {
                matrix.SetValue(j, rowCount, Double.Parse(resultNumbers[j]));
            }

            DoCalculation(matrix);
        }

        private static void DoCalculation(Matrix matrix)
        {
            Console.WriteLine("Which calculation ?");
            var calType = Console.ReadLine().ToLower();
            switch (calType)
            {
                case "transpose":
                    var transpose = matrix.Transpose();
                    break;
                case "gauss":
                    var gauss = matrix.GaussElimination();
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
