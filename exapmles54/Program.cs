int[] sort(int[] mas){
    int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }                   
                }            
            }
            return mas;
}
int m = 4;
int n = 3;
    int[,] array = new int[n,m];
    for (int i = 0; i<n; i++ ) {
    for (int j = 0; j<m; j++){
         Random random = new Random ();
        array[i,j] =random.Next(10);
    }
}
for (int i = 0; i<n; i++ ) {
    for (int j = 0; j<m; j++){
        Console.Write (array[i,j]+" ");
    }
    Console.WriteLine();
    }

for(int i = 0; i<n; i++ ){
    Console.WriteLine("[{0}]", string.Join(", ", sort(GetRow(array, i))));
}

int[] GetRow(int[,] matrix, int rowNumber)
    {
        return Enumerable.Range(0, matrix.GetLength(1))
                .Select(x => matrix[rowNumber, x])
                .ToArray();
    }