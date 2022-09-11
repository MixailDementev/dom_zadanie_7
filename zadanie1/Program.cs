// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Еnter the number of rows in the array: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Еnter the number of colums in the array: ");
int colums = int.Parse(Console.ReadLine());

double[,] array = EnterArray(rows, colums);

double[,] EnterArray(int rows, int columnsint)
{
    double[,] result = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().NextDouble()*10;
        }
    }
    return result;
    Console.WriteLine(result);
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintArray(array);
