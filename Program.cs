﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


/// <summary>
/// функция (тип рекурсия) выводит все натуральные числа из промежутка от M до N. 
/// </summary>
/// <param name="start">начальное значение промежутка</param>
/// <param name="end">конечное значение промежутка</param>
void ShowNumbers(int start, int end)
{
    // Базовый случай
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    // Рекурсивный случай
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.WriteLine("Введите начальное значение М:");
int M = Convert.ToInt32(Console.ReadLine()); // Принимаем из консоли значение для параметра M
Console.WriteLine("Введите начальное значение N:");
int N = Convert.ToInt32(Console.ReadLine()); // Принимаем из консоли значение для параметра N
ShowNumbers(M, N); // start = N, end = N

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.




// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.