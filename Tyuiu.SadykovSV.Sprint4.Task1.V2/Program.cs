using Tyuiu.SadykovSV.Sprint4.Task1.V2.Lib;

Console.Title = "Спринт #4 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры. Подсчитать сумму нечетных элементов массива.   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите количество элементов массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
DataService ds = new DataService();

for(int i =0; i <= len-1; i++)
{
    Console.Write($"Введите значение {i} элемента:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
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
Console.WriteLine($"Сумма нечетных элементов массива: {res}");

Console.ReadKey();