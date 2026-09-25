using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SadykovSV.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    res *= array[i];
                }
            }
            return res;
        }
    }
}
