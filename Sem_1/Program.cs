﻿// Коментарий
/*
  Это 
  мнгострочный 
  коментарий
*/

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имя_Переменной = значение;
// camelCase: firstNumber, secondNumber
// Convert.ToInt("123") => 123 + 200 = 323
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка условий, "=": int а = 5;
// if (firstNumber == secondNumber * secondNumber)
// // Является ли первое число квадратом второго?
// // firstNumber = 25, secondNumber = 5
// {
//     Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
//     // Да, 25 является квадратом от 5
// }
// else // Первое число НЕ является квадратом от второго
// {
//     Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
// }

// // Напишите программу, которая на вход принимает
// // целое число N, а на выходе показывает все целые
// // числа в промежутке от -N до N.
// // Примеры
// // 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// // 2 => -2, -1, 0, 1, 2
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int negativeN = -N; // N = 5, negativeN = -5

// while (negativeN <= N)
// {
//     Console.Write(negativeN + "\t"); // "\t" = tab
//     negativeN++; // negativeN = negativeN + 1
//     // "negativeN++" - инкремент 
//     // "negativeN--" - декремент (negativeN = negativeN - 1)
// }

// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И": апельсины И яблоки (и то, и другое)
// // "||" - "ИЛИ": апельсины ИЛИ яблоки (или то, или другое, или все вместе)
// if (number >= 100 && number <= 999)
// {
//     int firstDigit = number / 100; // 275 / 100 = 2
//     int thirdDigit = number % 10; // 275 % 10 = 5
//     int result = firstDigit * 10 + thirdDigit; // 2 * 10 + 5
//     // $"Текст {result} текст {firstDigit * 10 + thirdDigit}"
//     Console.WriteLine($"Число {number} => {result}");
// }
// else
// {
//     Console.WriteLine("Число не трехзначное!");
// }