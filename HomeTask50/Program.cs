// Задача № 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите количество строк массива: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int j = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс X искомого элемента массива: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс Y искомого элемента массива: ");
int Y = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[i, j];                          // Объявляем массив. 
void FillArray(int[,] matrix)                           // Инициализируем массив, передав его в метод.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintNumber(int X, int Y)
{
    if (X > i - 1 || X < 0 || Y > j - 1 || Y < 0)
    {
        Console.Write($"Элемента с индексами {(X, Y)} в массиве нет");
    }
    else
    {
        Console.WriteLine($"Элементом массива с индексами {(X, Y)} является {matrix[X, Y]}.");
    }
}
FillArray(matrix);
PrintNumber(X, Y);