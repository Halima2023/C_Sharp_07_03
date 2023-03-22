// 4. Напишите программу, которая принимает на вход цифру, 
//    обозначающую  день недели, и проверяет, является ли этот день выходным.
//    6 - да, 7 - да, 1 - нет

void Weekend(int num)
{
    string text = "not quite a week";

    if (num == 7 || num == 6) text = "weekend";
    else if (num < 6 && num > 0) text = "workday";

    Console.WriteLine($"{num} -> {text}");
}

int val = int.Parse(Console.ReadLine()!);
Weekend(val);


