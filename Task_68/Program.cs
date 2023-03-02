/* ### Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

//F(n,m):
//m + 1 если n = 0;
//F(n - 1, 1) если n > 0 и m = 0;
//F(n - 1, F(n, m - 1));

int AccFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n > 0) && (m == 0)) return AccFunction(n - 1, 1);
    else return AccFunction(n - 1, AccFunction(n, m - 1));
}

Console.Clear();
Console.WriteLine("Вычисляем функцию Аккермана F(n,m). Введите целое число n:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое число m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Значение: {AccFunction(n, m)}");