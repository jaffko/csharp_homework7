// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[] AverageByColumns(int[,] array)
{
    int colums = array.GetLength(1);
    int rows = array.GetLength(0);
    double rowSum = 0;
    double[] result = new double[colums];
    for (int i = 0; i < colums; i++)
    {
        rowSum = 0;
        for (int j = 0; j < rows; j++)
        {
            rowSum = rowSum + array[j,i];
        }
        double average = rowSum / rows;
        result[i] = Math.Round(average,1);
    }
    return result;
}

System.Console.WriteLine("Введите размерность массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
System.Console.WriteLine();
double[] result = AverageByColumns(array);
System.Console.WriteLine("Среднее арифметическое по столбцам = "+string.Join("; ", result));
