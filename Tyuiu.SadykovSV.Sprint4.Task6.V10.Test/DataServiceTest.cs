using Tyuiu.SadykovSV.Sprint4.Task6.V10.Lib;
namespace Tyuiu.SadykovSV.Sprint4.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] arr = {"Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка"};
            string[] res = ds.Calculate(arr);
            string[] expected = { "Театр", "Кино", "Музей", "Парк" };
            CollectionAssert.AreEqual(expected, res);
        }
    }
}
