// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("============================");
Console.WriteLine();

Console.Write("Введите число :");
if(int.TryParse(Console.ReadLine(), out int a1))
{
    if((a1 % 2) == 0)
    {
        Console.WriteLine("Это четное число");
    }
    else
    {
        Console.WriteLine("Это нечетное число");
    }
}

Console.WriteLine("============================");
Console.WriteLine();
