// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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

int FindElement(int[,] array, int row, int column)
{
    if (row >= array.GetLength(0) || column >= array.GetLength(1)) return -1;
    return array[row, column];
}

System.Console.WriteLine("Введите размерность массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
System.Console.WriteLine("Введите позицию элемента");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
int element = FindElement(array, row, column);
if (element == -1) System.Console.WriteLine("Такого элемента нет");
else System.Console.WriteLine(element);
