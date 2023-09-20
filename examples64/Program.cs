  void KO(int n)
        { 
            Console.Write(n);
            if (n == 1)
                return;
            else
                KO(n - 1);
        }
        Console.WriteLine("Введите число N");
string N_string = Console.ReadLine(); 
int N = int.Parse(N_string);

KO(N);

