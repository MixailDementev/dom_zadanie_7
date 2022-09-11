// / Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Еnter the number of rows in the array: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Еnter the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine());
System.Console.WriteLine();

int[,] array = EnterArray(rows, columns);
int[,] EnterArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchingForValueInArray(int[,] array)
{
    Console.Write("Enter the row of the number...\t");
    int rowNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the column of the number...\t");
    int columnNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rowNumber > array.GetLength(0) && columnNumber < array.GetLength(1))
            {
                Console.WriteLine($"Числа с таким индексом нет");
            }
            else
            {
                Console.Write(array[rowNumber, columnNumber]);
            }
            return;
        }
    }
    return;
}
PrintArray(array);
Console.WriteLine();
SearchingForValueInArray(array);