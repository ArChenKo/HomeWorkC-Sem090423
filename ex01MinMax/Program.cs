// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Теперь сравним первое число " + a + " и второе число " + b + ".");
Console.WriteLine();
if (a > b)
    Console.WriteLine("Итак, первое число " + a + " больше второго числа " + b + ".");
else
    Console.WriteLine("Итак, второе число " + b + " больше первого числа " + a + ".");