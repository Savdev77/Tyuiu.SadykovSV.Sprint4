using Tyuiu.SadykovSV.Sprint4.Task6.V10.Lib;

Console.Title = "Спринт #4 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных. Используя класс Array, выведите элементы   *");
Console.WriteLine("* массива, длина которых меньше 7 символов.                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string[] arr = { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };

Console.WriteLine("Исходный строковый массив:");
foreach (string strings in arr)
{
    Console.Write($"{strings} ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string[] res = ds.Calculate(arr);

Console.WriteLine("Элементы, длина которых меньше 7 символов:");
foreach (string strings in res)
{
    Console.Write($"{strings} ");
}
Console.WriteLine();

Console.ReadKey();