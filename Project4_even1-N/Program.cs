﻿// Программа, показывающая все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = 1;
while(i <= n)
{
    if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}