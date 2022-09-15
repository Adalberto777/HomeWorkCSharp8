// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
int[,] GetMatrix(int lines, int columns, int minValue, int maxValue) //метод с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                    //заполненный случайными числами
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

int[,] SortLineArray(int[,] matrix2) //метод сортирует по убыванию строки
{
    for (int k = 0; k < matrix2.GetLength(0); k++)
    {
        for (int i = 0; i < matrix2.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < matrix2.GetLength(1); j++)
            {
                if (matrix2[k, i] < matrix2[k, j])
                {
                    int temp = matrix2[k, i];
                    matrix2[k, i] = matrix2[k, j];
                    matrix2[k, j] = temp;
                }
            }
        }
    }
    return matrix2;
}

int[,] matrix = GetMatrix(3, 4, 0, 9); //1-строки 2-столбцы 3-минимальное число 4-максимальное число

Console.WriteLine("двумерный массив заполненный случайными числами");

PrintMatrix(matrix);

int[,] matrixSort = SortLineArray(matrix);

Console.WriteLine("двумерный массив с отсортированными по строчно в порядке убывания случайными числами");

PrintMatrix(matrixSort);


