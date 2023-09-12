Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Введите число M: ");
        int M = int.Parse(Console.ReadLine());
double[,] array = new double[N,M];
for (int i = 0; i<N; i++ ) {
    for (int j = 0; j<M; j++){
         Random random = new Random ();
        array[i,j] =Math.Round(random.NextDouble()+random.Next(-100,100),4);
    }
}
for (int i = 0; i<N; i++ ) {
    for (int j = 0; j<M; j++){
        Console.Write (array[i,j]+" ");
    }
    Console.WriteLine();
    }