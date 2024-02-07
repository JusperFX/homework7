// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// int m = 1;
// int n = 10;

// void ShowAllNatural (int firstNum, int lastNum)
// {
//     if(firstNum > lastNum)
//     {
//         return;
//     }
//     Console.Write($"{firstNum} ");
//     ShowAllNatural(firstNum + 1, lastNum);
// }

// ShowAllNatural(m , n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int m = 2;
// int n = 2;

// int result = DoAckermannFunction (m, n);
// Console.WriteLine(result);

// int DoAckermannFunction (int m, int n)
// {
//     if(m == 0)
//     {
//         return n + 1;
//     }
//     else if(m > 0 && n == 0)
//     {
//         return DoAckermannFunction(m - 1, 1);
//     }
//     else if(m > 0 && n > 0)
//     {
//         return DoAckermannFunction(m - 1, DoAckermannFunction(m, n-1));
//     }
//     else
//     {
//         return 0;
//     }
// }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// int [] array = [1, 2, 3, 4, 5, 6];

// void ShowArrayConversely (int [] array, int index)
// {
//     if(index < 0)
//     {
//         return;
//     }
    
//     Console.Write($"{array[index]} ");
    
//     ShowArrayConversely(array, index - 1);
// }

// ShowArrayConversely(array, array.Length - 1);