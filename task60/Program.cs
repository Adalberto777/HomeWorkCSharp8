// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы
int[,,] GetMatrix3(int pages, int lines, int columns, int minValue, int maxValue) //метод с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                                   //заполненный случайными числами
    int[,,] result = new int[pages, lines, columns];
    int count = 10; 

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = count;  //new Random().Next(minValue, maxValue + 1);
                count += 1;
            }
        }
    }
    return result;
}

void PrintMatrix3(int[,,] matrix31) //метод распечатывает двумерный массив
{
    for (int i = 0; i < matrix31.GetLength(0); i++)
    {
        for (int j = 0; j < matrix31.GetLength(1); j++)
        {
            for (int k = 0; k < matrix31.GetLength(2); k++)
            {
                Console.Write($" {matrix31[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix3 = GetMatrix3(2, 2, 2, 10, 99); //1-страницы 2-строки 3-столбцы 4-минимальное число 5-максимальное число



PrintMatrix3(matrix3);

Console.WriteLine();



