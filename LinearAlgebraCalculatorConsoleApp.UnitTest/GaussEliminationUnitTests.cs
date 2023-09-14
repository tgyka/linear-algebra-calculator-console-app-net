using LinearAlgebraCalculatorConsoleApp.Core;
using LinearAlgebraCalculatorConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraCalculatorConsoleApp.UnitTest
{
    public class GaussEliminationUnitTests
    {
        [Test]
        public void GaussElimination_WhenCalledWithValidMatrix_ReturnsReducedRowEchelonFormMatrix()
        {
            // Arrange
            var inputMatrix = new Matrix(3, 4,MatrixType.None);
            inputMatrix.SetValue(0, 0, 3);
            inputMatrix.SetValue(0, 1, 4);
            inputMatrix.SetValue(0, 2, 6);
            inputMatrix.SetValue(1, 0, 32);
            inputMatrix.SetValue(1, 1, 23);
            inputMatrix.SetValue(1, 2, 45);
            inputMatrix.SetValue(2, 0, 4);
            inputMatrix.SetValue(2, 1, 5);
            inputMatrix.SetValue(2, 2, 7);
            inputMatrix.SetValue(0, 3, 8);
            inputMatrix.SetValue(1, 3, 67);
            inputMatrix.SetValue(2, 3, 42);



            var expectedReducedRowEchelonForm = new Matrix(3, 4,MatrixType.Gauss);
            expectedReducedRowEchelonForm.SetValue(0, 0, 1);
            expectedReducedRowEchelonForm.SetValue(0, 1, 0);
            expectedReducedRowEchelonForm.SetValue(0, 2, 0);
            expectedReducedRowEchelonForm.SetValue(1, 0, 0);
            expectedReducedRowEchelonForm.SetValue(1, 1, 1);
            expectedReducedRowEchelonForm.SetValue(1, 2, 0);
            expectedReducedRowEchelonForm.SetValue(2, 0, 0);
            expectedReducedRowEchelonForm.SetValue(2, 1, 0);
            expectedReducedRowEchelonForm.SetValue(2, 2, 1);
            expectedReducedRowEchelonForm.SetValue(0, 3, 34.65);
            expectedReducedRowEchelonForm.SetValue(1, 3, 46.025);
            expectedReducedRowEchelonForm.SetValue(2, 3, -46.675);

            // Act
            var result = inputMatrix.GaussElimination();

            // Assert
            Assert.AreEqual(expectedReducedRowEchelonForm.Value, result.Value);
            Assert.AreEqual(expectedReducedRowEchelonForm.Type, result.Type);

        }

        [Test]
        public void GaussElimination_WhenCalledWithEmptyMatrix_ReturnsEmptyMatrix()
        {
            // Arrange
            var inputMatrix = new Matrix(0, 0,MatrixType.None);

            // Act
            var result = inputMatrix.GaussElimination();

            // Assert
            Assert.AreEqual(0, result.RowCount);
            Assert.AreEqual(0, result.ColCount);
        }
    }
}
