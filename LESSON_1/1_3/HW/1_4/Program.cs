// 4. Напишите программу, которая на вход принимает числа (N),
//    а на выходе показывает все четные числа от 1 до N.


int num = int.Parse(Console.ReadLine()!);
int i = 2;

while (i <= num)
{

    Console.Write($"{i} ");
    i += 2;

}