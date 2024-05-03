void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.Write("Введите строку: ");
string? str = Console.ReadLine();
string[] wordArray = str.Split();
PrintArray(wordArray);