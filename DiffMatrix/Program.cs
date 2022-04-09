// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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


int[,] DiffMatrix(int[,] array1, int[,] array2)
{
    int[,] arr = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                arr[i, j] = arr[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return arr;
}

int[,] array1 = FillArray(3, 2);
int[,] array2 = FillArray(2, 5);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
if (array1.GetLength(1) != array2.GetLength(0))
    Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы 1 не равно количеству строк матрицы 2");
else PrintArray(DiffMatrix(array1, array2));