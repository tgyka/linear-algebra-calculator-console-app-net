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
            Console.Write(ConstMessages.EnterMatrixCount);
            int rowCount;

            if (int.TryParse(Console.ReadLine(), out rowCount))
            {
                CreateMatrix(rowCount);
            }
            else
            {
                Console.WriteLine(ConstMessages.EnterValidNumber);
            }

            UI();
        }

        private static void CreateMatrix(int rowCount)
        {
            var matrix = new Matrix(rowCount, rowCount + 1, MatrixType.None);
            for (int i = 0; i < rowCount; i++)
            {
                Console.Write(ConstMessages.EnterRowNumbers, (i+1));
                var numbers = Console.ReadLine().Split(",");

                if(numbers.Length != rowCount)
                {
                    Console.WriteLine(ConstMessages.InvalidMatrixDecleration);
                    CreateMatrix(rowCount);
                }

                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix.SetValue(i, j, Double.Parse(numbers[j]));
                }
            }

            Console.Write(ConstMessages.EnterResultColumnNumbers);
            var resultNumbers = Console.ReadLine().Split(",");

            if (resultNumbers.Length != rowCount)
            {
                throw new Exception(String.Format(ConstMessages.WriteNumberWithComma, rowCount));
            }

            for (int j = 0; j < resultNumbers.Length; j++)
            {
                matrix.SetValue(j, rowCount, Double.Parse(resultNumbers[j]));
            }

            DoCalculation(matrix);
        }

        private static void DoCalculation(Matrix matrix)
        {
            Console.WriteLine(ConstMessages.SelectCalculationType);
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
