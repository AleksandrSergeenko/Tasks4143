/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

Console.WriteLine($"Введите числа: ");
int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
int sum = 0;

foreach (int i in array)
    if (i > 0)
        sum++;

Console.WriteLine($"Чисел больше ноля введено {sum}");
