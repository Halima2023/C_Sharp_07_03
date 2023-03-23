// 3. Напишите программу, которая принимает на вход число (N) и выдает таблицу
//    квадратов чисел от 1 до N.        5 -> 1, 4, 9, 16, 25. 2 -> 1, 4.

void Pow(int num)
{
    int i = 1;
    while (i <= num) 
    {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
    }
}

int number = int.Parse(Console.ReadLine()!);
Pow(number);

