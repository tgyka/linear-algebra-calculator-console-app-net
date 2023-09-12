
using LinearAlgebraCalculatorConsoleApp.Core;
using LinearAlgebraCalculatorConsoleApp.Models;

var matrix = new Matrix(3, 4, MatrixType.None);
for(int i=0; i < matrix.RowCount; i++)
{
    for(int j=0; j< matrix.ColCount; j++)
    {
        matrix.Value[i, j] = new Random().Next(0,50);
    }
}

var gaussMatrix = matrix.GaussElimination();

var x = gaussMatrix;