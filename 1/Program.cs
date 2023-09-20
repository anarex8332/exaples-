using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание исходных матриц
        int[,] matrix1 = {
            { 2, 4 },
            { 3, 2 }
        };

        int[,] matrix2 = {
            { 3, 4 },
            { 3, 3 }
        };

        // Проверка возможности умножения матриц
        int matrix1Rows = matrix1.GetLength(0);
        int matrix1Cols = matrix1.GetLength(1);

        int matrix2Rows = matrix2.GetLength(0);
        int matrix2Cols = matrix2.GetLength(1);

        if (matrix1Cols != matrix2Rows)
        {
            Console.WriteLine("Умножение матриц невозможно.");
        }
        else
        {
            // Создание результирующей матрицы
            int[,] resultMatrix = new int[matrix1Rows, matrix2Cols];

            // Вычисление элементов результирующей матрицы
            for (int i = 0; i < matrix1Rows; i++)
            {
                for (int j = 0; j < matrix2Cols; j++)
                {
                    for (int k = 0; k < matrix1Cols; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Вывод результирующей матрицы
            Console.WriteLine("Результирующая матрица:");
            for (int i = 0; i < matrix1Rows; i++)
            {
                for (int j = 0; j < matrix2Cols; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
}
