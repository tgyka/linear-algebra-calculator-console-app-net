using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraCalculatorConsoleApp.Models
{
    public class Matrix
    {
        public Matrix(int rowCount, int colCount, MatrixType type)
        {
            RowCount = rowCount;
            ColCount = colCount;
            Value = new double[RowCount,ColCount];
            Type = type;
        }

        public int RowCount { get; private set; }
        public int ColCount { get; private set; }
        public double[,] Value{ get; set; }
        public MatrixType Type { get; private set; }
    }

    public enum MatrixType
    {
        None,
        Transpose,
        Gauss
    }
}
