 int[,,] array = new int[2, 2, 2] { { { 66, 25 }, { 27, 90 } }, { { 34, 41 }, { 26, 55 } } };

        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine("{0}({1},{2},{3})", array[i, j, k], i, j, k);
                }
            }
        }