﻿//  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= B; i++)
    result *= A;
Console.WriteLine($"Результат: {result}");