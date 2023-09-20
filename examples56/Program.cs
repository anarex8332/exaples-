
        int[,] array = { { 2, 4, 8, 9 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

        int minSumRow = 0; 
        int minSum = int.MaxValue; 
   
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0; 

            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

    
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }

        Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minSumRow);
