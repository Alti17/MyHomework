void Palindrome()
{
    int num = new Random().Next(10000,100000);
    Console.WriteLine($"Текущее число: {num}.");
    int tens_of_thousands = num/10000;
    num = num%10000;
    int thousands = num/1000;
    num = num%1000;
    int hundreds = num/100;
    num = num%100;
    int dozens = num/10;
    int units = num%10;
    if(tens_of_thousands == units && thousands == dozens)
    {
        Console.WriteLine("Это число полиндром.");
    }
    else
    {
        Console.WriteLine("Это число не полиндром.");
    }

}
Palindrome();