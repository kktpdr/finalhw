using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.Write("Введите элементы массива через пробел: ");
        string[] arr = Console.ReadLine().Split(' ');

        // Фильтрация массива
        string[] filteredArr = FilterShortStrings(arr);

        // Вывод отфильтрованного массива
        Console.WriteLine("Отфильтрованный массив:");
        foreach (string s in filteredArr)
        {
            Console.WriteLine(s);
        }
    }

    static string[] FilterShortStrings(string[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                result[index] = arr[i];
                index++;
            }
        }

        return result;
    }
}