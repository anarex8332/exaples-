int GetInt () {
    Random random = new Random ();
    int result = random.Next ();
    return result;
}
int elemetsCount = 4;
int[] array = new int[elemetsCount];
int summ = 0;
for (int i = 0; i < elemetsCount; i++) {
    array[i] = GetInt();
    if (i % 2 != 0){
        summ = summ + array[i];
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(summ);
 