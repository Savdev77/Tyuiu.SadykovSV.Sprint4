using Tyuiu.SadykovSV.Sprint4.Task7.V27.Lib;
namespace Tyuiu.SadykovSV.Sprint4.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 3;
            string str = "583197256891";

            int res = ds.Calculate(n, m, str);
            int expected = 4;
            Assert.AreEqual(expected, res);
        }
    }
}
