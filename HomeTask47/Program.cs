// Задача №47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк массива: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int j = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное число диапазона массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число диапазона массива: ");
int maxValue = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[i, j];                             // Объявляем массив. 
void FillArray(double[,] matrix)                                 // Передаем массив в метод.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue - 1) + new Random().NextDouble();
            Console.Write($"{matrix[i, j]:f3}\t");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);