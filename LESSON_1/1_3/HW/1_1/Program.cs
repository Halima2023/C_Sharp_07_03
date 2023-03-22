// 1. Напишите программу, которая на вход принимает два числа и
//    выдает, какое число большее, а какое меньшее.

string s_n_1 = Console.ReadLine()!;
string s_n_2 = Console.ReadLine()!;

int n_1 = int.Parse(s_n_1);
int n_2 = int.Parse(s_n_2);

if (n_1 > n_2)
{
    Console.WriteLine("The number {n_1} is greater than {n_2}");
}
else if (n_1 < n_2)
{
    Console.WriteLine("The number {n_2} is greater than {n_1}");
}
else
{
    Console.WriteLine("Both numbers are equal");
}


