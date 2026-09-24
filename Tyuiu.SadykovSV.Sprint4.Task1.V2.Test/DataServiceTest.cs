using Tyuiu.SadykovSV.Sprint4.Task1.V2.Lib;

namespace Tyuiu.SadykovSV.Sprint4.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] arr = { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 };
            int res = ds.Calculate(arr);
            int expected = 27;
            Assert.AreEqual(expected, res);
        }
    }
}
