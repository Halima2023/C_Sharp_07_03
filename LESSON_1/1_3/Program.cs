// 5. Напишите программу, которая на вход принимает одно число (N), а на входе
//    показывает все целые числа в промежутке от -N до N
//    4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//    2 -> "-2, -1, 0, 1, 2"


Console.WriteLine("N=");
int n = int.Parse(Console.ReadLine()!);

int count = -n;

while (count != n)
{

  Console.WriteLine(count);
  if (n < 0)
  {
    count--;
  }
  else
  {
    count++;
  }

}


