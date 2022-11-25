// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число: ");
int a2 = Convert.ToInt32(Console.ReadLine());

int sum = a1;

for (int i = 1; i < a2; i++)
{
    sum = sum * a1;
}
Console.WriteLine($"{a1} в степени {a2} = " + sum);