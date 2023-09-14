using LinearAlgebraCalculatorConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraCalculatorConsoleApp.Core
{
    public static class MatrixCore
    {
        public static Matrix Transpose(this Matrix matrix)
        {
            Matrix transpose = new Matrix(matrix.ColCount, matrix.RowCount,MatrixType.Transpose);

            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (var y = 0; y < matrix.ColCount; y++)
                {
                    transpose.SetValue(y, i, matrix.Value[i, y]);
                }
            }
            transpose.Write();
            return transpose;
        }
        
        public static Matrix GaussElimination(this Matrix matrix) 
        {
            Matrix gaussMatrix = new Matrix(matrix.RowCount,matrix.ColCount,MatrixType.Gauss);
            Array.Copy(matrix.Value, gaussMatrix.Value, matrix.Value.Length);
            int rowCount = gaussMatrix.Value.GetLength(0);
            int colCount = gaussMatrix.Value.GetLength(1);

            gaussMatrix.Write();

            for (int row = 0; row < rowCount; row++)
            {
                double pivot = gaussMatrix.Value[row, row];

                for (int col = row; col < colCount; col++)
                {
                    gaussMatrix.Value[row, col] /= pivot;
                }

                for (int i = 0; i < rowCount; i++)
                {
                    if (i != row)
                    {
                        double factor = gaussMatrix.Value[i, row];
                        for (int j = row; j < colCount; j++)
                        {
                            gaussMatrix.Value[i, j] -= factor * gaussMatrix.Value[row, j];
                        }
                    }
                }
                gaussMatrix.Write();
            }
            return gaussMatrix;
        }
    }
}
