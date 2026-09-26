using Tyuiu.SadykovSV.Sprint4.Task4.V14.Lib;

Console.Title = "Спринт #4 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8. Заменить нечетные        *");
Console.WriteLine("* элементы массива на 0.                                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

Console.WriteLine("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

Console.WriteLine("***************************************************************************");

for (int i =0; i < rows; i++) 
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Введите [{i},{j}] элемент массива: ");
        matrix[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int[,] res = ds.Calculate(matrix);

Console.WriteLine("Измененный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{res[i, j]} ");
    }
    Console.WriteLine();
}

Console.ReadKey();