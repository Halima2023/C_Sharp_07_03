// 4. Напишите программу,  которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

int a = new Random().Next(100,1000);


void MyFunc(int num)
{

    Console.WriteLine(num);

    if (num % 7 == 0 && num % 23 == 0)
    {

        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}

MyFunc(a);