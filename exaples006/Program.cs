Console.WriteLine("Введите число N");
string? userinput = Console.ReadLine();
if (userinput == null){
    Console.WriteLine("вы ничего не ввели");
    return;}
    int N = Convert.ToInt32(userinput);
    for (int i = 1; i <= N; i++){
     Console.WriteLine (Math.Pow (i,3));
    }