// Задача 1:
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


// using System;

// class Program
// {
//     static void PrintNumbersBetween(int m, int n)
//     {
//         if (m <= n)
//         {
//             Console.WriteLine(m);
//             PrintNumbersBetween(m + 1, n);
//         }
//     }

//     static void Main()
//     {
//         int M = 5;
//         int N = 10;
//         PrintNumbersBetween(M, N);
//     }
// }


// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (n == 0)
//             return Ackermann(m - 1, 1);
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//     }

//     static void Main()
//     {
//         int result = Ackermann(2, 1);
//         Console.WriteLine(result);
//     }
// }


// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5 };
        PrintArrayReverse(myArray, myArray.Length - 1);
    }
}


