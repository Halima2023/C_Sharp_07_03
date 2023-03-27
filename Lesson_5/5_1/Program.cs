// 1. Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отррицательные, и на оборот. [-4,-8,8,2] -> [4,8,-8,-2]

Console.Write("Кол-во элементов:");
int count = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int b = int.Parse(Console.ReadLine()!);

int[] MakeArray(int c, int m, int n)
{
    int[] array = new int[c];

    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(m, n + 1);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
}


//////////////////////////////////////////////////

void MyFunc(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]*= -1;
    }

}

int[] array = MakeArray(count, a, b);
PrintArray(array);
Console.WriteLine();
MyFunc(array);
PrintArray(array);