Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Введите число M: ");
        int M = int.Parse(Console.ReadLine());
int[,] array = new int[N,M];
for (int i = 0; i<N; i++ ) {
    double average = 0;
    for (int j = 0; j<M; j++){
        Random random = new Random ();
        array[i,j] = random.Next();
        average = average + array[i,j];
        }
        average = average / M;
        Console.WriteLine(average);
    }
