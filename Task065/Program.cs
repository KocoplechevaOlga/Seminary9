// Задайте значения M и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от M до N.

void NaturelNumbers(int min, int max)
{
    if (max == min) return;
    NaturelNumbers(min, max - 1);
    Console.Write($"{max} ");
}

Console.WriteLine("Введите начало отчета:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец отчета:");
int  m = Convert.ToInt32(Console.ReadLine());

NaturelNumbers(n, m);
