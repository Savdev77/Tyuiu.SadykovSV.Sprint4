using Tyuiu.SadykovSV.Sprint4.Task0.V4.Lib;
namespace Tyuiu.SadykovSV.Sprint4.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] arr = {5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetMultEvenArrEl(arr);
            int expected = 7560;
            Assert.AreEqual(expected, res);
        }
    }
}
