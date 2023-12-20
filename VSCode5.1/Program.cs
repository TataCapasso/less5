// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

 {
        // Создаем двумерный массив (матрицу)
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Получаем позиции элемента от пользователя
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        // Получаем значение элемента или сообщение об отсутствии
        int element = GetElementAtPosition(matrix, row, col);

        if (element != int.MinValue)
        {
            Console.WriteLine($"Элемент в позиции [{row},{col}] равен {element}");
        }
        else
        {
            Console.WriteLine($"Элемент в позиции [{row},{col}] не существует в матрице.");
        }
    }

    static int GetElementAtPosition(int[,] matrix, int row, int col)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        // Проверяем, что позиции не выходят за пределы массива
        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            return matrix[row, col];
        }
        else
        {
            // Возвращаем специальное значение для обозначения отсутствия элемента
            return int.MinValue;
        }
    }