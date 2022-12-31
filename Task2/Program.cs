/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void SumNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма элементов в промежутке от m до n:{sum}");
        return;
    }
    else
    {
        sum += m++;
        SumNumbers(m, n, sum);
    }
}
Console.WriteLine("Введите начальное число m:");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите начальное число n:");
int n = int.Parse(Console.ReadLine() ?? "");
SumNumbers(m, n, 0);