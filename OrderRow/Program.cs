// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindMaxElement(int[,] array, int Len)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxIndexColumn = 0;
        int maxElemColumn = array[i, maxIndexColumn];
        for (int j = 0; j < Len; j++)
        {
            if (array[i, j] > maxElemColumn)
            {
                maxIndexColumn = j;
                maxElemColumn = array[i, j];
            }
        }
        array[i, maxIndexColumn] = array[i, Len - 1];
        array[i, Len - 1] = maxElemColumn;
    }
}

int[,] OrderRaw(int[,] array, int Len)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1); j > 0; j--)
        {
            FindMaxElement(array, Len);
        }
    Len = Len-1;
    }
    return array;
}

void PrintReverseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, array.GetLength(1)-1-j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine();
int Len = array.GetLength(1);
PrintReverseArray(OrderRaw(array, Len));