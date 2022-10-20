// Программа, определяющая, является ли число чётным 
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if(a % 2 == 0)
{
    Console.WriteLine("Введёное число является чётным");
}
else
{
    Console.WriteLine("Введёное число не является чётным");
}