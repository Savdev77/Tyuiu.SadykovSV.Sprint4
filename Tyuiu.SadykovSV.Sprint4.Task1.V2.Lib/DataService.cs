using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SadykovSV.Sprint4.Task1.V2.Lib
{
    public class DataService : ISprint4Task1V2
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            for (int i = 0; i< array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    res += array[i];
                }
            }
            return res;
        }
    }
}
