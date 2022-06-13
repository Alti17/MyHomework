

    int ThirdNumber(int num)
{ 
    if(num > 99)
        {   while (num>999)
            {
                num = num/10;
            }
            
            int result = num%10;
            return result;
            
        }

    else
        {
            return -1;
        }
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int third = ThirdNumber(a);
if(third == -1)
    {
        Console.WriteLine("В вашем числе нет третьей цифры.");
    }
else
    {
        Console.WriteLine($"Третье число: {third}.");
    }