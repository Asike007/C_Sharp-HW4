// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе: {SumNumber(number)}");

int SumNumber(int number)
{
    int counter = Convert.ToString(number).Length;
    int adv = 0;
    int res = 0;

    for (int i = 0; i < counter; i++)
    {
        adv = number - number % 10;
        res = res + (number - adv);
        number = number / 10;
    }
    return res;
}