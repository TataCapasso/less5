// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

  {
        // Создаем прямоугольный двумерный массив
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        // Находим строку с наименьшей суммой элементов
        int minSumRowIndex = FindRowWithMinSum(matrix);

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}"); // Добавляем 1, так как строки начинаются с 1, а не с 0
    }

    static int FindRowWithMinSum(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < numRows; i++)
        {
            int currentSum = 0;

            // Вычисляем сумму элементов в текущей строке
            for (int j = 0; j < numCols; j++)
            {
                currentSum += matrix[i, j];
            }

            // Если текущая сумма меньше минимальной, обновляем минимальную сумму и индекс строки
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
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