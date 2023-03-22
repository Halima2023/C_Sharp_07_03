// 3. Напишите программу, которая будет ппринимать на ввод два числа и 
//    выводить, является ли второе число кратным первому.
//    Если число 2 не кратно числу 1, то программа выводит остаток от деления.


int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);


if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно " + num1%num2);
}
