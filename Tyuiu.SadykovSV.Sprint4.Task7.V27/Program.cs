using Tyuiu.SadykovSV.Sprint4.Task7.V27.Lib;
Console.Title = "Спринт #4 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр '583197256891'. Преобразуйте ее в     *");
Console.WriteLine("* матрицу 4 на 3 и подсчитайте количество четных чисел.                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int n = 4;
int m = 3;
string str = "583197256891";

Console.WriteLine($"Исходная строка: {str}");
Console.WriteLine("Матрица 4x3:");
int index = 0;
for(int i =0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{str[index]} ");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(n, m, str);
Console.WriteLine($"Количество четных чисел: {res}");

Console.ReadKey();