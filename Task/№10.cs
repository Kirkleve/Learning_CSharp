/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = 1;
int rezult = Numbers(n, temp);
Console.WriteLine(rezult);

int Numbers(int number, int temp)
{
    if (number == temp)
        return temp;
    Console.Write(Numbers(number, temp + 1) + ",");
    return temp;
}
