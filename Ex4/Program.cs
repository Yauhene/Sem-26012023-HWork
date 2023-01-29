// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("============================");
Console.WriteLine();

Console.Write("Введите первое число :");
if(int.TryParse(Console.ReadLine(), out int a1))

Console.Write("Введите второе число :");
if(int.TryParse(Console.ReadLine(), out int a2))

Console.Write("Введите третье число :");
if(int.TryParse(Console.ReadLine(), out int a3))

int maximal = a1;

if (maximal < a2) maximal = a2;

if (maximal < a3) maximal = a3;


Console.WriteLine("Максимальное число - " + maximal);