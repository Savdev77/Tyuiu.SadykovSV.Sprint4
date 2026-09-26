using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SadykovSV.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;

            int res = 0;

            for (int i = 0; i < rows; i++)
            {
                res += array[i, 0];
            }
            return res;
        }
    }
}
