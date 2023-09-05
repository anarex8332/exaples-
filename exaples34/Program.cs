int GetInt () {
    Random random = new Random ();
    int result = random.Next (99, 1000);
    return result;
}
int elemetsCount = 4;
int[] array = new int[elemetsCount];
int evenNumbers = 0;
for (int i = 0; i < elemetsCount; i++) {
    array[i] = GetInt();
    if (array[i] % 2 == 0){
        evenNumbers++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(evenNumbers);
 