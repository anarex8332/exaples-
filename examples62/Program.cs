int n = 4; 

        int[,] array = new int[n, n]; 

        int value = 1;

        int top = 0; 
        int bottom = n - 1; 
        int left = 0;
        int right = n - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                array[top, i] = value;
                value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                array[i, right] = value;
                value++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                array[bottom, i] = value;
                value++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                array[i, left] = value;
                value++;
            }
            left++;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
