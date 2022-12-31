/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


string GetNumber(int n)
{
    if (1 == n)
    {
        return n.ToString();
    }
    else
    {
        return GetNumber(n - 1) + $", {n}";
    }
}
Console.WriteLine(GetNumber(5));