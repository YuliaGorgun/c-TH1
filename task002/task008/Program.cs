﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите число");
int number = 1;
while (number<N)
{
    Console.WriteLine(number+1);
    number+=2;
}
