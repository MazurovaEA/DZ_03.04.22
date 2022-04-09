// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 5);
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

int[] FindSumElemRaw(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[i] = arr[i] + array[i, j];
        }
    }
    return arr;
}

int FindMin(int[] arr)
{
    int minElem = arr[0];
    int indexMinElem = 0;
    for (int j = 1; j < arr.Length; j++)
    {
        if (minElem > arr[j])
        {
            minElem = arr[j];
            indexMinElem = j;
        }
    }
    return indexMinElem;
}

// void PrintArr(int[] collect)
// {
//     Console.Write("[");
//     for (int i = 0; i < collect.Length - 1; i++)
//     {
//         Console.Write(collect[i] + ", ");

//     }
//     Console.Write(collect[collect.Length - 1] + "]");
// }

int[,] array = FillArray(4, 5);
PrintArray(array);
Console.WriteLine();
// PrintArr(FindSumElemRaw(array));
// Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов => {FindMin(FindSumElemRaw(array))+1}");