// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

{
        // Создаем двумерный массив
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        // Меняем местами первую и последнюю строки
        SwapFirstAndLastRows(matrix);

        Console.WriteLine("\nМатрица после обмена строк:");
        PrintMatrix(matrix);
    }

    static void SwapFirstAndLastRows(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        if (numRows >= 2)
        {
            // Создаем временный массив для хранения первой строки
            int[] tempRow = new int[numCols];
            for (int j = 0; j < numCols; j++)
            {
                tempRow[j] = matrix[0, j];
            }

            // Копируем последнюю строку в первую
            for (int j = 0; j < numCols; j++)
            {
                matrix[0, j] = matrix[numRows - 1, j];
            }

            // Копируем временный массив в последнюю строку
            for (int j = 0; j < numCols; j++)
            {
                matrix[numRows - 1, j] = tempRow[j];
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }