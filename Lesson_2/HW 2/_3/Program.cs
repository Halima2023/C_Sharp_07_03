// 3. Напишите программу, которая выводит третью цифру заданного числа или 
//    сообщает, что третьей цифры нет.
//    645 -> 5, 78 -> третьей цифры нет, 32679 -> 6 


void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("There is no third digit");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);

}

int val = int.Parse(Console.ReadLine()!);
ThirdNum(val);

