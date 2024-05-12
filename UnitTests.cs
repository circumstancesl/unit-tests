using DelegatesAndEvents;
using System.Drawing;
using System.Numerics;
using System.Security.AccessControl;

namespace MatrixCalcTests
{
    [TestClass]
    public class MatrixCalculatorTests
    {
        [TestMethod]
        public void TestSumMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix actualResult = new SquareMatrix(3, 1, 10);
            SquareMatrix expectedResult = new SquareMatrix(3, 1, 10);

            firstMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            secondMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            expectedResult.Matrix = new int[,] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            actualResult = firstMatrix + secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMultiplicationMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(2, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(2, 1, 10);
            SquareMatrix actualResult = new SquareMatrix(2, 1, 10);
            SquareMatrix expectedResult = new SquareMatrix(2, 1, 10);

            firstMatrix.Matrix = new int[,] { { 1, 2 }, { 4, 5 }, };
            secondMatrix.Matrix = new int[,] { { 9, 8 }, { 6, 5 }, };
            expectedResult.Matrix = new int[,] { { 21, 18 }, { 66, 57 } };
            actualResult = firstMatrix * secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(3, 1, 10);
            bool actualResult;
            bool expectedResult = true;

            firstMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            secondMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = firstMatrix == secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestNotEqualsMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(3, 1, 10);
            bool actualResult;
            bool expectedResult = false;

            firstMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            secondMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = firstMatrix != secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMoreThanMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(3, 1, 10);
            bool actualResult;
            bool expectedResult = false;

            firstMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            secondMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = firstMatrix > secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMoreThanOrEqualsMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(3, 1, 10);
            bool actualResult;
            bool expectedResult = true;

            firstMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            secondMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = firstMatrix >= secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(3, 1, 10);
            bool actualResult;
            bool expectedResult = false;

            firstMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            secondMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = firstMatrix < secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestLessOrEqualsThanMethod()
        {
            SquareMatrix firstMatrix = new SquareMatrix(3, 1, 10);
            SquareMatrix secondMatrix = new SquareMatrix(3, 1, 10);
            bool actualResult;
            bool expectedResult = true;

            firstMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            secondMatrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = firstMatrix <= secondMatrix;

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestDeterminantMethod()
        {
            int expectedResult = 0;
            int actualResult;
            SquareMatrix matrix = new SquareMatrix(3, 1, 10);

            matrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            actualResult = matrix.Determinant();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestInverseMethod()
        {
            SquareMatrix matrix = new SquareMatrix(3, 1, 10);
            SquareMatrix actualResult = new SquareMatrix(3, 1, 10);
            SquareMatrix expectedResult = new SquareMatrix(3, 1, 10);

            matrix.Matrix = new int[,] { { 1, -2, 1 }, { 2, 1, -1 }, { 3, 2, -2 } };
            expectedResult.Matrix = new int[,] { { 0, 2, -1 }, { -1, 5, -3 }, { -1, 8, -5 } };
            actualResult = matrix.Inverse();

            Assert.AreEqual(expectedResult, actualResult); 
        }

        [TestMethod]
        public void TestTransposeMethod()
        {
            SquareMatrix matrix = new SquareMatrix(3, 1, 10);
            SquareMatrix actualResult = new SquareMatrix(3, 1, 10);
            SquareMatrix expectedResult = new SquareMatrix(3, 1, 10);

            matrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            expectedResult.Matrix = new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            
            actualResult = matrix.Transpose();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestTraceMethod()
        {
            int expectedResult = 15;
            int actualResult;
            SquareMatrix matrix = new SquareMatrix(3, 1, 10);

            matrix.Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            actualResult = matrix.Trace();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
