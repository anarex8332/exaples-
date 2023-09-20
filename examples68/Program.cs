Console.WriteLine("Введите число N");
string n_string = Console.ReadLine(); 
int n = int.Parse(n_string);
    Console.WriteLine("Введите число M");
string m_string = Console.ReadLine(); 
int m = int.Parse(m_string);

AkkermanFunction(m,n);
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}