
int CountPositive(string text, char a, char b, char c)
{
    int result = 0;
    int length = text.Length;
    for(int i = 0; i<length; i++)
    {
        if (text[i] == a) result=result+1;
        if (text[i] == b) result=result-1; 
        if (text[i] == c) result=result-1;
    }
    
    result=result+1;
    return result;
}
Console.WriteLine("Введите числа через пробел: ");
int a = CountPositive(Console.ReadLine(), ' ', '-', '0');
Console.WriteLine("Чисел больше нуля: " + a);

