// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Натуральные числа в промежутке от N до 1:");
//         PrintNaturalNumbers(n);
//     }

//     static void PrintNaturalNumbers(int n)
//     {
//         if (n <= 0) 
//             return;

//         Console.Write(n + " "); 
//         PrintNaturalNumbers(n - 1); 
//     }
// }




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         if (m > n)
//         {
//             Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
//             return;
//         }

//         int sum = GetSumOfNaturalNumbers(m, n);
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}.");
//     }

//     static int GetSumOfNaturalNumbers(int m, int n)
//     {
//         if (m > n) 
//             return 0;

//         return m + GetSumOfNaturalNumbers(m + 1, n);
//     }
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// Функция Аккермана 
// A(m, n) = n + 1                      , если m = 0
//           A(m-1, 1)                  , если m > 0 и n = 0
//           A(m-1, A(m, n-1))          , если m > 0 и n > 0


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         int result = Ackermann(m, n);
//         Console.WriteLine($"Значение функции Аккермана для m={m}, n={n}: {result}");
//     }

//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else if (m > 0 && n > 0)
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//         else
//         {
//             throw new ArgumentException("Входные значения m и n должны быть неотрицательными.");
//         }
//     }
// }