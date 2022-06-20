void Degree(int a, int b)
{
    
    if (b<=0)
    {
        if(b<0)
        {
            b = b*(-1);
            Console.WriteLine("Результат:" + Math.Pow((a),b) + " При условии, что второе число преобразовано в натуральное.");
        }
        else
        {
            Console.WriteLine("Ноль не является натуральным числом.");
        }
    }
    else
    {
        Console.WriteLine(Math.Pow((a),b));
    }
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Degree(a,b);
