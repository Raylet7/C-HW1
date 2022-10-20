// Программа, показывающая все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int I = 1;
while(I <= N)
{
    if(I % 2 == 0)
    {
        Console.Write(I + " ");
    }
    I++;
}