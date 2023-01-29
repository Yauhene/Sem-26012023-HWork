// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("============================");
Console.Write("Введите первое число :");
if(int.TryParse(Console.ReadLine(), out int a1))

Console.Write("Введите второе число :");
if(int.TryParse(Console.ReadLine(), out int a2))

    if(a1 != a2)
    {
        if((a1 - a2) > 0) Console.WriteLine("Число " + a1 + " больше чем " + a2);
        else           Console.WriteLine("Число " + a2 + " больше чем " + a1);
    }
    else 
    {
        Console.WriteLine("Вы ввели одно и то же число дважды");
    }
Console.WriteLine("============================");