// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.int[] FillArrayWithRandomNumbers(int size)

void ShowArray(int[,] array)
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

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    Random rand = new Random();

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return array;
}

Random rand = new Random();

int quantityrows = rand.Next(3, 6);

int quantitycolumns = rand.Next(3, 8);

int[,] matrix = CreateRandomArray(quantitycolumns, quantityrows, 3, 9);

ShowArray(matrix);

double average = 0;

double sum = 0;

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum = sum + matrix[j,i];

        average = sum / matrix.GetLength(0);
    }
    System.Console.Write( "|" + Math.Round(average,2) + "|");
    
    sum = 0;
}
    
