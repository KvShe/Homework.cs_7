// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
double[,] array = new double[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 100;
        Console.Write($"{array[i, j]:#.##}\t");
    }
    Console.WriteLine();
}