/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов 
в каждом столбце.
*/
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

AverageColumns(m, n, array);

void AverageColumns(int lines, int columns, double[,] array)
{
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < lines; i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среденее арифметическое {j + 1} столбца = {Math.Round(sum / lines, 2)}");
    }
}
