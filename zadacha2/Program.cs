// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нетvoid ShowArray( double[,] array)

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

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterNumber("введите номер строки: ");

int columns = EnterNumber("введите номер солбца: ");

Random rand = new Random();

int quantityrows = rand.Next(10, 20);

int quantitycolumns = rand.Next(10, 20);

int[,] matrix = CreateRandomArray(quantitycolumns, quantityrows, 1, 100);

ShowArray(matrix);

if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1))

    System.Console.WriteLine(matrix[rows, columns]);
else
    System.Console.WriteLine("такого значение не существует");

