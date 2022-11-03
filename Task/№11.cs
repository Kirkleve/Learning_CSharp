﻿/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Задайте первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число:");
int n = Convert.ToInt32(Console.ReadLine());
int rezult = SummNumbers(m, n);
Console.WriteLine($"сумма всех чисел в промежутке между {m} и {n} = {rezult}");

int SummNumbers(int numberOne, int numberTwo)
{
    if (numberOne == numberTwo)
        return numberOne;
    return numberOne + SummNumbers(numberOne +1,numberTwo);
}