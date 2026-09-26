using Tyuiu.SadykovSV.Sprint4.Task5.V18.Lib;
namespace Tyuiu.SadykovSV.Sprint4.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -1, 3, 7, 7, -6 }, { 4, 2, 6, 3, 3 },
                                            { 4, -5, 1, 4, 6 }, { 7, 5, -2, 7, 7 },
                                            {2, 4, -4, 4, 7 } };

            int[,] res = ds.Calculate(matrix);
            int[,] expected = new int[5, 5]{ { 0, 3, 7, 7, 0 }, { 4, 2, 6, 3, 3 },
                                            { 4, 0, 1, 4, 6 }, { 7, 5, 0, 7, 7 },
                                            {2, 4, 0, 4, 7 } };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
