// 3. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов
//    массива, значения которых лежат в отреззке [10,99]
//    Пример из массива из 5 элементов: [5, 18, 123, 6, 2] -> 1
//                                       [1, 2, 3, 6, 2,] -> 0
//                                       [10, 11, 12, 13, 14] -> 5

int arrLength = 10; // GetUserNumber("array length");
int arrMin = 0; // GetUserNumber("min element");
int arrMax = 1000; // GetUserNumber("max element");

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray(arr);
Console.WriteLine(CountNumber(arr));

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

int[] MakeArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;

}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
