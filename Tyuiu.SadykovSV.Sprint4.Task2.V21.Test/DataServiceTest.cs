using Tyuiu.SadykovSV.Sprint4.Task2.V21.Lib;
namespace Tyuiu.SadykovSV.Sprint4.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds= new DataService();
            int[] arr = {1, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1,2};
            int res = ds.Calculate(arr);
            int wait = 128;
            Assert.AreEqual(wait, res);
        }
    }
}
