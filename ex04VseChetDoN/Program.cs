﻿// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое положительное число: ");
int N = int.Parse(Console.ReadLine()!);
int count = 2;
while (count <= N)
{
    Console.Write(count + "|");
    count = count + 2;
}