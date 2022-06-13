int SecondDigit()

{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"Текущее число: {num}");
    int dozens = num/10;
    int result = dozens%10;
    return result;
}
Console.WriteLine(SecondDigit());