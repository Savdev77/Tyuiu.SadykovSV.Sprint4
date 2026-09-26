using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SadykovSV.Sprint4.Task5.V18.Lib
{
    public class DataService : ISprint4Task5V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j]< 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }   
            return matrix;
        }
    }
}
