﻿// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
    Console.Write("Число " + a + " является четным.");
else
    Console.Write("Число " + a + " четным не является.");