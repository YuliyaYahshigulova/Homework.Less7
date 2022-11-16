// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Задаем двумерный массив.
double[,] CreateArray(int m, int n)
{
    return new double[m, n];
}

//Заполняем массив
double[,] FillArray(double[,] array, double min, double max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            var next = rand.NextDouble();
            array[i, j] = min + next * (max - min);
        }
    return array;
}

//Печатаем массив
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 1) + "\t");
        }
}

//Заполняем с клавиатуры.
int WriteNumber(string str)
{
    Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int m = WriteNumber("Введите количество строк");
int n = WriteNumber("Введите количество столбцов");
double[,] array = CreateArray(m, n);
array = FillArray(array, -15, 20);
PrintArray(array);