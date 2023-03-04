/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

/* 
Console.WriteLine($"Введите числа: ");
int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
int sum = 0;

foreach (int i in array)
    if (i > 0)
        sum++;

Console.WriteLine($"Чисел больше ноля введено {sum}");
 */

/* 
Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */
/* 
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine()!);

if(k1 != k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"Пересечение в точке ({x}; {y})");
}
else 
    Console.WriteLine($"Решения нет");
 */