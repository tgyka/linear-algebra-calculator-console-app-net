using LinearAlgebraCalculatorConsoleApp.Core;
using LinearAlgebraCalculatorConsoleApp.Models;

namespace LinearAlgebraCalculatorConsoleApp.UnitTest
{
    public class TransposeUnitTests
    {
        [Test]
        public void Transpose_WhenCalledWithValidMatrix_ReturnsTransposeMatrix()
        {
            // Arrange
            var inputMatrix = new Matrix(2, 3,MatrixType.None);
            inputMatrix.SetValue(0, 0, 1);
            inputMatrix.SetValue(0, 1, 2);
            inputMatrix.SetValue(0, 2, 3);
            inputMatrix.SetValue(1, 0, 4);
            inputMatrix.SetValue(1, 1, 5);
            inputMatrix.SetValue(1, 2, 6);

            var expectedTranspose = new Matrix(3, 2, MatrixType.Transpose);
            expectedTranspose.SetValue(0, 0, 1);
            expectedTranspose.SetValue(1, 0, 2);
            expectedTranspose.SetValue(2, 0, 3);
            expectedTranspose.SetValue(0, 1, 4);
            expectedTranspose.SetValue(1, 1, 5);
            expectedTranspose.SetValue(2, 1, 6);

            // Act
            var result = inputMatrix.Transpose();

            // Assert
            Assert.AreEqual(expectedTranspose.Value, result.Value);
            Assert.AreEqual(expectedTranspose.Type, result.Type);
        }

        [Test]
        public void Transpose_WhenCalledWithEmptyMatrix_ReturnsEmptyMatrix()
        {
            // Arrange
            var inputMatrix = new Matrix(0, 0, MatrixType.Transpose);

            // Act
            var result = inputMatrix.Transpose();

            // Assert
            Assert.AreEqual(0, result.RowCount);
            Assert.AreEqual(0, result.ColCount);
        }
    }
}