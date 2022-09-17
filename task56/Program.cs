// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
int[,] GetMatrix(int lines, int columns, int minValue, int maxValue) //метод с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                                   //заполненный случайными числами
    int[,] result = new int[lines, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix2) //метод распечатывает двумерный массив
{
    for (int i = 0; i < matrix2.GetLength(0); i++)  // matrix.GetLength(0) конструкция выдает количество строк или столбцов 
    {                                              // в зависимости 0 или 1 (0- строки, 1 столбцы)
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(matrix2[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int MinSumLine(int[,] matrix2) //метод ищет строку с минимальной суммой элементов
{
    int[] minSumLine = new int[matrix2.GetLength(0)];

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            minSumLine[i] += matrix2[i, j];
        }
    }

    int minValue = minSumLine[0];
    int minIndex = 0;
    for (int k = 1; k < minSumLine.Length; k++)
    {
        if (minValue > minSumLine[k])
        {
            minValue = minSumLine[k];
            minIndex = k;
        }
    }
    return minIndex;
}

int[,] matrix = GetMatrix(4, 4, 0, 9); //1-строки 2-столбцы 3-минимальное число 4-максимальное число

Console.WriteLine("двумерный массив заполненный случайными числами");

PrintMatrix(matrix);

Console.WriteLine();

Console.WriteLine($"{MinSumLine(matrix) + 1} - строка с минимальной суммой элементов");


