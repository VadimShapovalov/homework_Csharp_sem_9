/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int SumNaturalNumber(int m, int n)
{
    if (m <= n) return SumNaturalNumber(m + 1, n) + m;
    else return 0;
}
Console.WriteLine("Введете меньшее число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введете большее число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNaturalNumber(m, n));