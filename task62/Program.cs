//Напишите программу, которая заполнит спирально массив 4 на 4
int[,] GetMatrix2(int lines, int columns)
{
    int[,] result = new int[lines, columns];
    int count = 1;

    for (int k = 0; k < columns / 2; k++)
    {
        for (int j = k; j < result.GetLength(1) - k; j++)
        {
            result[k, j] = count;
            count++;
        }
        for (int i = 1 + k; i < result.GetLength(0) - k; i++)
        {
            result[i, result.GetLength(1) - 1 - k] = count;
            count++;
        }
        for (int j = result.GetLength(1) - 2 - k; j > k; j--)
        {
            result[result.GetLength(0) - 1 - k, j] = count;
            count++;
        }
        for (int i = result.GetLength(0) - 1 - k; i > k; i--)
        {
            result[i, k] = count;
            count++;
        }
    }
    return result;
}

void PrintMatrix2(int[,] matrix21) //метод распечатывает двумерный массив
{
    for (int i = 0; i < matrix21.GetLength(0); i++)
    {
        for (int j = 0; j < matrix21.GetLength(1); j++)
        {
            if (matrix21[i, j] < 10)
            {
                Console.Write($"0{matrix21[i, j]}      ");
            }
            else
            {
                Console.Write(matrix21[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

int[,] matrix2 = GetMatrix2(4, 4); //1-строки 2-столбцы 

PrintMatrix2(matrix2);

Console.WriteLine();
