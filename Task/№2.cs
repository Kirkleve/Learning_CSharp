/*
Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемнента нет.
*/
Console.Write("Введите кол-во строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines, columns];

FullArray2(lines, columns);
PrintArray2(lines, columns);

Console.Write("Введите индекс строки которую хотите найти: ");
int positionLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца которого хотите найти: ");
int positionColomns = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (positionLines == i && positionColomns == j &&
            positionLines >= 0 && positionColomns >= 0)
        {
            Console.Write($"Число по вашим индексам = {array[positionLines, positionColomns]}");
            break;
        }
    }
if (positionLines >= lines || positionColomns >= columns)
{
    Console.WriteLine("С такими индексами числа нету");
    break;
}
}




void FullArray2(int lines, int columns)
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray2(int lines, int columns)
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}