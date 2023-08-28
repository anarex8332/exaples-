int reversAndConvertToInt (string text){ 
    char[] chars = text.ToCharArray ();
    Array.Reverse(chars);
    string reversedText = new string (chars);
    return  Convert.ToInt32(reversedText);
}
Console.WriteLine("Напишите число");
string? userinput = Console.ReadLine();
if (userinput == null){
    Console.WriteLine("вы ничего не ввели");
    return;
}
if (userinput.Length !=5){
    Console.WriteLine("Символов не 5");
    return;
}
int user_input_integer = Convert.ToInt32(userinput);
int resalt1 = reversAndConvertToInt (userinput);
if (resalt1 == user_input_integer ){
    Console.WriteLine("Да");
}
else {Console.WriteLine("Нет");}
