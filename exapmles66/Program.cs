    Console.WriteLine("Введите число N");
string N_string = Console.ReadLine(); 
int N = int.Parse(N_string);
    Console.WriteLine("Введите число M");
string M_string = Console.ReadLine(); 
int M = int.Parse(M_string);
Console.Write(SumNumbers(M,N));
int SumNumbers(int M, int N)
        {
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);            
}
        
