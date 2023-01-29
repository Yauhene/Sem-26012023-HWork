// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("============================");
Console.WriteLine();

int i = 2;

Console.Write("Введите число :");
if((int.TryParse(Console.ReadLine(), out int a1)) & (a1 >= 2))
{
    while(i <= a1)
    {
        Console.Write(i + ", ");
        i=i+2;
    }
}