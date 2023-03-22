// 3. Напишите программу, которая будет выдавать названия дня недели
//    по заданному номеру.
//    3 -> Среда
//    5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1)
{
  Console.WriteLine("Понедельник");
}
else if (num == 2)
{
  Console.WriteLine("Вторнник");
}
else if (num == 3)
{
  Console.WriteLine("Среда");
}
else if (num == 4)
{ 
  Console.WriteLine("Четверг"); 
}

else if (num == 5)
{
  Console.WriteLine("Пятница"); 
}

else if (num == 6)

{
  Console.WriteLine("Суббота");
}

else if (num == 7)

{
  Console.WriteLine("Воскресенье");
}

else 

{
  Console.WriteLine("Неизвестное число");
}

