Console.WriteLine("Веедите кордитаны для первой точки");
Console.WriteLine("введите кордитаны X");
string? CordinateX = Console.ReadLine(); 
if (CordinateX == null){
    Console.WriteLine("вы ничего не ввели");
    return;}
    Console.WriteLine("введите кордитаны Y");
string? CordinateY = Console.ReadLine(); 
if (CordinateY == null){
    Console.WriteLine("вы ничего не ввели");
    return;}
    Console.WriteLine("введите кордитаны Z");
string? CordinateZ = Console.ReadLine(); 
if (CordinateZ == null){
    Console.WriteLine("вы ничего не ввели");
    return;}
    Console.WriteLine("Веедите кордитаны для второй точки");
    Console.WriteLine("введите кордитаны X");
string? Cordinate1X = Console.ReadLine(); 
if (Cordinate1X == null){
    Console.WriteLine("вы ничего не ввели");
    return;}
    Console.WriteLine("введите кордитаны Y");
string? Cordinate1Y = Console.ReadLine(); 
if (Cordinate1Y == null){
    Console.WriteLine("вы ничего не ввели");
    return;}
    Console.WriteLine("введите кордитаны Z");
string? Cordinate1Z = Console.ReadLine(); 
if (Cordinate1Z == null){
    Console.WriteLine("вы ничего не ввели");
    return;}
int x1 = Convert.ToInt32(CordinateX);
int y1 = Convert.ToInt32(CordinateY);
int z1 = Convert.ToInt32(CordinateZ);
int x2 = Convert.ToInt32(Cordinate1X);
int y2 = Convert.ToInt32(Cordinate1Y);
int z2 = Convert.ToInt32(Cordinate1Z);
double result = Math.Sqrt (Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine(result);