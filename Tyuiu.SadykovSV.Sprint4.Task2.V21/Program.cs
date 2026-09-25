using Tyuiu.SadykovSV.Sprint4.Task2.V21.Lib;
Console.Title = "Спринт #4 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
Console.WriteLine("* случайными в диапазоне от 1 до 7                                        *");
Console.WriteLine("* подсчитать произведение четных элементов массива.                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
Random rnd = new Random();

Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    arr[i] = rnd.Next(1,8);
}

Console.WriteLine();
Console.WriteLine("Массив:");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(arr);
Console.WriteLine($"Произведение четных элементов массива равно {res}");
Console.ReadKey();