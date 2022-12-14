// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Результат возведения числа {n} в степень {x} будет равен: {GetExponent(n, x)}");

int GetExponent(int a, int b)
{
    int res = 1;
    for (int i = b; i > 0; i--)
    {
        res *= a;
    }
    return res;
}