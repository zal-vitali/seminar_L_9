/* ### Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 */

int SumElements(int m, int n)
{
    if (m >= n) return m;
    else return m + SumElements(++m,n);
}

Console.Clear();
Console.WriteLine("Вычисляем сумму натуральных элементов от М до N. Введите число M:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма элементов: {SumElements(m,n)}");
