// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Задаем двумерный массив.
int[,] CreateArray(int n, int m)
{
    return new int[n, m];
}

//Заполняем массив
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

//Печатаем массив
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}

//Заполняем с клавиатуры.
int WriteNumber(string str)
{
    Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] array = CreateArray(5, 5);
array = FillArray(array, -10, 100);
PrintArray(array);

//Смотрим есть ли вводимые координаты в двумерном массиве.
Console.WriteLine("");
int x = WriteNumber("Введите строку: ");
int y = WriteNumber("Введите столбец: ");

bool CoordinatesFound(int[,] array, int x, int y)
{
    if (x <= array.GetLength(0) & y <= array.GetLength(1))
    {
        return true;
    }
    else return false;
}

if (CoordinatesFound(array, x, y))
{
    Console.Write("Значение элемента массива: ");
    Console.WriteLine(array[x - 1, y - 1]);
}
else
{
    Console.WriteLine($"{x},{y} - Такой позиции в массиве нет!");
}




