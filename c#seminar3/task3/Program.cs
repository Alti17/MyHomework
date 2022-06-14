
void Cube(int num)
{
    int current = 1;
    while (current<=num)
    {
        Console.WriteLine(Math.Pow((current),3));
        current++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);