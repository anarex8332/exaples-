double GetDouble () {
    Random random = new Random ();
    double result = random.NextDouble () + random.Next();
    return result;
}
int elemetsCount = 5;
double[] array = new double[elemetsCount];
array[0] = GetDouble();
double max = array[0];
double min = array[0];
for (int i = 1; i < elemetsCount; i++) {
    array[i] = GetDouble();
    if (array[i] > max){
        max = array[i];
    }
    if (array[i] < min){
            min = array[i];
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(max-min);