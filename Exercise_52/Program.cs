// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int columns = 4;
int rows = 3;
int[,] array = {{1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}};
double[] arrayColumns = new double[columns];

for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        arrayColumns[i] += array[j, i];
    }
    Console.WriteLine($"Arithmetic mean {i + 1} columns = {arrayColumns[i] / rows:#.##}");
}