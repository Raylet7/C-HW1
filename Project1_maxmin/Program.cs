﻿// Программа, определяющая большее и меньшее из двух чисел
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if(a > b)
Console.WriteLine("Первое число больше второго");
else
Console.WriteLine("Второе число больше первого");