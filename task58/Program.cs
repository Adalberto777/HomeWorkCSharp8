// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
int[,] GetMatrix21(int lines, int columns, int minValue, int maxValue) //метод с параметрами: размер, мин элемент, макс элемент создает массив 
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

int[,] GetMatrix22(int lines, int columns, int minValue, int maxValue) //метод с параметрами: размер, мин элемент, макс элемент создает массив 
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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2) //метод перемножает двумерные матрицы
{   
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        Console.WriteLine("Матрицы нельзя перемножить");
    }

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] = result[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

int[,] matrix21 = GetMatrix21(2 , 2, 0, 9); //1-строки 2-столбцы 3-минимальное число 4-максимальное число

int[,] matrix22 = GetMatrix22(2 , 2, 0, 9); //1-строки 2-столбцы 3-минимальное число 4-максимальное число

PrintMatrix(matrix21);

Console.WriteLine();

PrintMatrix(matrix22);

Console.WriteLine();

PrintMatrix(MatrixProduct(matrix21, matrix22));


