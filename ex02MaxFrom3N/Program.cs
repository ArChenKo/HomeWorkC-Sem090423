// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int[] arr = new int[3];
int indar = 0;
while (indar < 3)
{
    Console.Write("Введите следующее целое число: ");
    arr[indar] = int.Parse(Console.ReadLine()!);
    indar++;
}
int count = 0;
int max = 0;
while (count < 3)
{
    if (arr[count] > arr[max])
    {
        max = count;
    }
    count++;
}
Console.WriteLine("Итак, максимальное из введенных чисел: "+arr[max]);