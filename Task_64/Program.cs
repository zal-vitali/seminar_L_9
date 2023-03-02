/* ### Задача 64: 
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

//Подскажите, как правильно? IntNumbers1 или IntNumbers
string IntNumbers1(int n)
{
    if (n == 1) return n.ToString();
    else return n.ToString() + ", " + IntNumbers1(n - 1);
}

string IntNumbers(int n, string result)
{
    if (n == 1) return result + n.ToString();
    else return result + $"{n}, {IntNumbers(--n, result)}";
}

Console.Clear();
string result = "";
Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(IntNumbers1(number));
Console.WriteLine(IntNumbers(number, result));
