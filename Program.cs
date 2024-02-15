// Задача 1: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// /// <summary>
// /// функция (тип рекурсия) выводит все натуральные числа из промежутка от M до N. 
// /// </summary>
// /// <param name="start">начальное значение промежутка</param>
// /// <param name="end">конечное значение промежутка</param>
// // void ShowNumbers(int start, int end)
// // {
// //     // Базовый случай
// //     if (start == end)
// //     {
// //         Console.Write(start);
// //         return;
// //     }
// //     // Рекурсивный случай
// //     Console.Write(start + " ");
// //     ShowNumbers(start + 1, end);
// // }

// // Console.Clear();
// // Console.WriteLine("Введите начальное значение М:");
// // int M = Convert.ToInt32(Console.ReadLine()); // Принимаем из консоли значение для параметра M
// // Console.WriteLine("Введите начальное значение N:");
// // int N = Convert.ToInt32(Console.ReadLine()); // Принимаем из консоли значение для параметра N
// // ShowNumbers(M, N); // start = N, end = N


// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// // Даны два неотрицательных числа m и n.
// /// <summary>
// /// Описание принципов работы функции Аккермана https://ru.wikipedia.org/wiki/Функция_Аккермана
// /// </summary>
// /// <param name="n">первый парамтр. должен быть положительным и натуралным</param>
// /// <param name="m">второй параметр должне быт положительным и натуральным</param>
// /// <returns>Возвращаяет результат вычислений рекурсии</returns>
// int AkkermanFunction(int n, int m)
// {
//     //Базовый случай
//     if (n == 0)
//     {
//         return m + 1;
//     }

//     //Рекурсивынй случай
//     if (m == 0)
//     {
//         return AkkermanFunction(n - 1, 1);
//     }

//     return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
// }

// Console.Clear();
// int n = 0;
// int m = 0;
// while (true) // цикл проверки вводимых числе. они должны быть положительными
// {
//     Console.WriteLine(" Для функции Аккермана A(n,m)  введите  положительное значение n:");
//     n = Convert.ToInt32(Console.ReadLine()); // Принимаем из консоли значение для параметра M
//     if (n < 0) Console.WriteLine("Число должно быть положителное");
//     else break;
// }
// while (true) // цикл проверки вводимых числе. они должны быть положительными
// {
//     Console.WriteLine("теперь положительное значение m:");
//     m = Convert.ToInt32(Console.ReadLine()); // Принимаем из консоли значение для параметра N
//     if (m < 0) Console.WriteLine("Число должно быть положителное");
//     else break;
// }

// Console.WriteLine("Значение функции = " + AkkermanFunction(n, m));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

/// <summary>
/// Рекурсивная функция выводит заданный массив в обратном порядке
/// </summary>
/// <param name="arr">входной массив</param>
/// <param name="i">индекс элемента для вывода</param>
void ShowReversArray(int[] arr,int i)
{
     //Базовый случай, когда пришли на начало массива
    if (i == 0) 
    {
        Console.Write(arr[0]);// печатаем первый элемент
        return;//выходим из рекурсии
    }
    //Рекурсивный случай
    Console.Write(arr[i]+"; ");
    ShowReversArray(arr,i-1);
    

}
Console.Clear();
int [] array = {1,5,6,7,8}; //произвольный массив
int index = array.Length-1;//определяем индекс последнего элемента
Console.Write($"Входной массив:     [{String.Join("; ",array)}]\n");
Console.Write("Перевернутый массив:[");
ShowReversArray(array,index);//Начальный вызов рекурсии
Console.Write("]");


