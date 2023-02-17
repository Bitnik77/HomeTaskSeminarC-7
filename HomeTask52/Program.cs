// Задача №52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int j = int.Parse(Console.ReadLine()!);

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
    Console.WriteLine("");
}

void AverageColumns(double sumCol)                      // Метод вычисления ср. арифметического.
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumCol = 0;                                     // Перед сменой столбца переменную sumCol 
        for (int i = 0; i < matrix.GetLength(0); i++)   // обнуляем для следующей суммы
        {
            sumCol = sumCol + matrix[i, j];             // Суммируем по столбцам в переменную sumCol.
        }
        Console.Write($"{sumCol / i:f2}\t");            // Выводим ср. арифметическое
    }
    Console.Write($"- среднее арифметическое столбцов массива");
}

FillArray(matrix);
AverageColumns(0);