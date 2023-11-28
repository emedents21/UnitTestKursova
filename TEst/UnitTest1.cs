using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAlgor;
using static TestAlgor.Algoritm;

namespace TestAlgorithm
{
    [TestClass]
    public class MainTests
    {

        [TestMethod]
        public void TestStepCorall_LivingCellWith2Or3Neighbors_Survives()
        {
            // Arrange
            bool[,] array1 = { { true, true, false }, { false, true, false }, { false, false, false } };

            // Act
            Main main = new Main();
            main.stepCorall(ref array1, 3, 3);

            // Assert
            Assert.IsTrue(array1[0, 0]);
        }

        [TestMethod]
        public void TestStepCorall_LivingCellWithMoreThan3Neighbors_Dies()
        {
            // Arrange
            bool[,] array1 = { { true, true, true }, { true, true, false }, { false, false, false } };

            // Act
            Main main = new Main();
            main.stepCorall(ref array1, 3, 3);

            // Assert
            Assert.IsFalse(array1[1, 1]);
        }

        [TestMethod]
        public void TestStepCorall_DeadCellWithExactly3Neighbors_BecomesAlive()
        {
            // Arrange
            bool[,] array1 = { { true, false, false }, { true, false, false }, { false, false, false } };

            // Act
            Main main = new Main();
            main.stepCorall(ref array1, 3, 3);

            // Assert
            Assert.IsTrue(!(array1[2, 0]));
        }
        [TestMethod]
        public void TestMethod1()
        {
            int M = 3;
            int N = 3;

            bool[,] array1 = new bool[,]
            {
                { false, true, false },
                { true, true, true },
                { false, true, false }
            };

            bool[,] expectedArray = new bool[,]
            {
                { true, true, false },
                { true, false, true },
                { true, true, true }
            };

            Main meine = new Main();
            meine.stepCorall(ref array1, N, M);
            CollectionAssert.AreEqual(expectedArray, array1);
        }

    }
}
