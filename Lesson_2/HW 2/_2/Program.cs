﻿// 2. Напишите программу, которая выводит случайное треххзначное число и
//    удаляет вторую цифру этого числа.
//    456 -> 46, 782 -> 72, 918 -> 98


 int TakeNum(int num)
 {
    Console.WriteLine(num);
    return num / 100 * 10 + num % 10;
 }
 

 int th_num = new Random().Next(100, 1000);
 int result = TakeNum(th_num);

 Console.WriteLine(result);

 