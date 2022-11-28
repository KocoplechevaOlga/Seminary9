// Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр.

int SumByDig(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumByDig(num /10);
}

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
int s = SumByDig(n);
Console.WriteLine($"Сумма цифр числа {n} составляет {s}");
