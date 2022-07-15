// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void SearchNumberByIndex(int[,] array)
{
    Console.WriteLine("Ищу значение по индексу");
    Console.Write("Enter row number: ");
    int rowsPosition = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Enter column number: ");
    int columnsPosition = Convert.ToInt32(Console.ReadLine()) - 1;

    int result = 0;
    bool checkPoints = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{array[i, j]}\t");
            if (i == rowsPosition && j == columnsPosition)
            {
                result = array[i, j];
                checkPoints = true;
            }
        }
        Console.WriteLine();
    }
    if (checkPoints == true) Console.WriteLine($"Значение элемента = {result}\n");
    else Console.WriteLine($"Такого элемента нет\n");
}
void SearchNumberInArray(int[,] array)
{
    Console.WriteLine("Проверяю, есть ли искомое число в массиве");
    Console.Write("Введите искомое значение: ");
    int desiredNumber = Convert.ToInt32(Console.ReadLine());
    bool checkPoint = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{array[i, j]}\t");
            if (array[i, j] == desiredNumber)
            {
                checkPoint = true;
            }
        }
        Console.WriteLine();
    }
    if (checkPoint == true) Console.WriteLine($"Искомое значение: {desiredNumber}\nЕсть");
    else Console.WriteLine($"Искомого значения: {desiredNumber}\nНет");
}

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] array = new int[rows, columns];

SearchNumberByIndex(array);
SearchNumberInArray(array);