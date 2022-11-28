// Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N.

void NaturelNumbers(int num)
{
    if (num == 0) return;
    NaturelNumbers(num - 1);
    Console.Write($"{num}, ");
}

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
NaturelNumbers(n);

