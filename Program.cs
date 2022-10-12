/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
int[,] generateTwodimensionalArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twodimensionalArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twodimensionalArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twodimensionalArray;
}

void print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] generateArray = generateTwodimensionalArray(5, 5, 1, 100);
print2DArray(generateArray);