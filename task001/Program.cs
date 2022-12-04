// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Введите значение N. N = ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int x)
{
    if (x == 0) return;
    NaturalNumbers(x - 1);
    Console.Write($"{x} ");
}

NaturalNumbers(n);
