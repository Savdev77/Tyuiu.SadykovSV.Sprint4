using Tyuiu.SadykovSV.Sprint4.Task3.V5.Lib;

Console.Title = "Спринт #4 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите сумму            *");
Console.WriteLine("* элементов в первом столбце массива.                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int[,] array = new int[5, 5] { { 3, 4, 8, 6, 3 },
                               { 9, 9, 3, 6, 9 },
                               { 5, 6, 7, 2, 3 },
                               { 3, 6, 2, 3, 8 },
                               { 5, 7, 2, 6, 4 } };

int rows = array.GetUpperBound(0) + 1;
int columns = array.GetUpperBound(1) + 1;

Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(array);
Console.WriteLine($"Сумма элементов в первом столбце: {res}");

Console.ReadKey();