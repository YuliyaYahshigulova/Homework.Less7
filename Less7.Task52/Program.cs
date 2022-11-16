// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Двумерный массив
int[,] CreateArray(int n, int m)
{
    return new int[n, m];
}
//
int[,] FillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    return array;
}
//
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}

//Одномерный массив
double[] CreateDoubleArray(int n)
{
    return new double[n];
}
//
double[] FillDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
    return array;
}
//
void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
//
//Среднее арифметическое столбцов двумерного массива
double[] AverageColumn(int[,] array)
{
    double[] avgColum = CreateDoubleArray(array.GetLength(1));
    avgColum = FillDoubleArray(avgColum);

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            avgColum[i] = avgColum[i] + array[j, i];
        }
        avgColum[i] = avgColum[i] / array.GetLength(0);
        avgColum[i]=Math.Round(avgColum[i],2);
    }
    return avgColum;
}
//
//
int[,] array = CreateArray(6, 4);
array = FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine("");
double[] avgColum = AverageColumn(array);
Console.Write("Среднее арифметическое каждого столбца:  ");
PrintDoubleArray(avgColum);
Console.WriteLine();



