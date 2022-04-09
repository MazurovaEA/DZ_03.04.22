/*Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

int[,,] Fill3DArray(int row, int column, int pas)
{
    int[,,] array = new int[row, column, pas];
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = count;
                count++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"({i},{j},{k}) => {array[i, j, k]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] array = Fill3DArray(3, 3, 3);
PrintArray(array);
