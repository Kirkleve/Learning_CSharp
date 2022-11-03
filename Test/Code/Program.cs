int FindLenght (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] array, int lenght)
{
    string[] newArray = new string[lenght];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] += array[i];
            count++;
            if (count >= lenght)
            {
                break;
            }
        }
    }
    return newArray;
}

string PrintArray(string[] array)
{
    string restore = "[";
    for (int i = 0; i < array.Length; i++)
    {
        restore += $" {array[i]}";
    }
    restore += "]";
    return restore;
}

string[] array = new string[] { "hello", "2", "world", ":-)" };

Console.WriteLine(PrintArray(array));
Console.WriteLine(PrintArray(CreateNewArray(array,FindLenght(array))));

