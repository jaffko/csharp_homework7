// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
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

void SortTwoDemArray(int[,] array)
{
    int[] oneDimArray = new int[array.GetLength(0)*array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            oneDimArray[k] = array[i,j];
            k++;
        }
    }
    SortArray(oneDimArray);
    k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = oneDimArray[k];
            k++;
        }
    }
}

void SortArray(int[] array)
{
    int i = 0;
    int temp = 0;
    while (i <= array.Length)
    {
        for (int j = 1; j < array.Length - i; j++)
        {
            if (array[j] < array[j-1])
            {
                temp = array[j];
                array[j] = array[j-1];
                array[j-1] = temp;
            }
        }
        i++;
    }
}

System.Console.WriteLine("Введите размерность массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
SortTwoDemArray(array);
PrintArray(array);
